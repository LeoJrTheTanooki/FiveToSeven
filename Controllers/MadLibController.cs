using FiveToSeven.Services.MadLib;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers;
[ApiController]
[Route("api/[controller]")]
public class MadLibController : ControllerBase
{
    private readonly IMadLibService _madLib;

    public MadLibController(IMadLibService madLib)
    {
        _madLib = madLib;
    }
    [HttpGet]

    [Route("/MadLibPrompts/name1={name1}+name2={name2}+show={show}+movie={movie}+game={game}+time={timeOfDay}")]
    public string MadLib(string name1, string name2, string show, string movie, string game, string timeOfDay)
    {
        return _madLib.MadLib(name1, name2, show, movie, game, timeOfDay);
    }
}