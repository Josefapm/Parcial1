namespace Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }

        public int IdPermiso { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Required]
        [StringLength(50)]
        public string Clave { get; set; }

        [Required]
        [StringLength(10)]
        public string FechaDeAlta { get; set; }

        [Required]
        [StringLength(50)]
        public string Dirección { get; set; }

        [Required]
        [StringLength(1)]
        public string Sexo { get; set; }

        [Required]
        [StringLength(255)]
        public string Observaciones { get; set; }

        public virtual Permisos Permisos { get; set; }
    }
}
