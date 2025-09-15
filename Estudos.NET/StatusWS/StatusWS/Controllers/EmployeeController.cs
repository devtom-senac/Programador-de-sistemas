using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StatusWS.Data;
using StatusWS.Dtos;
using StatusWS.Models;

namespace StatusWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmployeeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeDto>>> GetEmployees()
        {
            var employees = await _context.Employees
                .Where(e => e.IsActive) // FILTRO WHERE PARA EXCLUSÃO LÓGICA
                .Include(e => e.Status)
                    .ThenInclude(s => s.StatusType)
                .Select(e => new EmployeeDto
                {
                    EmployeeId = e.EmployeeId,
                    Name = e.Name,
                    Position = e.Position,
                    Photo = e.Photo,
                    CreatedAt = e.CreatedAt,
                    IsActive = e.IsActive,
                    Status = new StatusDto
                    {
                        StatusId = e.Status.StatusId,
                        CustomText = e.Status.CustomText,
                        UpdateAt = e.Status.UpdateAt,
                        StatusType = new StatusTypeDto
                        {
                            StatusTypeId = e.Status.StatusType.StatusTypeId,
                            Description = e.Status.StatusType.Description,
                            IconUrl = e.Status.StatusType.IconUrl
                        }
                    }
                })
                .ToListAsync();

            return Ok(employees);
        }

        // POST: api/Employee
        // Cria um novo funcionário com um novo status padrão.
        [HttpPost]
        public async Task<ActionResult<EmployeeDto>> PostEmployee(EmployeeCreateDto employeeCreateDto)
        {
            // Cria um novo objeto Status para o funcionário
            var defaultStatus = new Status
            {
                CustomText = "Nenhum status definido",
                UpdateAt = DateTime.UtcNow,
                StatusTypeId = 1 // Vazio
            };

            // Mapeia o DTO de criação para a entidade Employee
            var employee = new Employee
            {
                Name = employeeCreateDto.Name,
                Position = employeeCreateDto.Position,
                Photo = employeeCreateDto.Photo ?? "https://tarefas.websupply.com.br/painel/assets/userDefault-uMDAqLiz.png",
                Status = defaultStatus // Vincula o novo status ao funcionário
            };

            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            // Carrega o StatusType para a resposta.
            await _context.Entry(employee).Reference(e => e.Status).LoadAsync();
            await _context.Entry(employee.Status).Reference(s => s.StatusType).LoadAsync();

            // Mapeia a entidade completa para o DTO de retorno
            var employeeDto = new EmployeeDto
            {
                EmployeeId = employee.EmployeeId,
                Name = employee.Name,
                Position = employee.Position,
                Photo = employee.Photo,
                CreatedAt = employee.CreatedAt,
                IsActive = employee.IsActive,
                Status = new StatusDto
                {
                    StatusId = employee.Status.StatusId,
                    CustomText = employee.Status.CustomText,
                    UpdateAt = employee.Status.UpdateAt,
                    StatusType = new StatusTypeDto
                    {
                        StatusTypeId = employee.Status.StatusType.StatusTypeId,
                        Description = employee.Status.StatusType.Description,
                        IconUrl = employee.Status.StatusType.IconUrl
                    }
                }
            };

            return CreatedAtAction(nameof(GetEmployees), new { id = employeeDto.EmployeeId }, employeeDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee(int id, EmployeeUpdateDto employeeUpdateDto)
        {
            var employee = await _context.Employees
                .Include(e => e.Status) // Inclui o status atual para podermos atualizar o texto
                .FirstOrDefaultAsync(e => e.EmployeeId == id);

            if (employee == null)
            {
                return NotFound();
            }

            // Se um novo StatusId foi fornecido, a gente atualiza o StatusId do Status do funcionário.
            if (employeeUpdateDto.StatusId != null)
            {
                employee.Status.StatusTypeId = employeeUpdateDto.StatusId.Value;
                employee.Status.UpdateAt = DateTime.UtcNow;

                // Se o novo status for "vazio", limpamos o CustomText.
                if (employeeUpdateDto.StatusId == 1)
                {
                    employee.Status.CustomText = null;
                }
            }

            // Se o CustomText foi fornecido, a gente atualiza o CustomText do Status.
            if (employeeUpdateDto.CustomText != null)
            {
                employee.Status.CustomText = employeeUpdateDto.CustomText;
                employee.Status.UpdateAt = DateTime.UtcNow;
            }

            // Se a foto foi fornecida, a gente atualiza a foto.
            if (employeeUpdateDto.Photo != null)
            {
                employee.Photo = employeeUpdateDto.Photo;
            }

            if (employeeUpdateDto.IsActive != null)
            {
                employee.IsActive = employeeUpdateDto.IsActive.Value;
            }

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            employee.IsActive = false;
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}
