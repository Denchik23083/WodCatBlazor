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
            var endEvents = await _repository.GetAllEndEvents();
            
            await _repository.RemoveEndEvents(endEvents);

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

        public async Task<IEnumerable<EventEmblem>> GetAllEventEmblem()
        {
            return await _repository.GetAllEventEmblem();
        }

        public Events GetEvent(int eventId)
        {
            return _repository.GetEvent(eventId);
        }

        public EventTimeUser GetEventTimeUser(int eventId, int userId)
        {
            return _repository.GetEventTimeUser(eventId, userId);
        }

        public async Task<bool> AddEvent(Events @event)
        {
            var user = AuthService.AuthService.User;
            var loginUser = _userRepository.GetUser(user!.Id);

            if (loginUser is null)
            {
                return false;
            }

            @event.UserId = loginUser.Id;

            loginUser.Points += 100;

            return await _repository.AddEvent(@event, loginUser);
        }

        public async Task<bool> EditEvent(Events @event, int eventId)
        {
            var user = AuthService.AuthService.User;
            var loginUser = _userRepository.GetUser(user!.Id);

            if (loginUser is null)
            {
                return false;
            }

            var eventToEdit = _repository.GetEvent(eventId);

            if (eventToEdit is null)
            {
                return false;
            }

            eventToEdit.Name = @event.Name;
            eventToEdit.Town = @event.Town;
            eventToEdit.TypeEvent = @event.TypeEvent;
            eventToEdit.TypeSport = @event.TypeSport;
            eventToEdit.Location = @event.Description;
            eventToEdit.StartDate = @event.StartDate;
            eventToEdit.EndDate = @event.EndDate;
            eventToEdit.EventsEmblemId = @event.EventsEmblemId;
            eventToEdit.HallId = @event.HallId;

            loginUser.Points += 50;

            return await _repository.EditEvent(eventToEdit, loginUser);
        }

        public async Task<bool> RemoveEvent(int eventId)
        {
            var eventToRemove = _repository.GetEvent(eventId);

            if (eventToRemove is null)
            {
                return false;
            }

            return await _repository.RemoveEvent(eventToRemove);
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
