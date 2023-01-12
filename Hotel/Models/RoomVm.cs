namespace HotelComplex.Hotel.Models;

public class RoomVm
{
    public long Id { get; set; }

    public int Number { get; set; }

    public int Floor { get; set; }

    public int NumberOfRooms { get; set; }

    public int  NumberOfSleepingPlace { get; set; }

    public bool IsBlocked { get; set; }
}