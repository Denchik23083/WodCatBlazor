using System;
using System.Linq;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Actions;
using WodCatClone.Db.Entities.Auth;
using Xunit;

namespace WodCatClone.Tests
{
    public class EventsTest
    {
        [Fact]
        public void GetAllEventsTest()
        {
            var context = new TestsWodCatCloneContext();
            var expected = 1;

            var events = context.Events;
            Assert.NotNull(events);

            Assert.Equal(expected, events.Count());
        }

        [Fact]
        public void GetAllEventsUsersTest()
        {
            var context = new TestsWodCatCloneContext();
            var id = 1;
            var expectedUser = 0;

            var @event = context.Events.FirstOrDefault(b => b.Id == id);
            Assert.NotNull(@event);
            Assert.Equal(id, @event.Id);

            var users = context.Users.Where(b => b.EventId == id);
            Assert.NotNull(users);

            Assert.Equal(expectedUser, users.Count());
        }

        [Fact]
        public void GetAllEventTimeUsersTest()
        {
            var context = new TestsWodCatCloneContext();
            var id = 1;
            var expected = 1;

            var eventTimeUser = context.EventTimeUser.Where(b => b.Id == id);
            Assert.NotNull(eventTimeUser);

            Assert.Equal(expected, eventTimeUser.Count());
        }
        
        [Fact]
        public void GetAllEventsEmblemTest()
        {
            var context = new TestsWodCatCloneContext();
            var expectedEventEmblem = 5;

            var eventEmblem = context.EventEmblem;
            Assert.NotNull(eventEmblem);

            Assert.Equal(expectedEventEmblem, eventEmblem.Count());
        }

        [Fact]
        public void GetEventTest()
        {
            var context = new TestsWodCatCloneContext();
            var id = 1;

            var @event = context.Events.FirstOrDefault(b => b.Id == id);
            Assert.NotNull(@event);

            Assert.Equal(id, @event.Id);
        }

        [Fact]
        public void GetImageTest()
        {
            var context = new TestsWodCatCloneContext();
            var id = 3;
            var image = "img/EmblemEvents/lime.jpg";

            var eventEmblem = context.EventEmblem.FirstOrDefault(b => b.Id == id);
            Assert.NotNull(eventEmblem);

            Assert.Equal(id, eventEmblem.Id);
            Assert.Equal(image, eventEmblem.Image);
        }

        [Fact]
        public void GetEventTimeUserTest()
        {
            var context = new TestsWodCatCloneContext();
            var eventId = 1;
            var userId = 1;
            
            var eventTimeUser = context.EventTimeUser.FirstOrDefault(b => b.EventsId == eventId && b.UserId == userId);
            Assert.NotNull(eventTimeUser);

            Assert.Equal(eventId, eventTimeUser.EventsId);
            Assert.Equal(userId, eventTimeUser.UserId);
        }

        [Fact]
        public void AddEventTimeUserTest()
        {
            var context = new TestsWodCatCloneContext();

            var user = HelperUserLogin(context);
            Assert.NotNull(user);

            var newEvent = new Events
            {
                Name = "TestName",
                TypeEvent = "TestTypeEvent",
                TypeSport = "TestTypeSport",
                Description = "TestDescription",
                Town = "Запорожье",
                Location = "улица Лобановского, 21",
                RegisterDate = new DateTime(2022, 06, 27, 10, 00, 00),
                StartDate = new DateTime(2022, 06, 26, 12, 30, 00),
                EndDate = new DateTime(2022, 06, 26, 15, 00, 00),
                HallId = 4,
                EventsEmblemId = 3,
                UserId = 1,
                WorkoutId = 2
            };

            context.Events.Add(newEvent);
            context.SaveChanges();

            var getNewEvent = context.Events.FirstOrDefault(b => b.Name == newEvent.Name
            && b.TypeEvent == newEvent.TypeEvent && b.TypeSport == newEvent.TypeSport);
            Assert.NotNull(getNewEvent);

            Assert.Equal(getNewEvent.UserId, user.Id);

            var eventTimeUser = new EventTimeUser
            {
                Time = new TimeSpan(01, 23, 30),
                EventsId = getNewEvent.Id,
                UserId = user.Id
            };

            context.EventTimeUser.Add(eventTimeUser);
            context.SaveChanges();

            var getEventTimeUser = context.EventTimeUser.FirstOrDefault(b => b.Time == eventTimeUser.Time
            && b.EventsId == eventTimeUser.EventsId && b.UserId == eventTimeUser.UserId);
            Assert.NotNull(getEventTimeUser);

            context.EventTimeUser.Remove(getEventTimeUser);
            context.SaveChanges();

            var eventTimeUserAfterRemove = context.EventTimeUser.FirstOrDefault(b => b.Time == eventTimeUser.Time
            && b.EventsId == eventTimeUser.EventsId && b.UserId == eventTimeUser.UserId);
            Assert.Null(eventTimeUserAfterRemove);

            context.Events.Remove(getNewEvent);
            context.SaveChanges();

            var getEventAfterRemove = context.Events.FirstOrDefault(b => b.Name == newEvent.Name
            && b.TypeEvent == newEvent.TypeEvent && b.TypeSport == newEvent.TypeSport);
            Assert.Null(getEventAfterRemove);
        }

        [Fact]
        public void AddEventTest()
        {
            var context = new TestsWodCatCloneContext();

            var user = HelperUserLogin(context);
            var userPoint = user.Points;
            Assert.NotNull(user);

            var newEvent = new Events
            {
                Name = "TestName",
                TypeEvent = "TestTypeEvent",
                TypeSport = "TestTypeSport",
                Description = "TestDescription",
                Town = "Запорожье",
                Location = "улица Лобановского, 21",
                RegisterDate = new DateTime(2022, 06, 27, 10, 00, 00),
                StartDate = new DateTime(2022, 06, 26, 12, 30, 00),
                EndDate = new DateTime(2022, 06, 26, 15, 00, 00),
                HallId = 4,
                EventsEmblemId = 3,
                UserId = 1,
                WorkoutId = 2
            };

            context.Events.Add(newEvent);
            context.SaveChanges();

            var getNewEvent = context.Events.FirstOrDefault(b => b.Name == newEvent.Name 
            && b.TypeEvent == newEvent.TypeEvent && b.TypeSport == newEvent.TypeSport);
            Assert.NotNull(getNewEvent);

            Assert.Equal(getNewEvent.UserId, user.Id);

            context.Events.Remove(getNewEvent);
            context.SaveChanges();

            var getEventAfterRemove = context.Events.FirstOrDefault(b => b.Name == newEvent.Name
            && b.TypeEvent == newEvent.TypeEvent && b.TypeSport == newEvent.TypeSport);
            Assert.Null(getEventAfterRemove);

            userPoint += 100;
            user.Points += 100;
            context.SaveChanges();

            Assert.Equal(userPoint, user.Points);
        }

        [Fact]
        public void EditEventTest()
        {
            var context = new TestsWodCatCloneContext();

            var user = HelperUserLogin(context);
            var userPoint = user.Points;
            Assert.NotNull(user);

            var newEvent = new Events
            {
                Name = "TestName",
                TypeEvent = "TestTypeEvent",
                TypeSport = "TestTypeSport",
                Description = "TestDescription",
                Town = "Запорожье",
                Location = "улица Лобановского, 21",
                RegisterDate = new DateTime(2022, 06, 27, 10, 00, 00),
                StartDate = new DateTime(2022, 06, 26, 12, 30, 00),
                EndDate = new DateTime(2022, 06, 26, 15, 00, 00),
                HallId = 4,
                EventsEmblemId = 3,
                UserId = 1,
                WorkoutId = 2
            };

            var eventToUpdate = new Events
            {
                Name = "TestUpdateName",
                TypeEvent = "TestTypeUpdateEvent",
                TypeSport = "TestTypeUpdateSport",
                Description = "TestUpdateDescription",
                Town = "Запорожье",
                Location = "улица Лобановского, 21",
                RegisterDate = new DateTime(2022, 06, 27, 10, 00, 00),
                StartDate = new DateTime(2022, 06, 26, 12, 30, 00),
                EndDate = new DateTime(2022, 06, 26, 15, 00, 00),
                HallId = 4,
                EventsEmblemId = 3,
                UserId = 1,
                WorkoutId = 2
            };

            context.Events.Add(newEvent);
            context.SaveChanges();

            var getNewEvent = context.Events.FirstOrDefault(b => b.Name == newEvent.Name
            && b.TypeEvent == newEvent.TypeEvent && b.TypeSport == newEvent.TypeSport);
            Assert.NotNull(getNewEvent);

            Assert.Equal(getNewEvent.UserId, user.Id);

            getNewEvent.Name = eventToUpdate.Name;
            getNewEvent.TypeEvent = eventToUpdate.TypeEvent;
            getNewEvent.TypeSport = eventToUpdate.TypeSport;
            getNewEvent.Description = eventToUpdate.Description;
            getNewEvent.Town = eventToUpdate.Town;
            getNewEvent.Location = eventToUpdate.Location;
            getNewEvent.RegisterDate = eventToUpdate.RegisterDate;
            getNewEvent.StartDate = eventToUpdate.StartDate;
            getNewEvent.EndDate = eventToUpdate.EndDate;
            getNewEvent.HallId = eventToUpdate.HallId;
            getNewEvent.EventsEmblemId = eventToUpdate.EventsEmblemId;
            getNewEvent.WorkoutId = eventToUpdate.WorkoutId;

            context.SaveChanges();

            var getEventAfterUpdate = context.Events.FirstOrDefault(b => b.Name == newEvent.Name
            && b.TypeEvent == newEvent.TypeEvent && b.TypeSport == newEvent.TypeSport);
            Assert.NotNull(getEventAfterUpdate);

            Assert.Equal(getEventAfterUpdate.UserId, user.Id);

            context.Events.Remove(getEventAfterUpdate);
            context.SaveChanges();

            var getEventAfterRemove = context.Events.FirstOrDefault(b => b.Name == newEvent.Name
            && b.TypeEvent == newEvent.TypeEvent && b.TypeSport == newEvent.TypeSport);
            Assert.Null(getEventAfterRemove);

            userPoint += 50;
            user.Points += 50;
            context.SaveChanges();

            Assert.Equal(userPoint, user.Points);
        }

        [Fact]
        public void RemoveEventTest()
        {
            var context = new TestsWodCatCloneContext();

            var user = HelperUserLogin(context);
            Assert.NotNull(user);

            var newEvent = new Events
            {
                Name = "TestName",
                TypeEvent = "TestTypeEvent",
                TypeSport = "TestTypeSport",
                Description = "TestDescription",
                Town = "Запорожье",
                Location = "улица Лобановского, 21",
                RegisterDate = new DateTime(2022, 06, 27, 10, 00, 00),
                StartDate = new DateTime(2022, 06, 26, 12, 30, 00),
                EndDate = new DateTime(2022, 06, 26, 15, 00, 00),
                HallId = 4,
                EventsEmblemId = 3,
                UserId = 1,
                WorkoutId = 2
            };

            context.Events.Add(newEvent);
            context.SaveChanges();

            var getNewEvent = context.Events.FirstOrDefault(b => b.Name == newEvent.Name
            && b.TypeEvent == newEvent.TypeEvent && b.TypeSport == newEvent.TypeSport);
            Assert.NotNull(getNewEvent);

            Assert.Equal(getNewEvent.UserId, user.Id);

            context.Events.Remove(getNewEvent);
            context.SaveChanges();

            var getEventAfterRemove = context.Events.FirstOrDefault(b => b.Name == newEvent.Name
            && b.TypeEvent == newEvent.TypeEvent && b.TypeSport == newEvent.TypeSport);
            Assert.Null(getEventAfterRemove);
        }

        [Fact]
        public void JoinTest()
        {
            var context = new TestsWodCatCloneContext();

            var newUser = new User
            {
                Name = "Michael",
                Surname = "de Santa",
                Birthday = new DateTime(2013, 09, 17),
                NickName = "GTA5",
                Country = "Ukraine",
                Email = "foo15@gmail.com",
                Password = "0000",
                GenderId = 1,
            };

            context.Users.Add(newUser);
            context.SaveChanges();

            var testUserEdit = context.Users.FirstOrDefault(l => l.Email == newUser.Email &&
                                                                 l.Password == newUser.Password);
            Assert.NotNull(testUserEdit);

            var newEventId = 1;
            testUserEdit.EventId = newEventId;

            context.SaveChanges();

            var testUserAfterEdit = context.Users.FirstOrDefault(l => l.Email == testUserEdit.Email &&
                                                                      l.Password == testUserEdit.Password);
            Assert.NotNull(testUserAfterEdit);

            Assert.Equal(newEventId, testUserAfterEdit.EventId);

            context.Users.Remove(testUserAfterEdit);
            context.SaveChanges();

            var testUserAfterRemove = context.Users.FirstOrDefault(l => l.Email == testUserEdit.Email &&
                                                                        l.Password == testUserEdit.Password);
            Assert.Null(testUserAfterRemove);
        }

        [Fact]
        public void ExitTest()
        {
            var context = new TestsWodCatCloneContext();

            var newUser = new User
            {
                Name = "Michael2",
                Surname = "de Santa",
                Birthday = new DateTime(2013, 09, 17),
                NickName = "GTA5",
                Country = "Ukraine",
                Email = "foo16@gmail.com",
                Password = "0000",
                GenderId = 1,
            };

            context.Users.Add(newUser);
            context.SaveChanges();

            var testUserEdit = context.Users.FirstOrDefault(l => l.Email == newUser.Email &&
                                                                 l.Password == newUser.Password);
            Assert.NotNull(testUserEdit);

            testUserEdit.EventId = null;

            context.SaveChanges();

            var testUserAfterEdit = context.Users.FirstOrDefault(l => l.Email == testUserEdit.Email &&
                                                                      l.Password == testUserEdit.Password);
            Assert.NotNull(testUserAfterEdit);

            Assert.Null(testUserAfterEdit.EventId);

            context.Users.Remove(testUserAfterEdit);
            context.SaveChanges();

            var testUserAfterRemove = context.Users.FirstOrDefault(l => l.Email == testUserAfterEdit.Email &&
                                                                        l.Password == testUserAfterEdit.Password);
            Assert.Null(testUserAfterRemove);
        }

        private User HelperUserLogin(TestsWodCatCloneContext context)
        {
            var login = new Login
            {
                Email = "deniskudravov228@gmail.com",
                Password = "0000"
            };

            var user = context.Users.FirstOrDefault(l => l.Email == login.Email &&
                                                         l.Password == login.Password);

            return user;
        }
    }
}
