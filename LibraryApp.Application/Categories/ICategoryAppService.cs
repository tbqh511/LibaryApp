﻿using Abp.Application.Services;
using LibraryApp.Categories.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryApp.Categories
{
    public interface ICategoryAppService : IApplicationService
    {
        IEnumerable<GetCategoryOutput> ListAll();
        Task Create(CreateCategoryInput input);
        void Update(UpdateCategoryInput input);
        void Delete(DeleteCategoryInput input);
        GetCategoryOutput GetCategoryById(GetCategoryInput input);
    }
}
