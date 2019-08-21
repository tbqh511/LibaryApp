using System;

namespace LibraryApp.Books.DTO
{
    public class GetBookOutput
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public System.Nullable<int> TotalPageNumber { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
    }
}
