using Microsoft.AspNetCore.Mvc;
using CarRentalApi.Data;
using CarRentalApi.DTOs;

namespace CarRentalApi.Controllers;

[Route("api/reservations")]
[ApiController]
public class ReservationController : ControllerBase
{
    private readonly CarRentalDbContext _db;

    public ReservationController(CarRentalDbContext db)
    {
        _db = db;
    }

    [HttpPost("create")]
    public IActionResult CreateReservation([FromBody] CreateReservationDto dto)
    {
        var car = _db.Cars.Find(dto.CarId);
        var customer = _db.Customers.Find(dto.CustomerId);

        if (car == null) return NotFound($"Car with ID {dto.CarId} not found.");
        if (customer == null) return NotFound($"Customer with ID {dto.CustomerId} not found.");

        var reservation = new Reservation
        {
            CarId = dto.CarId,
            CustomerId = dto.CustomerId,
            StartDate = dto.StartDate,
            EndDate = dto.EndDate
        };

        _db.Reservations.Add(reservation);
        _db.SaveChanges();
        return CreatedAtAction(nameof(GetReservationById), new { id = reservation.Id }, reservation);
    }

    [HttpGet("{id}")]
    public IActionResult GetReservationById(int id)
    {
        var reservation = _db.Reservations.Find(id);
        return reservation == null ? NotFound() : Ok(reservation);
    }

    [HttpGet]
    public IActionResult GetAllReservations()
    {
        return Ok(_db.Reservations.ToList());
    }
}
