using POS_V1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_V1._Repositories
{
    public interface IUserRepository
    {
        void Add(UserModel userModel);
        void Edit(UserModel userModel);
        void SoftDelete(int id);

        IEnumerable<UserModel> GetAll();
        IEnumerable<UserModel> GetByValue(string value);

        IEnumerable<UserModel> GetByFilter(UserFilterModel userFilterModel);
    }
}
