using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories
{
    public class TodoItemRepository : ITodoItemRepository
    {

        private readonly AppDbContext _context;
        public TodoItemRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<TodoItem> CreateAsync(TodoItem itemModel)
        {
            await _context.TodoItems.AddAsync(itemModel);
            await _context.SaveChangesAsync();
            return itemModel;
        }

        public async Task<TodoItem?> DeleteAsync(Guid id)
        {
            var itemModel = await _context.TodoItems.FirstOrDefaultAsync(x => x.Id == id);
            if (itemModel == null)
            {
                return null;
            }
            _context.Remove(itemModel);
            await _context.SaveChangesAsync();
            return itemModel;
        }

        public async Task<List<TodoItem>> GetAllAsync()
        {
            return await _context.TodoItems.ToListAsync();
        }

        public async Task<TodoItem?> GetByIdAsync(Guid id)
        {
            return await _context.TodoItems.FirstOrDefaultAsync(i => i.Id == id);
        }

        public Task<bool> ItemExists(Guid id)
        {
            return _context.TodoItems.AnyAsync(i => i.Id == id);
        }

        public async Task<TodoItem?> UpdateAsync(Guid id, UpdateTodoItemRequestDto todoItemDto)
        {
            var existingItem = await _context.TodoItems.FirstOrDefaultAsync(x => x.Id == id);
            if (existingItem == null)
            {
                return null;
            }

            existingItem.Title = todoItemDto.Title;
            existingItem.Description = todoItemDto.Description;
            existingItem.IsCompleted = todoItemDto.IsCompleted;
            existingItem.TodoListId = todoItemDto.TodoListId;

            await _context.SaveChangesAsync();
            return existingItem;
        }
    }
}