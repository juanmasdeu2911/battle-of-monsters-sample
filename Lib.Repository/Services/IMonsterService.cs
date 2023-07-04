using Lib.Repository.Entities;

namespace Lib.Repository.Services
{
    public interface IMonsterService
    {
        Monster Add(Monster monster);
        Monster Update(int id, Monster monster);
        void Delete(int id);
        Task<Monster> Find(int id);
    }
}
