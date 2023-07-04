using Lib.Repository.Entities;

namespace Lib.Repository.Services
{
    public interface IBattleService
    {
        Task<Battle> AddAsync(Battle battle);
        Battle Update(int id, Monster monster);
        void Remove(int id);
        Task<Battle> FindAsync(int id);
        Task<IEnumerable<Battle>> GetAllAsync();
        Battle PerformBattle(int id);
    }
}
