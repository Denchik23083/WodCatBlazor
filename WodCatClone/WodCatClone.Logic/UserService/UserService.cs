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

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await _repository.GetAllUsers();
        }

        public bool IsLoginUser()
        {
            return AuthService.AuthService.IsLoginUser;
        }

        public async Task<User?> GetUser()
        {
            var user = AuthService.AuthService.User;

            if (user is null)
            {
                return user!;
            }

            return await _repository.GetUser(user);
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
            var loginUser = _repository.GetUser(user.Id);

            if (loginUser is null)
            {
                return false;
            }

            return _repository.EditUserHall(loginUser, id);
        }

        public bool Update(User updateUser, int id, string genderName)
        {
            var genre = _repository.GetGender(genderName);

            if (genre is null)
            {
                return false;
            }

            var userToUpdate = _repository.GetUser(id);

            if (userToUpdate is null)
            {
                return false;
            }

            return _repository.Update(updateUser, userToUpdate, genre);
        }

        public async Task<bool> UpdateAuth(User updateUser, int id)
        {
            var userToUpdate = _repository.GetUser(id);

            if (userToUpdate is null)
            {
                return false;
            }

            var allUsers = await _repository.GetAllUsers();

            if (allUsers.Any(b => b.Email.Equals(updateUser.Email)
                                  || b.NickName.Equals(updateUser.NickName)))
            {
                return false;
            }

            return _repository.UpdateAuth(updateUser, userToUpdate);
        }
    }
}
