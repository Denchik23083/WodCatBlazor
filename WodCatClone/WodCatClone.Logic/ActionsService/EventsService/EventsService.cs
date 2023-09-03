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

        public async Task<IEnumerable<Events>> GetAllEndEvents()
        {
            return await _repository.GetAllEndEvents();
        }

        public async Task<IEnumerable<EventEmblem>> GetAllEventEmblem()
        {
            return await _repository.GetAllEventEmblem();
        }

        public async Task<Events?> GetEvent(int eventId)
        {
            return await _repository.GetEvent(eventId);
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

            var eventToEdit = await _repository.GetEvent(eventId);

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
            var eventToRemove = await _repository.GetEvent(eventId);

            if (eventToRemove is null)
            {
                return false;
            }

            return await _repository.RemoveEvent(eventToRemove);
        }

        public async Task<bool> AutoRemoveEvent(Events eventToRemove)
        {
            var allUsersTime = eventToRemove.EventTimeUsers!
                .OrderByDescending(b => b.Time)
                .Take(3)
                .Reverse();

            var usersToList = allUsersTime.Select(item => item.User).ToList();

            return await _repository.AutoRemoveEvent(usersToList!, eventToRemove);
        }

        public async Task<bool> JoinEvent(int eventId, User user)
        {
            var loginUser = _userRepository.GetUser(user.Id);

            if (loginUser is null)
            {
                return false;
            }

            loginUser.EventId = eventId;

            return await _repository.JoinEvent(loginUser);
        }

        public async Task<bool> ExitEvent(int eventId, User user)
        {
            var loginUser = _userRepository.GetUser(user.Id);

            if (loginUser is null)
            {
                return false;
            }

            loginUser.EventId = null;

            return await _repository.ExitEvent(loginUser);
        }

        public async Task<bool> AddEventTimeUser(EventTimeUser eventTimeUser)
        {
            return await _repository.AddEventTimeUser(eventTimeUser);
        }
    }
}
