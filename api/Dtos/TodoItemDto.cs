using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Dtos
{
    public class TodoItemDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }// Optional
        public bool IsCompleted { get; set; }
        public int TodoListId { get; set; }
        public TodoList? TodoList { get; set; }
        public List<CommentDto> Comments { get; set; } = new();
    }
}