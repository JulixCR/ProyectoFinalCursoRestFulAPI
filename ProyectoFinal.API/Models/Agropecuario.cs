namespace ProyectoFinal.API.Models
{
    public class Agropecuario
    {
        public List<ListaDatosMAG> listaDatosMAG { get; set; }
        public List<object> listaDatosIncopesca { get; set; }
        public List<ListaDatosAcuicultore> listaDatosAcuicultores { get; set; }
    }

    public class ListaDatosAcuicultore
    {
        public string nombreAcuicultor { get; set; }
        public string fechaVenceAcuicultor { get; set; }
        public bool indicadorActivoAcuicultor { get; set; }
    }

    public class ListaDatosMAG
    {
        public bool indicadorActivoMAG { get; set; }
        public string estadoMAG { get; set; }
        public string fechaAltaMAG { get; set; }
        public string fechaBajaMAG { get; set; }
        public string nombreMAG { get; set; }
    }


}
