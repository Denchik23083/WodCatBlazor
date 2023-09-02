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

        public async Task<IEnumerable<Halls>> GetAllHalls()
        {
            return await _repository.GetAllHalls();
        }

        public async Task<IEnumerable<HallEmblem>> GetAllHallEmblem()
        {
            return await _repository.GetAllHallEmblem();
        }

        public async Task<Halls?> GetHall(int hallId)
        {
            return await _repository.GetHall(hallId);
        }

        public Halls GetHall(int? hallId)
        {
            return _repository.GetHall(hallId);
        }

        public string GetImage(int? imageId)
        {
            return _repository.GetImage(imageId)?.Image;
        }

        public async Task<bool> AddHall(Halls hall)
        {
            var user = AuthService.AuthService.User;
            var loginUser = _userRepository.GetUser(user!.Id);

            if (loginUser is null)
            {
                return false;
            }

            hall.UserId = loginUser.Id;

            loginUser.Points += 50;

            return await _repository.AddHall(hall, loginUser);
        }

        public async Task<bool> EditHall(Halls hall, int hallId)
        {
            var user = AuthService.AuthService.User;
            var loginUser = _userRepository.GetUser(user!.Id);

            if (loginUser is null)
            {
                return false;
            }

            var hallToEdit = await _repository.GetHall(hallId);

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

            return await _repository.EditHall(hallToEdit, loginUser);
        }

        public async Task<bool> RemoveHall(int hallId)
        {
            var hallToRemove = await _repository.GetHall(hallId);

            if (hallToRemove is null)
            {
                return false;
            }

            return await _repository.RemoveHall(hallToRemove);
        }

        public async Task<bool> JoinHall(int hallId, User user)
        {
            var loginUser = _userRepository.GetUser(user.Id);

            if (loginUser is null)
            {
                return false;
            }

            loginUser.HallId = hallId;

            return await _repository.JoinHall(loginUser);
        }

        public async Task<bool> ExitHall(int hallId, User user)
        {
            var loginUser = _userRepository.GetUser(user.Id);

            if (loginUser is null)
            {
                return false;
            }

            loginUser.HallId = null;

            return await _repository.ExitHall(user);
        }

        public async Task<int> Athlete(int hallId)
        {
            return await _repository.Athlete(hallId);
        }
    }
}
