﻿using ProyectoFinal.API.Entities;

namespace ProyectoFinal.API.Services
{
    public interface IHaciendaServices
    {
        Task<SituacionTributaria?> ConsultarSituacionTributaria(string identificacion);
        Task<string> ConsultarIndicadorEconomico();
        Task<SituacionTributaria?> ConsultarExoneracion(string autorizacion);
        Task<SituacionTributaria?> ConsultarProductorAgropecuario(string identificacion);
        Task<SituacionTributaria?> ConsultarCabys(string codigoConsultar);

    }
}
