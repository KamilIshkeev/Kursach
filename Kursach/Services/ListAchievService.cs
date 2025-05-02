using Kursach.DataBaseContext;
using Kursach.Interfaces;
using Kursach.Models;

namespace Kursach.Services
{
    public class ListAchievService : IListAchiev
    {
        private readonly KursachDbContext _context;

        public ListAchievService(KursachDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ListAchiev> GetAllListAchievs()
        {
            return _context.ListAchiev.ToList();
        }

        public ListAchiev GetListAchievById(int id)
        {
            return _context.ListAchiev.FirstOrDefault(m => m.Id == id);
        }

        public ListAchiev GetListAchievByUserId(int user_id)
        {
            return _context.ListAchiev.FirstOrDefault(m => m.User_Id == user_id);
        }


        public ListAchiev AddListAchiev(ListAchiev ListAchiev)
        {
            _context.ListAchiev.Add(ListAchiev);
            _context.SaveChanges();
            return ListAchiev;
        }

        public ListAchiev UpdateListAchiev(int id, ListAchiev updatedListAchiev)
        {
            var ListAchiev = _context.ListAchiev.FirstOrDefault(m => m.Id == id);
            if (ListAchiev == null) return null;

            ListAchiev.Achiev_Id = updatedListAchiev.Achiev_Id;
            _context.SaveChanges();
            return ListAchiev;
        }

        public void DeleteListAchiev(int id)
        {
            var ListAchiev = _context.ListAchiev.FirstOrDefault(m => m.Id == id);
            if (ListAchiev != null)
            {
                _context.ListAchiev.Remove(ListAchiev);
                _context.SaveChanges();
            }
        }
    }
}
