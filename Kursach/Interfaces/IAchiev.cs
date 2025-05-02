using Kursach.Models;

namespace Kursach.Interfaces
{
    public interface IAchiev
    {
            IEnumerable<Achiev> GetAllAchievs();
            Achiev GetAchievById(int id);
            Achiev GetAchievByTitle(string title);
            Achiev AddAchiev(Achiev Achiev);
            Achiev UpdateAchiev(int id, Achiev updatedAchiev);
            void DeleteAchiev(int id);
        
    }
}
