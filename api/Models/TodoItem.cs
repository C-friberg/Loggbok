using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class TodoItem
    {
        public Guid Id {get; set;} = Guid.NewGuid(); 
        public string Title { get; set; } = string.Empty; 
        public string? Description { get; set; }// Optional
        public bool IsCompleted {get; set;} 
        public int TodoListId {get; set;}
        public TodoList? TodoList {get; set;}
        public List<Comment> Comments {get; set;} = new(); 


    }
}