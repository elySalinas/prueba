using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    //HOLAAAAAAAAAAAAAAAAAAAAAA XD
    public class Cita
    {
        private BindingList<Tratamiento> listaTratamientos;
        private BindingList<Paquete> listaPaquetes;
        private DateTime fechaRegistro;
        private BindingList<BindingList<Sesion>> listaSesion;
        private Cliente cliente;

        public Cita(DateTime fechaRegistro, List<Sesion> listaSesion, Cliente cliente)
        {
            this.ListaTratamientos = new BindingList<Tratamiento>();
            this.ListaPaquetes = new BindingList<Paquete>();
            this.ListaSesion = new BindingList<BindingList<Sesion>>();
            this.FechaRegistro = fechaRegistro;
            this.Cliente = cliente;
        }

        public BindingList<Tratamiento> ListaTratamientos { get => listaTratamientos; set => listaTratamientos = value; }
        public BindingList<Paquete> ListaPaquetes { get => listaPaquetes; set => listaPaquetes = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public BindingList<BindingList<Sesion>> ListaSesion { get => listaSesion; set => listaSesion = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
    }
}
