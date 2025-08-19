using POS_V1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_V1._Repositories
{
    public interface ILoginRepository
    {
        LoginModel ValidateUser(string username, string password);

    }
}
