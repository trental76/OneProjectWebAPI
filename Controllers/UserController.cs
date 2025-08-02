using OneProjectWebAPI.BL.Models;
using OneProjectWebAPI.BL.Models.Clients.Request;
using OneProjectWebAPI.BL.Models.Clients.Requests;
using OneProjectWebAPI.BL.Services;
using Microsoft.AspNetCore.Mvc;

namespace OneProjectWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{

    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }

    [HttpGet("list")]
    public IEnumerable<List<object>> Get()
    {
        return new List<List<object>>();
    }
}
