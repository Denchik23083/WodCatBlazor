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

        public async Task<IEnumerable<Events>> GetAllEventsAsync()
        {
            return await _repository.GetAllEventsAsync();
        }

        public async Task<IEnumerable<Events>> GetAllEndEventsAsync()
        {
            return await _repository.GetAllEndEventsAsync();
        }

        public async Task<IEnumerable<EventEmblem>> GetAllEventEmblemAsync()
        {
            return await _repository.GetAllEventEmblemAsync();
        }

        public async Task<Events?> GetEventAsync(int eventId)
        {
            return await _repository.GetEventAsync(eventId);
        }

        public async Task<bool> AddEventAsync(Events @event)
        {
            var user = AuthService.AuthService.User;
            var loginUser = await _userRepository.GetUserAsync(user!.Id);

            if (loginUser is null)
            {
                return false;
            }

            @event.UserId = loginUser.Id;

            loginUser.Points += 100;

            return await _repository.AddEventAsync(@event, loginUser);
        }

        public async Task<bool> EditEventAsync(Events @event, int eventId)
        {
            var user = AuthService.AuthService.User;
            var loginUser = await _userRepository.GetUserAsync(user!.Id);

            if (loginUser is null)
            {
                return false;
            }

            var eventToEdit = await _repository.GetEventAsync(eventId);

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

            return await _repository.EditEventAsync(eventToEdit, loginUser);
        }

        public async Task<bool> RemoveEventAsync(int eventId)
        {
            var eventToRemove = await _repository.GetEventAsync(eventId);

            if (eventToRemove is null)
            {
                return false;
            }

            return await _repository.RemoveEventAsync(eventToRemove);
        }

        public async Task<bool> AutoRemoveEventAsync(Events eventToRemove)
        {
            var allUsersTime = eventToRemove.EventTimeUsers?
                .OrderByDescending(b => b.Time)
                .Take(3)
                .Reverse();

            var usersToList = allUsersTime?.Select(item => item.User).ToList();

            return await _repository.AutoRemoveEventAsync(usersToList, eventToRemove);
        }

        public async Task<bool> JoinEventAsync(int eventId, User user)
        {
            var loginUser = await _userRepository.GetUserAsync(user.Id);

            if (loginUser is null)
            {
                return false;
            }

            loginUser.EventId = eventId;

            return await _repository.JoinEventAsync(loginUser);
        }

        public async Task<bool> ExitEventAsync(int eventId, User user)
        {
            var loginUser = await _userRepository.GetUserAsync(user.Id);

            if (loginUser is null)
            {
                return false;
            }

            loginUser.EventId = null;

            return await _repository.ExitEventAsync(loginUser);
        }

        public async Task<bool> AddEventTimeUserAsync(EventTimeUser eventTimeUser)
        {
            return await _repository.AddEventTimeUserAsync(eventTimeUser);
        }
    }
}
