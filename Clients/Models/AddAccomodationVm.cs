namespace HotelComplex.Clients.Models;

public class AddAccomodationVm
{
    public int RoomNumber { get; set; }

    public DateTime CheckInDate { get; set; }

    public DateTime CheckInOut { get; set; }

    public long ClientId { get; set; }
}