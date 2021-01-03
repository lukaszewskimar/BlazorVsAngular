using System.Threading.Tasks;
using Ebooks.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Ebooks.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EbooksController : ControllerBase
    {
        private readonly IEbookRepository _ebookRepository;
        private readonly ILogger<EbooksController> _logger;

        public EbooksController(ILogger<EbooksController> logger, IEbookRepository ebookRepository)
        {
            _logger = logger;
            _ebookRepository = ebookRepository;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            try
            {
                var result = await _ebookRepository.GetById(id);
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                var result = await _ebookRepository.GetAll();
                return Ok(result);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }
    }
}
