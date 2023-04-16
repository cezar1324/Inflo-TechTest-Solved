using System;
using System.Collections.Generic;
using MyApp.Data;
using MyApp.Models;
using MyApp.Services.Domain.Implementations.Base;
using MyApp.Services.Domain.Interfaces;

namespace MyApp.Services.Domain.Implementations
{
    public class UserService : ServiceBase<User>, IUserService
    {
        public UserService(IDataAccess dataAccess) : base(dataAccess) { }

        /// <summary>
        /// Return users by active state
        /// </summary>
        /// <param name="isActive"></param>
        /// <returns></returns>
        public IEnumerable<User> FilterByActive(bool isActive)
        {
            var users = this.GetAll();
            List<User> filtredActiveUsers = new List<User>();
            foreach (var user in users)
            {
                if (user.IsActive == isActive)
                {
                    filtredActiveUsers.Add(user);
                }
            }
            return filtredActiveUsers;
        }
    }
}
