using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hepsiSefBlog.Service.Model.Request;
using hepsiSefBlog.Service.Model.Response;
using hepsiSefBlog.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace hepsiSefBlog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly RecipeService _service;
        public RecipesController(RecipeService service)
        {
            _service = service;
        }
        //TODO: add /// comment to notice and give information to clients 
        //Get api/recipes/getall
        public List<RecipeResponse> GetAll()
        {
            return _service.GetAll();
        }

        //get api/recipes/2
        [HttpGet("{id}")]
        public RecipeResponse Query([FromRoute]int id)
        {
            return _service.Get(id);
        }
        
    }
}
