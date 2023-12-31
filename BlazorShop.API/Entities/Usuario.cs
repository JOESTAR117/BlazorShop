﻿using System.ComponentModel.DataAnnotations;

namespace BlazorShop.API.Entities
{
    public class Usuario
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public required string NomeUsuario { get; set; }

        public Carrinho? Carrinho { get; set; }
    }
}
