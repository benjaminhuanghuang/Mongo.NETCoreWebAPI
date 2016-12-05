using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Mongo.NetCoreWebAPI.Models;
using Mongo.NetCoreWebAPI.Services;

namespace Mongo.NetCoreWebAPI.Controllers
{
    [RouteAttribute("api/[controller]")]
    public class TodosController : Controller
    {
        private MongoDBService mogoDbService = new MongoDBService("mongodb://user:user123@ds119618.mlab.com:19618/db_todo", "db_todo", "todos");

        [HttpGet]
        public async Task<JsonResult> Get()
        {
            var allTodos = await mogoDbService.GetAllTodos();
            return Json(allTodos);
        }

        [HttpPost]
        public async Task Post([FromBody]TodoModel todo)
        {
            // To force Web API to read a simple type from the request body, 
            // add the [FromBody] attribute to the parameter
            await mogoDbService.InsertTodo(todo);
        }
    }

}