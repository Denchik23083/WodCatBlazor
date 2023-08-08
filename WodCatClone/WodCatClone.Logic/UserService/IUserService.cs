﻿using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Logic.UserService
{
    public interface IUserService
    {
        public IEnumerable<User> GetAllUsers();

        bool IsLoginUser();

        Task<User?> GetUser();

        User GetUser(int? id);

        User GetUser(string nickName);

        Gender GetGender(int? id);

        Gender GetGender(string gender);

        bool EditUserHall(User user, int id);

        bool Update(User updateUser, int id, string genderName);

        bool UpdateAuth(User updateUser, int id);
    }
}
