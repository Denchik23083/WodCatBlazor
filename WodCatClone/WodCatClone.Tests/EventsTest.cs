using System.Linq;
using WodCatClone.Db;
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
            var id = 2;
            var expectedUser = 0;

            var @event = context.Halls.FirstOrDefault(b => b.Id == id);
            Assert.NotNull(@event);
            Assert.Equal(id, @event.Id);

            var users = context.Users.Where(b => b.EventId == id);
            Assert.NotNull(users);

            Assert.Equal(expectedUser, users.Count());
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
        public void GetEventTimeUser()
        {
            var context = new TestsWodCatCloneContext();
            var eventId = 1;
            var userId = 1;
            
            var eventTimeUser = context.EventTimeUser.FirstOrDefault(b => b.EventsId == eventId && b.UserId == userId);
            Assert.NotNull(eventTimeUser);

            Assert.Equal(eventId, eventTimeUser.EventsId);
            Assert.Equal(userId, eventTimeUser.UserId);
        }
    }
}
