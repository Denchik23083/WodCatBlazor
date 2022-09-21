using System.Collections.Generic;
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

        public IEnumerable<Halls> GetAllHalls()
        {
            return _repository.GetAllHalls();
        }

        public IEnumerable<HallEmblem> GetAllHallEmblem()
        {
            return _repository.GetAllHallEmblem();
        }

        public IEnumerable<User> GetAllHallsUsers(int id)
        {
            return _repository.GetAllHallsUsers(id);
        }

        public Halls GetHall(int hallId)
        {
            return _repository.GetHall(hallId);
        }

        public Halls GetHall(int? hallId)
        {
            return _repository.GetHall(hallId);
        }

        public string GetImage(int? imageId)
        {
            return _repository.GetImage(imageId)?.Image;
        }

        public bool AddHall(Halls hall)
        {
            var loginUser = AuthService.AuthService.User;
            var user = _userRepository.GetUser(loginUser);

            if (user is null)
            {
                return false;
            }

            hall.UserId = user.Id;

            var result = _repository.AddHall(hall);

            if (result)
            {
                user.Points += 50;
            }

            return result;
        }

        public bool EditHall(Halls hall, int hallId)
        {
            var loginUser = AuthService.AuthService.User;
            var user = _userRepository.GetUser(loginUser);

            if (user is null)
            {
                return false;
            }

            var result = _repository.EditHall(hall, hallId);

            if (result)
            {
                user.Points += 25;
            }

            return result;
        }

        public bool RemoveHall(int hallId)
        {
            var joinUserHall = _repository.GetAllHallsUsers(hallId);

            foreach (var item in joinUserHall)
            {
                item.HallId = null;
            }

            return _repository.RemoveHall(hallId);
        }

        public bool JoinHall(int hallId, User user)
        {
            AuthService.AuthService.User.HallId = hallId;

            return _repository.JoinHall(hallId, user);
        }

        public bool ExitHall(int hallId, User user)
        {
            AuthService.AuthService.User.HallId = null;

            return _repository.ExitHall(hallId, user);
        }

        public int Athlete(int hallId)
        {
            return _repository.Athlete(hallId);
        }
    }
}
