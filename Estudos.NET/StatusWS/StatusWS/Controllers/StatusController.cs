using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StatusWS.Data;
using StatusWS.Models;
using StatusWS.Dtos;

namespace StatusWS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StatusController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StatusController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Status
        // Agora retorna uma lista de StatusDto
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StatusDto>>> GetStatuses()
        {
            return await _context.Statuses
                .Include(s => s.StatusType)
                .Select(s => new StatusDto
                {
                    StatusId = s.StatusId,
                    CustomText = s.CustomText,
                    UpdateAt = s.UpdateAt,
                    StatusType = new StatusTypeDto
                    {
                        StatusTypeId = s.StatusType.StatusTypeId,
                        Description = s.StatusType.Description,
                        IconUrl = s.StatusType.IconUrl
                    }
                })
                .ToListAsync();
        }

        // GET: api/Status/5
        // Agora retorna um único StatusDto
        [HttpGet("{id}")]
        public async Task<ActionResult<StatusDto>> GetStatus(int id)
        {
            var status = await _context.Statuses
                .Include(s => s.StatusType)
                .FirstOrDefaultAsync(s => s.StatusId == id);

            if (status == null)
            {
                return NotFound();
            }

            var statusDto = new StatusDto
            {
                StatusId = status.StatusId,
                CustomText = status.CustomText,
                UpdateAt = status.UpdateAt,
                StatusType = new StatusTypeDto
                {
                    StatusTypeId = status.StatusType.StatusTypeId,
                    Description = status.StatusType.Description,
                    IconUrl = status.StatusType.IconUrl
                }
            };

            return statusDto;
        }

        // POST: api/Status
        // recebe o DTO de criação e retorna o DTO de retorno
        [HttpPost]
        public async Task<ActionResult<StatusDto>> PostStatus(StatusCreateDto statusCreateDto)
        {
            var status = new Status
            {
                CustomText = statusCreateDto.CustomText,
                StatusTypeId = statusCreateDto.StatusTypeId,
                UpdateAt = DateTime.UtcNow
            };

            _context.Statuses.Add(status);
            await _context.SaveChangesAsync();

            // Carregamos a propriedade de navegação StatusType para o retorno
            await _context.Entry(status).Reference(s => s.StatusType).LoadAsync();

            var createdStatusDto = new StatusDto
            {
                StatusId = status.StatusId,
                CustomText = status.CustomText,
                UpdateAt = status.UpdateAt,
                StatusType = new StatusTypeDto
                {
                    StatusTypeId = status.StatusType.StatusTypeId,
                    Description = status.StatusType.Description,
                    IconUrl = status.StatusType.IconUrl
                }
            };

            return CreatedAtAction(nameof(GetStatus), new { id = createdStatusDto.StatusId }, createdStatusDto);
        }

    }
}