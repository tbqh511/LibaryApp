using System;

namespace LibraryApp.Authors.DTO
{
    public class CreateAuthorInput
    {
        public string DisplayName { get; set; }
        public DateTime CreatioinTime { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }
    }
}
