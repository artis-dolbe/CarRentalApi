namespace CarRentalApi.DTOs;

public record CreateReservationDto(int CarId, int CustomerId, DateTime StartDate, DateTime EndDate);
