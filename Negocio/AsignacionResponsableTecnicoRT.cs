using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PPAI_DSI_2022.Negocio
{
    class AsignacionResponsableTecnicoRT
    {
        private PersonalCientifico personalCientifico = new PersonalCientifico();
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private List<RecursoTecnologico> recursoTecnologico = new List<RecursoTecnologico>();
        public AsignacionResponsableTecnicoRT(AsignacionResponsableTecnicoRT asignacionResponsableTecnicoRT)
        {
            this.personalCientifico = asignacionResponsableTecnicoRT.personalCientifico;
            this.fechaDesde = asignacionResponsableTecnicoRT.fechaDesde;
            this.fechaHasta = asignacionResponsableTecnicoRT.fechaHasta;
            this.recursoTecnologico = asignacionResponsableTecnicoRT.recursoTecnologico;
        }
        
        public Boolean esDeUsuarioLogYVigente(PersonalCientifico personalCientificoLogueado) 
        {
             if(this.personalCientifico.Equals(personalCientificoLogueado) && esVigente() == true)
                {
                    return true;
                }
             return false;
            
        }
        public Boolean esVigente()
        {
            if(this.fechaDesde < DateTime.Now && this.fechaHasta > DateTime.Now)
            {
                return true;
            }
            return false;
        }
        public List<RecursoTecnologico> getRTDisponibles()
        {
            List<RecursoTecnologico> recursoTecnologicoRTLog = new List<RecursoTecnologico>();
            foreach (RecursoTecnologico recTecnologico in this.recursoTecnologico)
            {
                if (recTecnologico.esRTDisponible() == true)
                {
                    recTecnologico.mostrarRT();
                    recursoTecnologicoRTLog.Add(recTecnologico);
                }
            }
            return recursoTecnologicoRTLog;
        }
    }
}
