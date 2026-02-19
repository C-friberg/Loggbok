using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos;
using api.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/todoitem")]
    [ApiController]
    public class TodoItemController : ControllerBase
    {
        private readonly ITodoItemRepository _itemRepo;
        public TodoItemController(ITodoItemRepository itemRepo)
        {
            _itemRepo = itemRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var items = await _itemRepo.GetAllAsync();
            var itemDto = items.Select(i => i.ToItemDto());

            return Ok(itemDto);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var item = await _itemRepo.GetByIdAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item.ToItemDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateItemRequestDto itemDto)
        {
            if (!ModelState.IsValid)
            {
                return null;
            }

            var itemModel = itemDto.ToItemFromCreateDto();
            await _itemRepo.CreateAsync(itemModel);
            return CreatedAtAction(nameof(GetById), new { id = itemModel.Id }, itemModel.ToItemDto());
        }
    }
}