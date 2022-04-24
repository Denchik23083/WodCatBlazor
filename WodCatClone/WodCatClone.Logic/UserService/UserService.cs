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

        public string GetGender(int? id)
        {
            var gender = _repository.GetGender(id);

            return gender.Image;
        }

        public void Join(int hallId)
        {
            AuthService.AuthService.User.HallId = hallId;

            _repository.Join(hallId);
        }

        public void Exit(int hallId)
        {
            _repository.Exit(hallId);
        }
    }
}
