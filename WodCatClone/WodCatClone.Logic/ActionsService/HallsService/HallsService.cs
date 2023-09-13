using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.WebDb.ActionsRepository.HallsRepository;
using WodCatClone.WebDb.UserRepository;

namespace WodCatClone.Logic.ActionsService.HallsService
{
    public class HallsService : IHallsService
    {
        private readonly IHallsRepository _repository;
        private readonly IUserRepository _userRepository;

        public HallsService(IHallsRepository repository, IUserRepository userRepository)
        {
            _repository = repository;
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<Halls>> GetAllHallsAsync()
        {
            return await _repository.GetAllHallsAsync();
        }

        public async Task<IEnumerable<HallEmblem>> GetAllHallEmblemAsync()
        {
            return await _repository.GetAllHallEmblemAsync();
        }

        public async Task<Halls?> GetHallAsync(int hallId)
        {
            return await _repository.GetHallAsync(hallId);
        }

        public async Task<bool> AddHallAsync(Halls hall)
        {
            var user = AuthService.AuthService.User;
            var loginUser = await _userRepository.GetUserAsync(user!.Id);

            if (loginUser is null)
            {
                return false;
            }

            hall.UserId = loginUser.Id;

            loginUser.Points += 50;

            return await _repository.AddHallAsync(hall, loginUser);
        }

        public async Task<bool> EditHallAsync(Halls hall, int hallId)
        {
            var user = AuthService.AuthService.User;
            var loginUser = await _userRepository.GetUserAsync(user!.Id);

            if (loginUser is null)
            {
                return false;
            }

            var hallToEdit = await _repository.GetHallAsync(hallId);

            if (hallToEdit is null)
            {
                return false;
            }

            hallToEdit.Name = hall.Name;
            hallToEdit.Type = hall.Type;
            hallToEdit.Town = hall.Town;
            hallToEdit.Location = hall.Location;
            hallToEdit.Rating = hall.Rating;
            hallToEdit.Description = hall.Description;
            hallToEdit.EmblemHallId = hall.EmblemHallId;

            loginUser.Points += 25;

            return await _repository.EditHallAsync(hallToEdit, loginUser);
        }

        public async Task<bool> RemoveHallAsync(int hallId)
        {
            var hallToRemove = await _repository.GetHallAsync(hallId);

            if (hallToRemove is null)
            {
                return false;
            }

            return await _repository.RemoveHallAsync(hallToRemove);
        }

        public async Task<bool> JoinHallAsync(int hallId, User user)
        {
            var loginUser = await _userRepository.GetUserAsync(user.Id);

            if (loginUser is null)
            {
                return false;
            }

            loginUser.HallId = hallId;

            return await _repository.JoinHallAsync(loginUser);
        }

        public async Task<bool> ExitHallAsync(int hallId, User user)
        {
            var loginUser = await _userRepository.GetUserAsync(user.Id);

            if (loginUser is null)
            {
                return false;
            }

            loginUser.HallId = null;

            return await _repository.ExitHallAsync(user);
        }
    }
}
