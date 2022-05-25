using System.Collections.Generic;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.WebDb.UserRepository;

namespace WodCatClone.Logic.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _repository.GetAllUsers();
        }

        public bool IsLoginUser()
        {
            return AuthService.AuthService.IsLoginUser;
        }

        public User GetUser()
        {
            return _repository.GetUser(AuthService.AuthService.User);
        }

        public User GetUser(int? id)
        {
            return _repository.GetUser(id);
        }

        public User GetUser(string nickName)
        {
            return _repository.GetUser(nickName);
        }

        public Gender GetGender(int? id)
        {
            return _repository.GetGender(id);
        }

        public Gender GetGender(string gender)
        {
            return _repository.GetGender(gender);
        }

        public bool EditUserHall(User user, int id)
        {
            AuthService.AuthService.User.HallId = id;

            return _repository.EditUserHall(user, id);
        }

        public bool Update(User updateUser, int id, Gender gender)
        {
            var genre = _repository.GetGender(gender.Name);

            updateUser.GenderId = genre.Id;

            return _repository.Update(updateUser, id);
        }

        public bool UpdateAuth(User updateUser, int id)
        {
            return _repository.UpdateAuth(updateUser, id);
        }

        public void Join(int hallId)
        {
            AuthService.AuthService.User.HallId = hallId;

            _repository.Join(hallId);
        }

        public void Exit(int hallId)
        {
            AuthService.AuthService.User.HallId = null;

            _repository.Exit(hallId);
        }
    }
}
