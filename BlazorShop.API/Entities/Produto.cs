namespace BlazorShop.API.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Descricao { get; set; }
        public required string ImagemUrl { get; set; }
        public required decimal Preco { get; set; }
        public required int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }

        public ICollection<CarrinhoItem> Itens { get; set; } = new List<CarrinhoItem>();
    }
}
