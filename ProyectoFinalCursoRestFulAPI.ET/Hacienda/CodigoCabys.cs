namespace ProyectoFinal.ET
{
    public class CodigoCabys
    {
        public int total { get; set; }
        public int cantidad { get; set; }
        public List<Caby> cabys { get; set; }
    }

    public class Caby
    {
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public List<string> categorias { get; set; }
        public int impuesto { get; set; }
        public string uri { get; set; }
        public string estado { get; set; }
    }

}
