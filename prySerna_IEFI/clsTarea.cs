using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySerna_IEFI
{
    public class clsTarea
    {
        public int IdTarea {  get; set; }
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Tarea {  get; set; }
        public string Lugar { get; set; }
        public bool Insumo {  get; set; }
        public bool Estudio { get; set; }
        public bool Vacaciones { get; set; }
        public bool Enfermedad {  get; set; }
        public bool Salario {  get; set; }
        public bool Recibo {  get; set; }
        public string Comentario {  get; set; }

    }
}
