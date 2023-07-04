using Lib.Repository.Entities;
using Lib.Repository.Repository;
using System.Threading.Tasks;

namespace Lib.Repository.Services;

public class BattleService : IBattleService
{
    private readonly IBattleOfMonstersRepository repository;

    public BattleService(IBattleOfMonstersRepository repository)
    {
        this.repository = repository;
    }

    public async Task<Battle> AddAsync(Battle battle)
    {
        throw new NotImplementedException();
    }

    public void Remove(int id)
    {
        throw new NotImplementedException();
    }

    public Battle Update(int id, Monster monster)
    {
        throw new NotImplementedException();
    }

    public async Task<Battle> FindAsync(int id)
    {
        var repoQuery = await repository.Battles.FindAsync(id);

        if (repoQuery != null)
        {
            return repoQuery;
        }

        throw new ApplicationException($"Battle {id} not found.");
    }

    public Battle PerformBattle(int id)
    {
        throw new NotImplementedException();
    }

    private Monster GetFirstAttacker(Monster monsterA, Monster monsterB)
    {
        throw new NotImplementedException();
    }

    private Monster AttackMonster(Monster attacker, Monster deffender)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Battle>> GetAllAsync()
    {
        return await repository.Battles.GetAllAsync();
    }
}