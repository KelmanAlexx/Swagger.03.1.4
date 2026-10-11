using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningLab.AlexxKelman.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/orders")]
public class OrdersV1Controller : ControllerBase
{
    [HttpGet]
    public IActionResult GetOrders()
    {
        var orders = new[]
        {
            new
            {
                id = 1,
                title = "Клавиатура",
                price = 3500
            },
            new
            {
                id = 2,
                title = "Компьютерная мышь",
                price = 1500
            },
            new
            {
                id = 3,
                title = "Наушники",
                price = 4200
            }
        };

        return Ok(orders);
    }
}