using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProyectoFinal.ET
{
    public class ApiProd
    {
        public string lasterror { get; set; }
        public string last_update { get; set; }
        public string status { get; set; }
        public string lasterror_ago { get; set; }
        public TOKEN TOKEN { get; set; }
        public GET GET { get; set; }
    }

    public class ApiStag
    {
        public GET GET { get; set; }
        public TOKEN TOKEN { get; set; }
        public string lasterror_ago { get; set; }
        public string status { get; set; }
        public string last_update { get; set; }
        public string lasterror { get; set; }
    }

    public class GET
    {
        public string error_count_15min { get; set; }
        public string avg_response_time_15min { get; set; }
    }

    public class StatusAPI
    {
        public string powered_by { get; set; }
        public string license { get; set; }

        [property: JsonPropertyName("api-stag")]
        public ApiStag apistag { get; set; }

        [property: JsonPropertyName("api-prod")]
        public ApiProd apiprod { get; set; }
    }

    public class TOKEN
    {
        public string avg_response_time_15min { get; set; }
        public string error_count_15min { get; set; }
    }
}
