using System;
using System.Collections.Generic;
using System.Text;

namespace PPAI_DSI_2022.Negocio
{
    class CambioEstadoRT
    {
        DateTime fechaDesde;
        DateTime fechaHasta;
        Estado estado;
       public Boolean esEstadoActual()
        {
            if (this.fechaHasta == null)
            {
                return true;
            }
            return false;
        }

        public Boolean esEstadoActualDisponible()
        {
            if (estado.mostrarEstado() == "Disponible")
            {
                return true;
            }
            return false;
        }
    } 

    
}
