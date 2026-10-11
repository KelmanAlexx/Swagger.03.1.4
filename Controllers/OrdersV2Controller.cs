using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersioningLab.AlexxKelman.Controllers;

[ApiController]
[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/orders")]
public class OrdersV2Controller : ControllerBase
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
                price = 3500,
                currency = "RUB",
                inStock = true,
                versionDescription = "Расширенная версия API"
            },
            new
            {
                id = 2,
                title = "Компьютерная мышь",
                price = 1500,
                currency = "RUB",
                inStock = true,
                versionDescription = "Расширенная версия API"
            },
            new
            {
                id = 3,
                title = "Наушники",
                price = 4200,
                currency = "RUB",
                inStock = false,
                versionDescription = "Расширенная версия API"
            }
        };

        return Ok(orders);
    }
}