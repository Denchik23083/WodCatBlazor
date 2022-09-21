using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<Events> GetAllEvents()
        {
            return _repository.GetAllEvents();
        }

        public IEnumerable<User> GetAllEventsUsers(int id)
        {
            return _repository.GetAllEventsUsers(id);
        }

        public IEnumerable<EventTimeUser> GetAllEventTimeUsers(int eventId)
        {
            return _repository.GetAllEventTimeUsers(eventId)
                .OrderByDescending(b => b.Time)
                .Take(3);
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

        public bool AddEvent(Events @event)
        {
            var loginUser = AuthService.AuthService.User;
            var user = _userRepository.GetUser(loginUser);

            if (user is null)
            {
                return false;
            }

            @event.UserId = user.Id;

            var result = _repository.AddEvent(@event);

            if (result)
            {
                user.Points += 100;
            }

            return result;
        }

        public bool EditEvent(Events @event, int eventId)
        {
            var loginUser = AuthService.AuthService.User;
            var user = _userRepository.GetUser(loginUser);

            if (user is null)
            {
                return false;
            }

            var result = _repository.EditEvent(@event, eventId);

            if (result)
            {
                user.Points += 50;
            }

            return result;
        }

        public bool RemoveEvent(int eventId)
        {
            var allUsers = _userRepository.GetAllUsers();

            foreach (var allUser in allUsers)
            {
                allUser.EventId = null;
            }

            return _repository.RemoveEvent(eventId);
        }

        public bool AutoRemoveEvent(int eventId)
        {
            var allUsers = _userRepository.GetAllUsers();

            foreach (var allUser in allUsers)
            {
                allUser.EventId = null;
            }

            var allUsersTime = _repository.GetAllEventTimeUsers(eventId)
                .OrderByDescending(b => b.Time)
                .Take(3);

            var points = 200;

            foreach (var item in allUsersTime)
            {
                var user = _userRepository.GetUser(item.Id);

                if (user is not null)
                {
                    user.Points += points;
                }

                points /= 2;
            }

            return _repository.AutoRemoveEvent(eventId);
        }

        public bool JoinEvent(int eventId, User user)
        {
            AuthService.AuthService.User.EventId = eventId;

            return _repository.JoinEvent(eventId, user);
        }

        public bool ExitEvent(int eventId, User user)
        {
            AuthService.AuthService.User.EventId = null;

            return _repository.ExitEvent(eventId, user);
        }

        public bool AddEventTimeUser(EventTimeUser eventTimeUser)
        {
            return _repository.AddEventTimeUser(eventTimeUser);
        }
    }
}
