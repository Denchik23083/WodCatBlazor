using System.Collections.Generic;
using System.Linq;
using WodCatClone.Db;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.WebDb.ActionsRepository.HallsRepository
{
    public class HallsRepository : IHallsRepository
    {
        private readonly WodCatCloneContext _context;

        public HallsRepository(WodCatCloneContext context)
        {
            _context = context;
        }

        public IEnumerable<Halls> GetAllHalls()
        {
            return _context.Halls;
        }

        public IEnumerable<HallEmblem> GetAllHallEmblem()
        {
            return _context.HallEmblem;
        }

        public HallEmblem GetImage(int imageId)
        {
            return _context.HallEmblem.FirstOrDefault(b => b.Id == imageId);
        }
    }
}
