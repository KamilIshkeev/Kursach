using Kursach.Models;

namespace Kursach.Interfaces
{
    public interface IListAchiev
    {
            IEnumerable<ListAchiev> GetAllListAchievs();
            ListAchiev GetListAchievById(int id);
            ListAchiev GetListAchievByUserId(int user_id);
            ListAchiev AddListAchiev(ListAchiev ListAchiev);
            ListAchiev UpdateListAchiev(int id, ListAchiev updatedListAchiev);
            void DeleteListAchiev(int id);

        
    }
}
