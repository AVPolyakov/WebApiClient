using System.Threading.Tasks;
using FooLibrary;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    public class FooController : Controller
    {
        private readonly IFoo foo = new Foo();

        [HttpGet]
        public Task<GetListResponse> GetList([FromQuery] GetListRequest request) => foo.GetList(request);

        [HttpGet("{id}")]
        public Task<GetByIdResponse> GetById(int id) => foo.GetById(id);

        [HttpPost]
        public Task<PostResponse> Post([FromBody] PostRequest request) => foo.Post(request);

        [HttpPut("{id}")]
        public Task<PutResponse> Put(int id, [FromBody] PutRequest request) => foo.Put(id, request);

        [HttpDelete("{id}")]
        public Task Delete(int id) => foo.Delete(id);
    }
}
