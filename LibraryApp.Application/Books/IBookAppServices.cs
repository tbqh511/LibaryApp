﻿using Abp.Application.Services;
using LibraryApp.Books.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Books
{
    public interface IBookAppServices: IApplicationService
    {
        IEnumerable<GetBookOutput> ListAll();
        Task Create(CreateBookInput input);
        void Update(UpdateBookInput input);
        void Delete(DeleteBookInput input);
        GetBookOutput GetBookById(GetBookInput input);
    }
}
