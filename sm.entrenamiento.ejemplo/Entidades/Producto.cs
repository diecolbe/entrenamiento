using System.ComponentModel.DataAnnotations;

namespace sm.entrenamiento.ejemplo.Entidades
{
    public class Producto
    {
        public int cantidad { get; set; } = 1;
        [MaxLength(50)]
        public string nombre { get; set; }

        public Producto(int cantidad, string nombre)
        {
            this.cantidad = cantidad;
            this.nombre = nombre;
        }
        public Producto() { }
    }
}
