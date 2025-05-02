using Kursach.DataBaseContext;
using Kursach.Interfaces;
using Kursach.Models;

namespace Kursach.Services
{
    public class AchievService : IAchiev
    {
        private readonly KursachDbContext _context;

        public AchievService(KursachDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Achiev> GetAllAchievs()
        {
            return _context.Achiev.ToList();
        }

        public Achiev GetAchievById(int id)
        {
            return _context.Achiev.FirstOrDefault(m => m.Id == id);
        }

        public Achiev GetAchievByTitle(string title)
        {
            return _context.Achiev.FirstOrDefault(m => m.Name == title);
        }


        public Achiev AddAchiev(Achiev Achiev)
        {
            _context.Achiev.Add(Achiev);
            _context.SaveChanges();
            return Achiev;
        }

        public Achiev UpdateAchiev(int id, Achiev updatedAchiev)
        {
            var Achiev = _context.Achiev.FirstOrDefault(m => m.Id == id);
            if (Achiev == null) return null;

            Achiev.Name = updatedAchiev.Name;
            _context.SaveChanges();
            return Achiev;
        }

        public void DeleteAchiev(int id)
        {
            var Achiev = _context.Achiev.FirstOrDefault(m => m.Id == id);
            if (Achiev != null)
            {
                _context.Achiev.Remove(Achiev);
                _context.SaveChanges();
            }
        }
    }
}
