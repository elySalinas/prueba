using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class TratamientoBL
    {
        private TratamientoDA tratamientoDA;

        public TratamientoBL()
        {
            tratamientoDA = new TratamientoDA();
        }

        public BindingList<Tratamiento> listarTratamientos()
        {
            return tratamientoDA.listarTratamientos();

        }

        public int registrarTratamiento(Tratamiento tratamiento)
        {
            int idTrat = tratamientoDA.registrarTratamiento(tratamiento);
            /*
            foreach (Zona z in tratamiento.ZonasTratar)
            {
                z.registrarZona(idTrat, z);
            }
            */
            return idTrat;
        }

        public void modificarTratamiento(Tratamiento tratamiento)
        {
            tratamientoDA.modificarTratamiento(tratamiento);
        }
    }
}
