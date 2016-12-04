using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Mongo.NetCoreWebAPI.Models;
using Mongo.NetCoreWebAPI.Services;

namespace Mongo.NetCoreWebAPI.Controllers{
    private var mogoDbService = new MongoDBService("", "" ,"");
    [RouteAttribute("api/[controller]")]
    public class TodoController : Controller
    {
        [HttpGetAttribute]
        public async Task<JsonResult> Get()
        {
            var allTodos = await mogoDbService.GetAllTodos();
            return Json(allTodos);
        }

        [HttpPostAttribute]
        public async Task Post([FromBody]TodoModel todo)
        {
            await mogoDbService.InsertTodo(todo);
        }
    }

}