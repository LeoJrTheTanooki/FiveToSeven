using FiveToSeven.Services.ReverseItNum;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReverseItNumController : ControllerBase
{
    private readonly IReverseItNumService _reverseItNum;

    public ReverseItNumController(IReverseItNumService reverseItNum)
    {
        _reverseItNum = reverseItNum;
    }
    [HttpGet]
    [Route("/ReverseNumber/{num}")]
    public int ReverseItB(int num)
    {
        return _reverseItNum.ReverseItB(num);
    }

}
