﻿namespace BlazorShop.Models.DTOs
{
    public class CarrinhoItemDto
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int CarrinhoId { get; set; }
        public int Quantidade { get; set; }

        public required string ProdutoNome { get; set; }
        public required string ProdutoDescricao { get; set; }
        public required string ProdutoImagemURL { get; set; }
        public decimal Preco { get; set; }
        public decimal PrecoTotal { get; set; }
    }
}
