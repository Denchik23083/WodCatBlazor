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
        public void GetAllEventsUsers()
        {
            var context = new TestsWodCatCloneContext();
            var id = 2;
            var expectedUser = 0;

            var getEvent = context.Halls.FirstOrDefault(b => b.Id == id);
            Assert.NotNull(getEvent);
            Assert.Equal(id, getEvent.Id);

            var users = context.Users.Where(b => b.EventId == id);
            Assert.NotNull(users);

            Assert.Equal(expectedUser, users.Count());
        }

        [Fact]
        public void GetEventTest()
        {
            var context = new TestsWodCatCloneContext();
            var id = 1;

            var getEvent = context.Events.FirstOrDefault(b => b.Id == id);
            Assert.NotNull(getEvent);

            Assert.Equal(id, getEvent.Id);
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
    }
}
