using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos;
using api.Models;

namespace api.Interfaces
{
    public interface ITodoItemRepository
    {
        Task<List<TodoItem>> GetAllAsync(); 
        Task<TodoItem?> GetByIdAsync(Guid id); 
        Task<TodoItem> CreateAsync(TodoItem itemModel);
        Task<TodoItem?> UpdateAsync(Guid id, UpdateTodoItemRequestDto todoItemDto);
        Task<TodoItem?>DeleteAsync(Guid id);
        Task<bool> ItemExists(Guid id); 
    }
}