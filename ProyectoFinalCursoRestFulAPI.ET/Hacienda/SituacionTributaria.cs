namespace ProyectoFinal.ET
{
    public class SituacionTributaria
    {
        public string nombre { get; set; }
        public string tipoIdentificacion { get; set; }
        public Regimen regimen { get; set; }
        public Situacion situacion { get; set; }
        public List<Actividad> actividades { get; set; }
    }

    public class Actividad
    {
        public string estado { get; set; }
        public string tipo { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }
    }

    public class Regimen
    {
        public int codigo { get; set; }
        public string descripcion { get; set; }
    }

    public class Situacion
    {
        public string moroso { get; set; }
        public string omiso { get; set; }
        public string estado { get; set; }
        public string administracionTributaria { get; set; }
    }
}
