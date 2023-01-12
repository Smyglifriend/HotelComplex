namespace HotelComplex.CQRS.Abstractions.Models;

public class AccommodationDto
{
    public long Id { get; set; }

    public int RoomNumber { get; set; }

    public DateTime CheckInDate { get; set; }

    public DateTime CheckInOut { get; set; }

    public long ClientId { get; set; }
}