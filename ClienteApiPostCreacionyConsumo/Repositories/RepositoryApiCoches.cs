using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ClienteApiPostCreacionyConsumo.Models;

namespace ClienteApiPostCreacionyConsumo.Repositories
{
    public class RepositoryApiCoches : IRepositoryApiCoches
    {
        private String uriapi;
        private MediaTypeWithQualityHeaderValue headerjson;
        public RepositoryApiCoches()
        {
            this.uriapi = "http://localhost:54922/";
            this.headerjson = new MediaTypeWithQualityHeaderValue("application/json");
        }
        public async Task<List<Coche>> GetCoches()
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/Coches";
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response = await client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    List<Coche> coches = await response.Content.ReadAsAsync<List<Coche>>();
                    return coches;
                }
                else
                {
                    return null;
                }
            }

        }

        public async Task<List<Coche>> GetCochesPorMarca(string marca)
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/BuscarCoches/" + marca;
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response = await client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    List<Coche> coches = await response.Content.ReadAsAsync<List<Coche>>();
                    return coches;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<List<string>> GetMarcas()
        {
            using (HttpClient client = new HttpClient())
            {
                String peticion = "api/Marcas";
                client.BaseAddress = new Uri(this.uriapi);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(headerjson);
                HttpResponseMessage response = await client.GetAsync(peticion);
                if (response.IsSuccessStatusCode)
                {
                    List<String> marcas = await response.Content.ReadAsAsync<List<String>>();
                    return marcas;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
