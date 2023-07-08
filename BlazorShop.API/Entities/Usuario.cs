namespace BlazorShop.API.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public required string NomeUsuario { get; set; }

        public Carrinho? Carrinho { get; set; }
    }
}
