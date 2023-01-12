using HotelComplex.DataAccess.Shared.Abstractions.Interfaces;

namespace HotelComplex.DataAccess.Shared.Abstractions.Models;

public abstract class BaseEntity: IEntity
{
    public long Id { get; set; }
}