using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidly.Managers
{
    public interface IUserManager
    {
        string GetTrimmedUsername(string username);
    }
}
