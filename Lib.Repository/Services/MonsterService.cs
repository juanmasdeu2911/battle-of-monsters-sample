using Lib.Repository.Entities;
using Lib.Repository.Repository;

namespace Lib.Repository.Services
{
    public class MonsterService : IMonsterService
    {

        private readonly IBattleOfMonstersRepository _repository;

        public MonsterService(IBattleOfMonstersRepository repository)
        {
            _repository = repository;
        }

        public Monster Add(Monster monster)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Monster> Find(int id)
        {
            throw new NotImplementedException();
        }

        public Monster Update(int id, Monster monster)
        {
            throw new NotImplementedException();
        }
    }
}
