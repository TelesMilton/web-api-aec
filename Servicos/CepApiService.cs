using Microsoft.EntityFrameworkCore;

using aec_gama_api.Models;
using System.Threading.Tasks;
using System.Net.Http;
using aec_gama_api;
using Newtonsoft.Json;
using System.Collections.Generic;

public class CepApiService
  {
    public async Task<List<Candidato>> GetCandidatos()
    {
      HttpClient http = new HttpClient();
      var response = await http.GetAsync($"{Program.ApiHost}/candidatos");
      if(response.IsSuccessStatusCode)
      {
        var resultado = response.Content.ReadAsStringAsync().Result;

        var candidatos = JsonConvert.DeserializeObject<List<Candidato>>(resultado);
        return candidatos;
      }

      return new List<Candidato>();
    }
  }