using POSRestaurantAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSRestaurantAPI.Services.UserServices
{
    public interface IUserServices
    {
        Task<List<MS_UserMasterModel>> GetAllUser();
        Task<MS_UserMasterModel> GetUserById(string id);
        Task<MS_UserMasterModel> GetUserByName(string name);
        Task<List<MS_UserMasterModel>> CreateUser(MS_UserMasterModel user);
        Task<MS_UserMasterModel> UpdateUser(string id, MS_UserMasterModel user);
        Task<string> DeleteUser(string id);
    }
}
