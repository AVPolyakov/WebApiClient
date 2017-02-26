using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FooLibrary
{
    public class Foo : IFoo
    {
        public Task<GetListResponse> GetList(GetListRequest request)
        {
            return Task.FromResult(new GetListResponse {
                Items = new List<Item> {
                    new Item {
                        Title = $"{request.SearchText}1",
                        Date = DateTime.Now
                    },
                    new Item {
                        Title = $"{request.SearchText}2",
                        Date = DateTime.Now
                    },
                }
            });
        }

        public Task<GetByIdResponse> GetById(int id)
        {
            return Task.FromResult(new GetByIdResponse {
                Item = new Item {
                    Title = $"Title{id}",
                    Date = DateTime.Now
                }
            });
        }

        public Task<PostResponse> Post(PostRequest request)
        {
            return Task.FromResult(new PostResponse {
                PostText = $"{request.PostText}_server"
            });
        }

        public Task<PutResponse> Put(int id, PutRequest request)
        {
            return Task.FromResult(new PutResponse {
                PutText = $"{request.PutText}_{id}"
            });
        }

        public Task Delete(int id)
        {
            return Task.CompletedTask;
        }
    }
}