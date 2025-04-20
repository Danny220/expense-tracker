using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.API.Controllers;

[Route("api/[controller]")]
public class ExpenseTrackerController : Controller
{
    #region GET
    [HttpGet("ping")]
    public IActionResult Ping()
    {
        return Ok("pong");
    }

    [HttpGet("expenses")]
    public IActionResult GetExpenses()
    {
        throw new NotImplementedException();
    }
    #endregion GET

    #region POST

    [HttpPost("expenses")]
    public IActionResult PostExpenses()
    {
        throw new NotImplementedException();
    }
    #endregion
    
    #region PUT

    [HttpPut("expenses")]
    public IActionResult PutExpenses()
    {
        throw new NotImplementedException();
    }
    #endregion
    
    #region DELETE
    [HttpDelete("expenses")]
    public IActionResult DeleteExpenses()
    {
        throw new NotImplementedException();
    }
    #endregion
}