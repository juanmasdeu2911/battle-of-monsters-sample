using Lib.Repository.Entities;
using Lib.Repository.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;


public class BattleController : BaseApiController
{
    private readonly IBattleService _service;

    public BattleController(IBattleService battleService)
    {
        _service = battleService;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult> GetAll()
    {
        IEnumerable<Battle> battles = await _service.GetAllAsync();
        return Ok(battles);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> Add([FromBody] Battle battle)
    {
        try
        {
            if (battle == null)
            {
                return BadRequest("Body cannot be null");
            }

            var createdBattle = await _service.AddAsync(battle);
            return Ok(createdBattle);
        }
        catch(ApplicationException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id:int}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult> Remove(int id)
    {
        //await _repository.Battles.RemoveAsync(id);
        //await _repository.Save();
        return Ok();
    }
}


