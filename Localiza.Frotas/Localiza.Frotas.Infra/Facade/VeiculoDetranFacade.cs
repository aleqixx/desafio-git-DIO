﻿using Localiza.Frotas.Domain;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Localiza.Frotas.Infra.Facade
{
    public class VeiculoDetranFacade : IVeiculoDetran
    {
        private readonly DetranOptions detranOptions;
        private readonly IHttpClientFactory httpClientFactory;
        private readonly IVeiculoRepository veiculoRepository;

        public VeiculoDetranFacade(IOptionsMonitor<DetranOptions> optionsMonitor,
            IHttpClientFactory httpClientFactory,
            IVeiculoRepository veiculoRepository)
        {
            this.detranOptions = optionsMonitor.CurrentValue;
            this.httpClientFactory = httpClientFactory;
            this.veiculoRepository = veiculoRepository;
        }
        public async Task AgendarVistoriaDetran(Guid veiculoId)
        {
            var veiculo = veiculoRepository.GetById(veiculoId);
            var requestModel = new VistoriaModel()
            {
                Placa = veiculo.Placa,
                AgendadoPara = DateTime.Now.AddDays(detranOptions.QuantidadeDiasParaAgendamento)
            };

            var client = httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(detranOptions.BaseUrl);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var jsonContent = JsonSerializer.Serialize(requestModel);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");


            await client.PostAsync(detranOptions.VistoriaUri, contentString);

        }
    }
}