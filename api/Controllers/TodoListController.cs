using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/todolist")]
    [ApiController]
    public class TodoListController : ControllerBase
    {
        private readonly ITodoListRepository _listRepo;

        public TodoListController(ITodoListRepository listRepo)
        {
            _listRepo = listRepo;
        }
    }
}