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
    public string ReverseItB(string num)
    {
        return _reverseItNum.ReverseItB(num);
    }

}
