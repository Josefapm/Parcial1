namespace Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PermisosAcciones
    {
        public int Id { get; set; }

        public int IdAccion { get; set; }

        public int IdPermiso { get; set; }

        public virtual Acciones Acciones { get; set; }

        public virtual Permisos Permisos { get; set; }
    }
}
