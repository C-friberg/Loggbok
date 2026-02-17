using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos;
using api.Mappers;
using api.Models;

namespace api.Dtos
{
    public static class TodoItemMapper
    {
        public static TodoItemDto ToItemDto(this TodoItem itemModel)
        {
            return new TodoItemDto
            {
                Id = itemModel.Id,
                Title = itemModel.Title,
                Description = itemModel.Description,
                IsCompleted = itemModel.IsCompleted,
                TodoListId = itemModel.TodoListId,
                TodoList = itemModel.TodoList,
                Comments = itemModel.Comments.Select(c => c.ToCommentDto()).ToList()
            }; 
        }


    }
}