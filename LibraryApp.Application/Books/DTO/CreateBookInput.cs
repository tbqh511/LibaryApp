using System;

namespace LibraryApp.Books.DTO
{
    public class CreateBookInput
    {
        public string DisplayName { get; set; }
        public System.Nullable<int> TotalPageNumber { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
    }
}
