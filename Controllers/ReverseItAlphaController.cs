using FiveToSeven.Services.ReverseItAlpha;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReverseItAlphaController : ControllerBase
{
    private readonly IReverseItAlphaService _reverseItAlpha;

    public ReverseItAlphaController(IReverseItAlphaService reverseItAlpha)
    {
        _reverseItAlpha = reverseItAlpha;
    }
    [HttpGet]
    [Route("/ReverseAlphabet/{word}")]
    public string ReverseItA(string word)
    {
        return _reverseItAlpha.ReverseItA(word);
    }

}
