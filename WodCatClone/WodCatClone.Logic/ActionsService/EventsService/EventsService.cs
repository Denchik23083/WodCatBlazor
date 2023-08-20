using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using WodCatClone.WebDb.ActionsRepository.EventsRepository;
using WodCatClone.WebDb.UserRepository;

namespace WodCatClone.Logic.ActionsService.EventsService
{
    public class EventsService : IEventsService
    {
        private readonly IEventsRepository _repository;
        private readonly IUserRepository _userRepository;

        public EventsService(IEventsRepository repository, IUserRepository userRepository)
        {
            _repository = repository;
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<Events>> GetAllEvents()
        {
            return await _repository.GetAllEvents();
        }

        public IEnumerable<User> GetAllEventsUsers(int id)
        {
            return _repository.GetAllEventsUsers(id);
        }

        public IEnumerable<EventTimeUser> GetAllEventTimeUsers(int eventId)
        {
            return _repository.GetAllEventTimeUsers(eventId)
                .OrderByDescending(b => b.Time)
                .Take(3)
                .Reverse();
        }

        public IEnumerable<EventEmblem> GetAllEventEmblem()
        {
            return _repository.GetAllEventEmblem();
        }

        public Events GetEvent(int eventId)
        {
            return _repository.GetEvent(eventId);
        }

        public EventTimeUser GetEventTimeUser(int eventId, int userId)
        {
            return _repository.GetEventTimeUser(eventId, userId);
        }

        public string GetImage(int id)
        {
            return _repository.GetImage(id).Image;
        }

        public async Task<bool> AddEvent(Events @event)
        {
            var loginUser = AuthService.AuthService.User;
            var user = await _userRepository.GetUser(loginUser);

            if (user is null)
            {
                return false;
            }

            return _repository.AddEvent(@event, user);
        }

        public async Task<bool> EditEvent(Events @event, int eventId)
        {
            var loginUser = AuthService.AuthService.User;
            var user = await _userRepository.GetUser(loginUser);

            if (user is null)
            {
                return false;
            }

            var eventToEdit = _repository.GetEvent(eventId);

            if (eventToEdit is null)
            {
                return false;
            }

            return _repository.EditEvent(@event, eventToEdit, user);
        }

        public bool RemoveEvent(int eventId)
        {
            var allUsers = _repository.GetAllEventsUsers(eventId);

            var eventToRemove = _repository.GetEvent(eventId);

            if (eventToRemove is null)
            {
                return false;
            }

            return _repository.RemoveEvent(allUsers, eventToRemove);
        }

        public bool AutoRemoveEvent(int eventId)
        {
            var allUsers = _repository.GetAllEventsUsers(eventId);

            var eventToRemove = _repository.GetEvent(eventId);

            if (eventToRemove is null)
            {
                return false;
            }

            var allUsersTime = _repository.GetAllEventTimeUsers(eventId)
                .OrderByDescending(b => b.Time)
                .Take(3)
                .Reverse();

            var usersToList = new List<User>();

            foreach (var item in allUsersTime)
            {
                var user = _userRepository.GetUser(item.UserId);

                if (user is not null)
                {
                    usersToList.Add(user);
                }
            }

            return _repository.AutoRemoveEvent(allUsers, usersToList, eventToRemove);
        }

        public bool JoinEvent(int eventId, User user)
        {
            var loginUser = _userRepository.GetUser(user.Id);

            if (loginUser is null)
            {
                return false;
            }

            return _repository.JoinEvent(eventId, loginUser);
        }

        public bool ExitEvent(int eventId, User user)
        {
            var loginUser = _userRepository.GetUser(user.Id);

            if (loginUser is null)
            {
                return false;
            }

            return _repository.ExitEvent(eventId, loginUser);
        }

        public bool AddEventTimeUser(EventTimeUser eventTimeUser)
        {
            return _repository.AddEventTimeUser(eventTimeUser);
        }
    }
}
