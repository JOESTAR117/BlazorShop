using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorShop.API.Entities
{
    public class Produto
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public required string Nome { get; set; }

        [MaxLength(200)]
        public required string Descricao { get; set; }

        [MaxLength(200)]
        public required string ImagemUrl { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public required decimal Preco { get; set; }
        public required int Quantidade { get; set; }

        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }

        public ICollection<CarrinhoItem> Itens { get; set; } = new List<CarrinhoItem>();
    }
}
