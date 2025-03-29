namespace CarRentalApi.Data;
public class Car
{
    public int Id { get; set; }
    public string Brand { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public bool IsAvailable { get; set; } = true;
    public int Year { get; set; } 
}
