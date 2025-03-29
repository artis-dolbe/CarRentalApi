using Microsoft.AspNetCore.Mvc;
using CarRentalApi.Data;
using CarRentalApi.DTOs;

namespace CarRentalApi.Controllers;

[Route("api/cars")]
[ApiController]
public class CarController : ControllerBase
{
    private readonly CarRentalDbContext _db;

    public CarController(CarRentalDbContext db)
    {
        _db = db;
    }

    [HttpPost("register")]
    public IActionResult RegisterCar(RegisterCarDto dto)
    {
        var car = new Car { Brand = dto.Brand, Model = dto.Model, Year = dto.Year };
        _db.Cars.Add(car);
        _db.SaveChanges();
        return CreatedAtAction(nameof(GetCarById), new { id = car.Id }, car);
    }

    [HttpGet]
    public IActionResult GetAllCars()
    {
        return Ok(_db.Cars.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult GetCarById(int id)
    {
        var car = _db.Cars.Find(id);
        return car == null ? NotFound() : Ok(car);
    }
}
