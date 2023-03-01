using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRN211_ShoesStore.Models.Entity;
using PRN211_ShoesStore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PRN211_ShoesStore.Service
{
    public class UserService
    {
        private UserRepository _userRepository = new UserRepository();

        private RoleRepository _roleRepository= new RoleRepository();

        public User Register(string name, string username, string pwd, string phone, string email)
        {
            var user = new User();
            user.name = name;
            user.username = username;
            user.password = pwd;
            user.phone = phone;
            user.email = email;
            Role role = _roleRepository.GetAll().ToList().Where(r => r.roleName.Equals("User")).First();
            //List<User> users = _userRepository.GetAll().Include(x => x.role).ToList();
            if (role != null)
            {
                user.roleId = role.id;
            }
            user.createDate = System.DateTime.Now;
            _userRepository.Create(user);
            return user;
        }
    }
}
