﻿using BlazorShop.Models.DTOs;
using System.Net;
using System.Net.Http.Json;

namespace BlazorShop.Web.Services
{
    public class CarrinhoCompraService : ICarrinhoCompraService
    {
        private readonly HttpClient _httpClient;

        public CarrinhoCompraService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CarrinhoItemDto> AdicionaItem(CarrinhoItemAdicionaDto carrinhoItemAdicionaDto)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync<CarrinhoItemAdicionaDto>("api/CarrinhoCompra", carrinhoItemAdicionaDto);

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == HttpStatusCode.NoContent)
                        return default;

                    return await response.Content.ReadFromJsonAsync<CarrinhoItemDto>();
                }
                var message = await response.Content.ReadAsStringAsync();
                throw new Exception($"{response.StatusCode} Message -{message}");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<CarrinhoItemDto>> GetItens(string usuarioId)
        {
            try
            {
                //envia um request GET para a uri da API CarrinhoCompra
                var response = await _httpClient.GetAsync($"api/CarrinhoCompra/{usuarioId}/GetItens");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                        return Enumerable.Empty<CarrinhoItemDto>().ToList();

                    return await response.Content.ReadFromJsonAsync<List<CarrinhoItemDto>>();
                }

                var message = await response.Content.ReadAsStringAsync();
                throw new Exception($"Http Status Code: {response.StatusCode} Mensagem: {message}");

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
