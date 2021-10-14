using POSRestaurantAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSRestaurantAPI.Services.UserServices
{
    public class UserServices : IUserServices
    {
        private static readonly List<MS_UserMasterModel> _userMaster = new List<MS_UserMasterModel>();

        public async Task<List<MS_UserMasterModel>> GetAllUser()
        {
            return _userMaster;
        }

        public async Task<MS_UserMasterModel> GetUserById(string id)
        {
            var values = _userMaster.FirstOrDefault(x => x.Id == id);
            return values;
        }

        public async Task<MS_UserMasterModel> GetUserByName(string name)
        {
            var values = _userMaster.FirstOrDefault(x => x.Name == name);
            return values;
        }

        public async Task<List<MS_UserMasterModel>> CreateUser(MS_UserMasterModel user)
        {
            user.Id = Guid.NewGuid().ToString();
            _userMaster.Add(user);
            return _userMaster;
        }

        public async Task<MS_UserMasterModel> UpdateUser(string id, MS_UserMasterModel user)
        {
            var values = _userMaster.FirstOrDefault(x => x.Id == id);
            values.Name = user.Name;
            return values;
        }

        public async Task<string> DeleteUser(string id)
        {
            var values = _userMaster.FirstOrDefault(x => x.Id == id);
            _userMaster.RemoveAll(x => x.Id == id);
            return id;
        }
    }
}
