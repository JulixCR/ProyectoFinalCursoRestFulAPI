namespace ProyectoFinal.ET
{
    public class Exoneracion
    {
        public string numeroDocumento { get; set; }
        public string identificacion { get; set; }
        public int codigoProyectoCFIA { get; set; }
        public DateTime fechaEmision { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public int porcentajeExoneracion { get; set; }
        public TipoDocumento tipoDocumento { get; set; }
        public string nombreInstitucion { get; set; }
        public bool poseeCabys { get; set; }
        public List<string> cabys { get; set; }
    }

    public class TipoDocumento
    {
        public string codigo { get; set; }
        public string descripcion { get; set; }
    }
}
