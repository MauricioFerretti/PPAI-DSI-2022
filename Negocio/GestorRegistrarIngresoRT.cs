using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PPAI_DSI_2022.Negocio
{
    class GestorRegistrarIngresoRT
    {
        private List<AsignacionResponsableTecnicoRT> asignacionResponsableTecnicoRT;
        private List<RecursoTecnologico> listaRecursoTecnologicoRTLog;
        Sesion sesionActual = new Sesion();
        PersonalCientifico cientificoLogueado;
        AsignacionResponsableTecnicoRT asigResponsableTecnicoRTLog;
        //BackEnd persistencia = new BackEnd();

        public void tomarSeleccionRegristrarIngresoRTenMC()
        {
            getUsuarioLogueado();
            buscarRTVigentedeUsuarioLog();
        }

        public void getUsuarioLogueado()
        {
            cientificoLogueado = sesionActual.getCientificoLogueado();
        }

        public void buscarRTVigentedeUsuarioLog()
        {
            // asignacionResponsableTecnicoRT = persistencia.getAsignacionResponsableTecnicoRT();
            foreach (AsignacionResponsableTecnicoRT asigResponsableTecnicoRT in asignacionResponsableTecnicoRT)
            {
                if(asigResponsableTecnicoRT.esDeUsuarioLogYVigente(cientificoLogueado) == true)
                {
                    asigResponsableTecnicoRTLog = asigResponsableTecnicoRT;
                }
            }

            // listaRecursoTecnologicoRTLog = persistencia.getlistaRecursoTecnologicoRTLog(asigResponsableTecnicoRTLog);
            if (asigResponsableTecnicoRTLog.getRTDisponibles() != null)
            {
                listaRecursoTecnologicoRTLog = asigResponsableTecnicoRTLog.getRTDisponibles();
            }
            else
            {
                 MessageBox.Show("No se encontraron Recursos Tecnologicos");
            }
        }

    }
}
