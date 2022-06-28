using System;
using System.Collections.Generic;
using System.Text;

namespace PPAI_DSI_2022.Negocio
{
    
    class Sesion
    {
        Usuario usuario = new Usuario();
        public PersonalCientifico getCientificoLogueado()
        {
            return this.usuario.getCientifico();
        }
    }
}
