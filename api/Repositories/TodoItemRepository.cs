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

        public Task<List<TodoItem>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TodoItem?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ItemExists(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<TodoItem?> UpdateAsync(Guid id, UpdateTodoItemRequestDto todoItemDto)
        {
            throw new NotImplementedException();
        }
    }
}