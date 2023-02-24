using sm.entrenamiento.ejemplo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace sm.entrenamiento.ejemplo
{
    public class PedidoServicio
    {
        private readonly string _tipoCliente;
        private List<Producto> productos;

        public PedidoServicio(string tipoCliente)
        {
            _tipoCliente = tipoCliente;
            productos = new List<Producto>();
        }

        public void AgregarProducto(int cantidad, string producto)
        {
            throw new NotImplementedException();
        }

        public int CalcularCostoEnvio()
        {
            throw new NotImplementedException();
        }
    }
}
