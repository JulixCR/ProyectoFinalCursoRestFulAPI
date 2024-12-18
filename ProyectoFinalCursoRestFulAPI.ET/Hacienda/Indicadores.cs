﻿namespace ProyectoFinal.ET
{
    public class Indicadores
    {
        public Dolar dolar { get; set; }
        public Euro euro { get; set; }
    }

    public class Compra
    {
        public string fecha { get; set; }
        public double valor { get; set; }
    }

    public class Dolar
    {
        public Venta venta { get; set; }
        public Compra compra { get; set; }
    }

    public class Euro
    {
        public string fecha { get; set; }
        public double dolares { get; set; }
        public double colones { get; set; }
    }    

    public class Venta
    {
        public string
            fecha { get; set; }
        public double valor { get; set; }
    }
}
