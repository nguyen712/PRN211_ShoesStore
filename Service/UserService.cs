using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRN211_ShoesStore.Models.DTO;
using PRN211_ShoesStore.Models.Entity;
using PRN211_ShoesStore.Repository;
using PRN211_ShoesStore.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PRN211_ShoesStore.Service
{
    public class UserService
    {
        private UserRepository _userRepository = new UserRepository();

        private RoleRepository _roleRepository= new RoleRepository();

        private ShoesRepository _shoesRepository= new ShoesRepository();

        private ShoesImageRepository shoesImageRepository= new ShoesImageRepository();

        public Object Register(string name, string username, string pwd, string confirmPwd, string phone, string email)
        {
            bool pwdEqual = String.Equals(pwd, confirmPwd, StringComparison.OrdinalIgnoreCase);
            if(pwdEqual == false)
            {
                return "password and confirm password is not match";
            }
            if (ValidateForm.IsValidEmail(email))
            {
                return "Email is wrong format buikhoinguyen2001@gmail.com";
            }
            if (String.IsNullOrEmpty(email))
            {
                return "Email is null or empty";
            }
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
            user.status = true;
            _userRepository.Create(user);
            return user;
        }

        private ShoesDTO convertShoesToShoesDTO(Shoes shoes, byte[] image)
        {
            ShoesDTO shoesDTO = new ShoesDTO();
            shoesDTO.id= shoes.id;
            shoesDTO.name= shoes.name;
            shoesDTO.price= shoes.price;
            shoesDTO.quantity= shoes.quantity;
            shoesDTO.description = shoes.shoesDetails;
            shoesDTO.image = image;
            return shoesDTO;
        }

        private List<ShoesDTO> convertListShoestoListShoesDTO(List<Shoes> shoesList)
        {
            ShoesDTO shoesDTO = new ShoesDTO();
            List<ShoesDTO> res = new List<ShoesDTO>();
            foreach (var item in shoesList)
            {
                List<ShoesImage> shoesImg = shoesImageRepository.GetAll().Where(p => p.shoesId == item.id).Include(p => p.image).ToList();
                foreach (var img in shoesImg)
                {
                    shoesDTO = convertShoesToShoesDTO(item, img.image.image);
                    res.Add(shoesDTO);
                }
            }
            return res;
        }


        public List<ShoesDTO> Search(string name)
        {
            List<Shoes> shoes = new List<Shoes>();
            if (!String.IsNullOrEmpty(name))
            {
                shoes = _shoesRepository.GetAll().Where(p => p.name.Contains(name)).ToList();
            }
            else
            {
                shoes = _shoesRepository.GetAll().ToList();
            }
            return convertListShoestoListShoesDTO(shoes);
        }

        public List<ShoesDTO> ShowShoes()
        {
            List<Shoes> shoes = _shoesRepository.GetAll().ToList();
            return convertListShoestoListShoesDTO(shoes);
        }
    }
}
