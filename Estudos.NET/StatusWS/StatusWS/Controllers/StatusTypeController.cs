using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StatusWS.Data;
using StatusWS.Dtos;
using StatusWS.Models;

namespace StatusWS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatusTypeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StatusTypeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StatusTypeDto>>> GetStatusTypes()
        {
            return await _context.StatusTypes
                .Select(st => new StatusTypeDto
                {
                    StatusTypeId = st.StatusTypeId,
                    Description = st.Description,
                    IconUrl = st.IconUrl
                })
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StatusTypeDto>> GetStatusType(int id)
        {
            var statusType = await _context.StatusTypes
                .FirstOrDefaultAsync(st => st.StatusTypeId == id);

            if (statusType == null)
            {
                return NotFound();
            }

            var statusTypeDto = new StatusTypeDto
            {
                StatusTypeId = statusType.StatusTypeId,
                Description = statusType.Description,
                IconUrl = statusType.IconUrl
            };

            return statusTypeDto;
        }

        [HttpPost]
        public async Task<ActionResult<StatusTypeDto>> PostStatusType(StatusTypeCreateDto statusTypeDto)
        {
            var statusType = new StatusType
            {
                Description = statusTypeDto.Description,
                IconUrl = statusTypeDto.IconUrl
            };

            _context.StatusTypes.Add(statusType);
            await _context.SaveChangesAsync();

            // Mapeia a entidade para o DTO de retorno.
            var createdStatusTypeDto = new StatusTypeDto
            {
                StatusTypeId = statusType.StatusTypeId,
                Description = statusType.Description,
                IconUrl = statusType.IconUrl
            };

            return CreatedAtAction(nameof(GetStatusType), new { id = createdStatusTypeDto.StatusTypeId }, createdStatusTypeDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutStatusType(int id, StatusTypeCreateDto statusTypeDto)
        {
            var statusType = await _context.StatusTypes.FindAsync(id);

            if (statusType == null)
            {
                return NotFound();
            }

            // Atualiza as propriedades com os dados do DTO
            statusType.Description = statusTypeDto.Description;
            statusType.IconUrl = statusTypeDto.IconUrl;

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}