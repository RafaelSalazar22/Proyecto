using Microsoft.AspNetCore.Mvc;
using System.Collections;
using Infrastructure.RepositoryClubs;
using Domain.dto;
using Finding_a_Tournament.Domain.Entities;
using System.Linq;
using System.Text.Json;
using System.IO;
using Infrastructure;
using System.Threading.Tasks;
namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Clubscontroller : ControllerBase
    {
        [HttpGet]
        [Route("Clubs")]
        public IActionResult GetAll()
        {
            var repository = new RepositoryClubs();
            var clubs = repository.GetAll();
            return Ok(clubs);
        } 
        [HttpGet]
        [Route("Nombre")]
        public IActionResult DatosImportantes()
        {
            var repository = new RepositoryClubs();
            var clubs = repository.GetFields();
            return Ok(clubs);
        } 
        [HttpGet]
        [Route("{Id_Club:int}")]
        public IActionResult Single(int Id_Club)
        {
            var repository = new RepositoryClubs();
            var clubs = repository.GetById2(Id_Club);
            var respuesta = ObjectToDto(clubs);
            return Ok(respuesta);
        }
        [HttpGet]
        [Route("Direccion")]
        public IActionResult Direccion()
        {
            var repository = new RepositoryClubs();
            var clubs = repository.GetDireccion();
            return Ok(clubs);
        }
         [HttpGet]
        [Route("Telefono")]
         public IActionResult Telefono()
        {
            var repository = new RepositoryClubs();
            var clubs = repository.Telefono();
            return Ok(clubs);
        }
        private  ClubsResponseDto ObjectToDto(Club clubs)
        {
            return new ClubsResponseDto(
               NombreClub:$"{clubs.NombreClub}",
                TelefonoContacto:$"{clubs.TelefonoContacto}",
                direccion:$"{clubs.Direccion}"
            );
        }
        /*[HttpPost]
        [Route("Todos")]
        public IActionResult GetByFilter([FromBody] ClubsFilterDto dto)
        {
            var club = DtoToObject(dto);
            var repository = new RepositoryClubs();
            var Respuesta= repository.GetByFilter(club).Select(c=> new ClubsResponseDto( NombreClub:$"{c.NombreClub}",
                TelefonoContacto:$"{c?.TelefonoContacto}",direccion:$"{c?.Direccion}"));
            return Ok(Respuesta);
        }
        private Club DtoToObject(ClubsFilterDto  dto)
        {
            var Club = new Club( IdClub:0,NombreClub: dto.NombreClub,Direccion: dto.Direccion,TelefonoContacto:dto.TelefonoContacto,Geoubicacion:dto.Geoubicacion,Logotipo: string.Empty,
            Servicios: new ServiciosClub(IdServicio: 0, Diciplina:string.Empty, HorarioDiciplina:string.Empty,CantidadPer:0,PersHabilidadesDiferentes:true || false ,IdClub:0));
            return Club;
        }*/

    }
}