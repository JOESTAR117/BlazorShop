using BlazorShop.API.Mappings;
using BlazorShop.API.Repositories;
using BlazorShop.Models.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BlazorShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutosController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoDto>>> GetItens()
        {
            try
            {
                var produtos = await _produtoRepository.GetItens();
                if (produtos is null)
                    return NotFound();
                var produtosDTOs = produtos.ConverterProdutosParaDto();
                return Ok(produtosDTOs);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Erro ao acessar a base de dados");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoDto>> GetItem(int id)
        {
            try
            {
                var produto = await _produtoRepository.GetItem(id);
                if (produto is null)
                    return NotFound("Produto não encontrado");
                var produtoDTOs = produto.ConverterProdutoParaDto();
                return Ok(produtoDTOs);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Erro ao acessar a base de dados");
            }
        }

        [HttpGet]
        [Route("GetItensPorCategoria/{categoriaId}")]
        public async Task<ActionResult<IEnumerable<ProdutoDto>>> GetItensPorCategoria(int categoriaId)
        {
            try
            {
                var produtos = await _produtoRepository.GetItensPorCategoria(categoriaId);
                var produtosDTOs = produtos.ConverterProdutosParaDto();
                return Ok(produtosDTOs);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Erro ao acessar a base de dados");
            }
        }
    }
}
