using System.Threading.Tasks;

namespace FooLibrary
{
    public interface IFoo
    {
        Task<GetListResponse> GetList(GetListRequest request);
        Task<GetByIdResponse> GetById(int id);
        Task<PostResponse> Post(PostRequest request);
        Task<PutResponse> Put(int id, PutRequest request);
        Task Delete(int id);
    }
}