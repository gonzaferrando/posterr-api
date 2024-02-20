using System.Collections;

namespace Posterr.api.Data
{
    public class PagedList<T> : IReadOnlyList<T>
    {
        private readonly IList<T> Data;
        public PagedList(IEnumerable<T> items, int count, int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            Data = items as IList<T> ?? new List<T>(items);
        }
        public int PageNumber { get; }
        public int TotalPages { get; }
        public bool IsFirstPage => PageNumber == 1;
        public bool IsLastPage => PageNumber == TotalPages;
        public int Count => Data.Count;
        public T this[int index] => Data[index];
        public IEnumerator<T> GetEnumerator() => Data.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => Data.GetEnumerator();
    }
}
