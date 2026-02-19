using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace api.Dtos
{
    public class CreateItemRequestDto
    {
        [Required]
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }// Optional
        [Required]
        public bool IsCompleted { get; set; }
        [Required]
        public int TodoListId { get; set; }
        [Required]
        public TodoList? TodoList { get; set; }

    }
}