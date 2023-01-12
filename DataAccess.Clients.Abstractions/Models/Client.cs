using HotelComplex.DataAccess.Shared.Abstractions.Models;

namespace HotelComplex.DataAccess.Abstractions.Models;

public class Client : BaseEntity
{
    public string Name { get; set; }

    public string Email { get; set; }

    public string Surname { get; set; }

    public string MiddleName { get; set; }

    public DateTime DateOfBirth { get; set; }

    public List<Accommodation> Accommodations { get; set; }
}