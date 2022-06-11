using Datos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocio.Logica
{
    public class UsuarioLogica
    {
        // Acás e agrega un comentario para mostrar el cambio en el repositorio GIT
        static Model1 dbContext = new Model1();

        public static bool ValidarLogin(String user, String password)
        {
            return dbContext.Usuarios.Any(u => u.Email == user && u.Clave == password);
        }

        public static void getPermisos(int idUsuario)
        {
            Usuarios usuario = dbContext.Usuarios.Where(u => u.IdUsuario == idUsuario).First();
            var permisos = usuario.Permisos.Descripcion;


            return;
        }

        //       public static void ObtenerAccesos(int idUsuario)
        public static List<Acciones> ObtenerAccesos(int idUsuario)
        {
            Usuarios usuario = dbContext.Usuarios.Where(u => u.IdUsuario == idUsuario).FirstOrDefault();
            var idPermiso = usuario.IdPermiso;

            var Temp = dbContext.PermisosAcciones.Where(pa => pa.IdPermiso == usuario.IdPermiso).ToList();
          //  var idAccesos = dbContext.PermisosAcciones.Where(a => a.IdPermiso == idPermiso).ToList();
       //     var accesos= dbContext.Acciones.Where(a => a.IdAccion == idAccesos.First().IdAccion).ToList();
            var accesos = dbContext.Acciones.ToList();
           // int idAccion = dbContext.PermisosAcciones.Where(p => p.idPermiso == usuario.idPermiso).First().idAccion;

            //dbContext.Acciones.Where(a => a.idAccion == idAccion).First();
            int idAccion = dbContext.PermisosAcciones.Where(p => p.IdPermiso == usuario.IdPermiso).First().IdAccion;
             var resultado=dbContext.Acciones.Where(a => a.IdAccion == idAccion).ToList();
            return resultado;
        }

        }
    }

