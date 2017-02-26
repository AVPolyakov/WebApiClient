using System;
using System.Collections.Generic;

namespace FooLibrary
{
    public class GetListRequest
    {
        public string SearchText { get; set; }
    }

    public class GetListResponse
    {
        public List<Item> Items { get; set; }
    }

    public class Item
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
    }

    public class GetByIdResponse
    {
        public Item Item { get; set; }
    }

    public class PostRequest
    {
        public string PostText { get; set; }
    }

    public class PostResponse
    {
        public string PostText { get; set; }
    }

    public class PutRequest
    {
        public object PutText { get; set; }
    }

    public class PutResponse
    {
        public string PutText { get; set; }
    }
}