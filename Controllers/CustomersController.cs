using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.viewModels;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();

        }
        //test comment for commit
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        //
        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = membershipTypes
            };

            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }

        // GET: Customers

        public ActionResult Index()
        {
            //var customers = GetCustomers();
            var customers = _context.Customers.Include(mt => mt.MembershipType).ToList();
            //viewmodel.CustomersList = customers;
            var viewModel = new CustomerViewModel
            {
                CustomersList = customers
            };
            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(mt => mt.MembershipType).FirstOrDefault(t => t.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);

        }

        //private IEnumerable<Customer> GetCustomers()
        //{
        //    var customers = new List<Customer>
        //    {
        //        new Customer
        //        {
        //            Id = 1,
        //            Name = "John"
        //        },
        //        new Customer
        //        {
        //            Id = 2,
        //            Name = "Mary"
        //        }
        //    };

        //    return customers;
        //}

    }
}