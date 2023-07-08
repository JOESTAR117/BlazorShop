using BlazorShop.API.Data;
using BlazorShop.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.API.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProdutoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Produto> GetItem(int id)
        {
            var produto = await _context.Produtos
                                .Include(c => c.Categoria)
                                .SingleOrDefaultAsync(c => c.Id == id);

            return produto;
        }

        public async Task<IEnumerable<Produto>> GetItens()
        {
            var produtos = await _context.Produtos
                                 .Include(c => c.Categoria)
                                 .ToListAsync();

            return produtos;
        }

        public async Task<IEnumerable<Produto>> GetItensPorCategoria(int id)
        {
            var produtos = await _context.Produtos
                                .Include(c => c.Categoria)
                                .Where(c => c.CategoriaId == id).ToListAsync();
            return produtos;
        }
    }
}
