using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class NewCustomerViewModel /*: IValidatableObject*/
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (!Customer.BirthDate.HasValue)
        //    {
        //        yield return new ValidationResult("BirthDate required", new []{nameof(Customer.BirthDate)}); 
        //    }
        //}
    }
}