using BlazorShop.API.Data;
using BlazorShop.API.Entities;
using BlazorShop.Models.DTOs;

namespace BlazorShop.API.Repositories
{
    public class CarrinhoCompraRepository : ICarrinhoCompraRepository
    {
        private readonly ApplicationDbContext _context;

        public CarrinhoCompraRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<CarrinhoItem> AdicionaItem(CarrinhoItemAdicionaDto carrinhoItemAdicionaDto)
        {
            throw new NotImplementedException();
        }

        public Task<CarrinhoItem> AtualizaQuantidade(int id, CarrinhoItemAtualizaQuantidadeDto carrinhoItemAtualizaQuantidadeDto)
        {
            throw new NotImplementedException();
        }

        public Task<CarrinhoItem> DeletaItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CarrinhoItem> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CarrinhoItem>> GetItens(string usuarioId)
        {
            throw new NotImplementedException();
        }
    }
}
