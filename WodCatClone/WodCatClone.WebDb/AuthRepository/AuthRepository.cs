﻿using System.Linq;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.WebDb.AuthRepository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly WodCatCloneContext _context;

        public AuthRepository(WodCatCloneContext context)
        {
            _context = context;
        }

        public User Login(Login login)
        {
            var user = _context.Users.FirstOrDefault(l => l.Email == login.Email &&
                                                          l.Password == login.Password);

            return user;
        }

        public bool Register(Register register)
        {
            var allUsers = _context.Users;

            if (allUsers.Any(b => b.Email == register.Email))
            {
                return false;
            }

            _context.Users.Add(Map(register));
            _context.SaveChanges();

            return true;
        }

        private User Map(Register model)
        {
            return new User
            {
                Id = model.Id,
                Name = model.Name,
                Email = model.Email,
                Password = model.Password,
            };
        }
    }
}