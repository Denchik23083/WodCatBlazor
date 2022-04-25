﻿using System.Collections.Generic;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Logic.UserService
{
    public interface IUserService
    {
        public IEnumerable<User> GetAllUsers();

        bool IsLoginUser();

        User GetUser();

        User GetUser(int? id);

        User GetUser(string nickName);

        void Join(int hallId);

        void Exit(int hallId);
    }
}
