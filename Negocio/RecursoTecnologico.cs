using System;
using System.Collections.Generic;
using System.Text;

namespace PPAI_DSI_2022.Negocio
{
    class RecursoTecnologico
    {
        TipoRecurso tipoRecurso;
        Marca marca;

        List<CambioEstadoRT> cambioEstadoRT;
        public Boolean esRTDisponible()
        {
            foreach (CambioEstadoRT camEstadoRT in cambioEstadoRT)
            {
                if(camEstadoRT.esEstadoActual() == true)
                {
                    if(camEstadoRT.esEstadoActualDisponible()== true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public String mostrarRT()
        {
            return tipoRecurso.mostrarTipoRecurso() + marca.mostrarMarcaYModelo();

        }
    }

}
