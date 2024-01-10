using FiveToSeven.Services.OddOrEven;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OddOrEvenController : ControllerBase
{
    private readonly IOddOrEvenService _oddOrEven;

    public OddOrEvenController(IOddOrEvenService oddOrEven)
    {
        _oddOrEven = oddOrEven;
    }
    [HttpGet]
    [Route("/OddOrEvenChecker/number={num}")]
    public string OddOrEven(int num)
    {
        return _oddOrEven.OddOrEven(num);
    }

}
