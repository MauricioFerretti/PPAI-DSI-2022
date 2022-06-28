using System;
using System.Collections.Generic;
using System.Text;

namespace PPAI_DSI_2022.Negocio
{
    class Marca
    {
        private String nombre;
        Modelo modelo;

        public String mostrarMarcaYModelo()
        {
            return nombre + modelo.mostrarModelo();
        }

    }
}
