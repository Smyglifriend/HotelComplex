using HotelComplex.DataAccess.Shared.Abstractions.Models;

namespace DataAccess.Hotel.Abstractions.Models;

public class Room : BaseEntity
{
    public int Number { get; set; }

    public int Floor { get; set; }

    public int NumberOfRooms { get; set; }

    public int  NumberOfSleepingPlace { get; set; }

    public bool IsBlocked { get; set; }
}