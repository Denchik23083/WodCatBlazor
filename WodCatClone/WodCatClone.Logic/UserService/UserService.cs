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

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _repository.GetAllUsersAsync();
        }

        public async Task<IEnumerable<Gender>> GetAllGendersAsync()
        {
            return await _repository.GetAllGendersAsync();
        }

        public Task<bool> IsLoginUserAsync()
        {
            return Task.FromResult(AuthService.AuthService.IsLoginUser);
        }

        public async Task<User?> GetUserAsync()
        {
            var user = AuthService.AuthService.User;

            return user is null ? user : await _repository.GetUserAsync(user.Id);
        }

        public async Task<User?> GetUserAsync(string nickName)
        {
            return await _repository.GetUserAsync(nickName);
        }

        public async Task<bool> EditUserHallAsync(User user, int id)
        {
            var loginUser = await _repository.GetUserAsync(user.Id);

            if (loginUser is null)
            {
                return false;
            }

            loginUser.HallId = id;

            return await _repository.EditUserHallAsync(loginUser);
        }

        public async Task<bool> UpdateAsync(User updateUser, int id)
        {
            var userToUpdate = await _repository.GetUserAsync(id);

            if (userToUpdate is null)
            {
                return false;
            }

            userToUpdate.Name = updateUser.Name;
            userToUpdate.Surname = updateUser.Surname;
            userToUpdate.Town = updateUser.Town;
            userToUpdate.GenderId = updateUser.GenderId;
            userToUpdate.Birthday = updateUser.Birthday;
            userToUpdate.Height = updateUser.Height;
            userToUpdate.Weight = updateUser.Weight;
            userToUpdate.AboutMe = updateUser.AboutMe;

            return await _repository.UpdateAsync(userToUpdate);
        }

        public async Task<bool> UpdateAuthAsync(User updateAuth, int id)
        {
            var userToUpdate = await _repository.GetUserAsync(id);

            if (userToUpdate is null)
            {
                return false;
            }

            var allUsers = await _repository.GetAllUsersAsync();

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

            return await _repository.UpdateAuthAsync(userToUpdate);
        }
    }
}
