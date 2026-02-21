using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos;
using api.Models;

namespace api.Interfaces
{
    public interface ITodoListRepository
    {
        Task<List<TodoList>> GetAllAsync(); 
        Task<TodoList?> GetByIdAsync(Guid id);
        Task<TodoList>  CreateAsync(TodoList list); 
        Task<TodoList?> UpdateAsync (Guid id, UpdateTodoListRequestDto dto); 
        Task<TodoList?> DeleteAsyc (Guid id); 
    }
}