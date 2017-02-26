using FooLibrary;
using Xunit;

namespace FooTests
{
    public class FooTest
    {
        private readonly IFoo foo = new Foo();

        [Fact]
        public async void GetList()
        {
            var response = await foo.GetList(new GetListRequest {SearchText = "test"});
            Assert.Equal("test1", response.Items[0].Title);
            Assert.Equal("test2", response.Items[1].Title);
        }

        [Fact]
        public async void GetById()
        {
            var response = await foo.GetById(7);
            Assert.Equal("Title7", response.Item.Title);
        }

        [Fact]
        public async void Post()
        {
            var response = await foo.Post(new PostRequest {PostText = "test"});
            Assert.Equal("test_server", response.PostText);
        }

        [Fact]
        public async void Put()
        {
            var response = await foo.Put(11, new PutRequest {PutText = "test"});
            Assert.Equal("test_11", response.PutText);
        }

        [Fact]
        public async void Delete()
        {
            await foo.Delete(11);
        }
    }
}
