using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize]
public class EmployeeController : ControllerBase
{
    private static readonly string[] Names = new[]
    {
        "Sawyer", "Juliet", "Hurley", "Claire", "Desmond", "Penelope", "Jack", "Kate", "John"
    };

    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Employee> Get()
    {
        return Enumerable.Range(0, 8).Select(index => new Employee
        {
            Age = 18,
            Gender = index % 2 == 0 ? "male" : "female",
            Name = Names[index]
        })
        .ToArray();
    }
}
