using HotelComplex.DataAccess.Shared.Abstractions.Models;

namespace HotelComplex.DataAccess.Abstractions.Models;

public class Accommodation: BaseEntity
{
    public int RoomNumber { get; set; }

    public DateTime CheckInDate { get; set; }

    public DateTime CheckInOut { get; set; }

    public long ClientId { get; set; }

    public Client Client { get; set; }
}