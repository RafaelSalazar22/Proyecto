using System;
namespace Domain.dto
{
    public record ClubsFilterDto(string NombreClub, string Direccion,  string TelefonoContacto, double Geoubicacion);
}