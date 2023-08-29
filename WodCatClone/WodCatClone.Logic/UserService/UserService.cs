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

        public async Task<IEnumerable<Gender>> GetGenders()
        {
            return await _repository.GetGenders();
        }

        public bool IsLoginUser()
        {
            return AuthService.AuthService.IsLoginUser;
        }

        public User? GetUser()
        {
            var user = AuthService.AuthService.User;

            return user is null ? user : _repository.GetUser(user.Id);
        }

        public async Task<User?> GetUser(int id)
        {
            return _repository.GetUser(id);
        }

        public async Task<User?> GetUser(string nickName)
        {
            return await _repository.GetUser(nickName);
        }

        public Gender GetGender(int id)
        {
            return _repository.GetGender(id);
        }

        public async Task<bool> EditUserHall(User user, int id)
        {
            var loginUser = _repository.GetUser(user.Id);

            loginUser.HallId = id;

            return await _repository.EditUserHall(loginUser);
        }

        public async Task<bool> Update(User updateUser, int id)
        {
            var userToUpdate = _repository.GetUser(id);

            userToUpdate.Name = updateUser.Name;
            userToUpdate.Surname = updateUser.Surname;
            userToUpdate.Town = updateUser.Town;
            userToUpdate.HallId = updateUser.HallId;
            userToUpdate.GenderId = updateUser.GenderId;
            userToUpdate.Birthday = updateUser.Birthday;
            userToUpdate.Height = updateUser.Height;
            userToUpdate.Weight = updateUser.Weight;
            userToUpdate.AboutMe = updateUser.AboutMe;

            return await _repository.Update(userToUpdate);
        }

        public async Task<bool> UpdateAuth(User updateAuth, int id)
        {
            var userToUpdate = _repository.GetUser(id);

            var allUsers = await _repository.GetAllUsers();

            var allUpdateUsers = allUsers.ToList();

            var users = allUpdateUsers.Where(_ => _.Id != id).ToList();

            if (users.Any(b => b.Email!.Equals(updateAuth.Email)
                                    || b.NickName!.Equals(updateAuth.NickName)))
            {
                return false;
            }

            userToUpdate.NickName = updateAuth.NickName;
            userToUpdate.Email = updateAuth.Email;
            userToUpdate.Password = updateAuth.Password;

            return await _repository.UpdateAuth(userToUpdate);
        }
    }
}
