using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Paquete
    {
        private int idPaquete;
        private String nombre;
        private double precio;
        private int estado;
        private List<Tratamiento> tratamientos;
        private int cantSesion;

        private String strTratamientos;

        public Paquete()
        {
            Tratamientos = new List<Tratamiento>();
        }

        public Paquete(int idPaquete, string nombre, double precio, int estado, List<Tratamiento> tratamientos, int cantSesion)
        {
            this.IdPaquete = idPaquete;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Estado = estado;
            this.Tratamientos = tratamientos;
            this.CantSesion = cantSesion;
        }

        public Paquete(int idPaquete, String nombre, double precio, int cantSesion)
        {
            this.idPaquete = idPaquete;
            this.nombre = nombre;
            this.precio = precio;
            this.cantSesion = cantSesion; 
            tratamientos = new List<Tratamiento>();
        }

        public int IdPaquete { get => idPaquete; set => idPaquete = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Estado { get => estado; set => estado = value; }
        public List<Tratamiento> Tratamientos { get => tratamientos; set => tratamientos = value; }
        public int CantSesion { get => cantSesion; set => cantSesion = value; }

        public void addTratamiento(Tratamiento t)
        {
            Tratamientos.Add(t);
        }
    }
}
