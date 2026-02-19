using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos;
using api.Mappers;
using api.Models;
using Microsoft.AspNetCore.Components.Web;

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

        public static TodoItem ToItemFromCreateDto(this CreateItemRequestDto itemDto)
        {
            return new TodoItem
            {
                Title = itemDto.Title,
                Description = itemDto.Description,
                IsCompleted = itemDto.IsCompleted,
                TodoListId = itemDto.TodoListId,
                TodoList = itemDto.TodoList,
            };
        }


    }
}