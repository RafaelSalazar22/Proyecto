using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.IO;
using Infrastructure;
using Finding_a_Tournament.Domain.Entities;
using System.Threading.Tasks;
namespace Infrastructure.RepositoryClubs
{
    public class RepositoryClubs
    {

         private readonly Finding_a_TournamentContext _Clubs;

        public RepositoryClubs()
        {

            _Clubs = new Finding_a_TournamentContext();

        }

     /// Escribe un método en el cual se retorne la información de todas las personas.
        public IEnumerable<Club> GetAll()
        {
            var query = _Clubs.Clubs.Select(Clubs => Clubs);
            return query;
        }
          public IEnumerable<Object> GetFields()
        {
            var query = _Clubs.Clubs.Select(clubs => new {
                Nombreclubs = $"{clubs.NombreClub}",
                telefono = (clubs.TelefonoContacto),
                direccion = clubs.Direccion
            });
            return query;
        }
        public Club GetById2(int Id_Club)
        {
            var id_Club = Id_Club;///generador.Next(1,1001);
            
            var query = _Clubs.Clubs.Single(C=>C.IdClub == id_Club );
            return query;
        }
        public IEnumerable<Object> Telefono()
        {
            var query = _Clubs.Clubs.Select(clubs => new {
                Nombre=(clubs.NombreClub),
                telefono = (clubs.TelefonoContacto)
            });
            return query;
        }
        /*public IEnumerable<Club> GetByFilter(Club club)
        {
            var query = _Clubs.Clubs.Select(c=>c);

            if (!string.IsNullOrEmpty(club.NombreClub))
                query=query.Where(c=>c.NombreClub.Contains(club.NombreClub));

            if (!string.IsNullOrEmpty(club.Direccion))
                query=query.Where(c=>c.Direccion==club.Direccion);

            if (!string.IsNullOrEmpty(club.TelefonoContacto))
                query=query.Where(c=>c.TelefonoContacto==club.TelefonoContacto);

            if (club.Geoubicacion > 0)
                query=query.Where(c=>c.Geoubicacion ==club.Geoubicacion);
            return query;
        }*/
        public IEnumerable<Object>  GetDireccion( )
        {
            var query = _Clubs.Clubs.Select(clubs => new {
                Nombre=(clubs.NombreClub),
                Direccion = (clubs.Direccion)
            });
            return query;
        }
    }
}

