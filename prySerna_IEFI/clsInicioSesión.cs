using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySerna_IEFI
{
    public class clsInicioSesión
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public DateTime FechaCreacion { get; set; }         
        public DateTime UltimaConexion { get; set; }        
        public TimeSpan TiempoUltimaConexion { get; set; }  
        public TimeSpan TiempoTotal { get; set; }
    }
}
