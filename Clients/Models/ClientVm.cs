namespace HotelComplex.Clients.Models;

public class ClientVm
{
    public long Id { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string Surname { get; set; }

    public string MiddleName { get; set; }

    public DateTime DateOfBirth { get; set; }
}