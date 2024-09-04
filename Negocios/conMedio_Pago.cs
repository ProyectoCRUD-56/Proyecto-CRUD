using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class conMedio_Pago
    {
        private modMedios_Pago medio_pago = new modMedios_Pago();
        public DataTable MostrarMediosPago()
        {
            DataTable tabla = new DataTable();
            tabla = medio_pago.Mostrar_MedioPago();
            return tabla;
        }

        public void Insertar_MedioPago(string metodo, string detalles)
        {
            medio_pago.Insertar_MedioPago(metodo, detalles);
        }

        public void Editar_MedioPago(string metodo, string detalles, string id)
        {
            medio_pago.Editar_MedioPago(metodo, detalles, Convert.ToInt32(id));
        }

        public void Eliminar_MedioPago(string id)
        {
            medio_pago.Eliminar_MedioPago(Convert.ToInt32(id));
        }

        public string getNombre(int id)
        {
            return medio_pago.getNombre(id);
        }
    }
}
