using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class TodoList
    {
        public int Id {get; set;}
        public string Name { get; set; } = string.Empty; 
        public TodoCategory Category { get; set; }
        //Navigation
        public List<TodoItem> TodoItems {get; set;} = new(); 
    }
}