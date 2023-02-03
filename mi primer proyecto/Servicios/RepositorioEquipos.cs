using mi_primer_proyecto.Models;
using mi_primer_proyecto.Servicios;

namespace mi_primer_proyecto.Servicios
{
    public interface IRepositorioEquipos
    {
        List<Equipos> ObtenerEquipos();
    }
    public class RepositorioEquipos: IRepositorioEquipos
    {
        
        public List<Equipos> ObtenerEquipos()
        {
            return new List<Equipos>() { new Equipos
            {
                Nombre = "Tgres del licey",
                Color = "Azul",
                ciuda = "Santo domingo",
                Url = "http://licey.com",
                imagen ="/img/Tigres_del_licey_Logo.png"

            },
             new Equipos
            {
                Nombre = "Aguilas cibaeña",
                Color = "Amarilla",
                ciuda = "Santiago",
                Url = "http://aguilas.com",
                imagen ="/img/Aguilas-logo.png"

            },
              new Equipos
            {
                Nombre = "Leones del escogido",
                Color = "Rojo",
                ciuda = "santo domingo",
                Url = "http://leonesdelescogido.com",
                imagen ="/img/Logo_leones_Escogido.png"

            },
               new Equipos
            {
                Nombre = "Toros del este",
                Color = "Naranja",
                ciuda = "La romana",
                Url = "http://torodeleste.com",
                imagen ="/img/Toros-del-Este-Logo.jpg"

            },
                new Equipos
            {
                Nombre = "Estrellas orientales",
                Color = "Verde",
                ciuda = "San pedro",
                Url = "http://estrellasorientales.com",
                imagen ="/Estrella-basaball-club-logo.jpg"

            },
                 new Equipos
            {
                Nombre = "Gigante del cibao",
                Color = "Morado",
                ciuda = "San francisco",
                Url = "http://licey.com",
                imagen ="/img/GigantesDelCibao.jpg"
            },
            };

        }
    }

}
