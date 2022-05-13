﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dotflix.Models.Contracts.Services
{
    public interface ILanguageService
    {
        Task<IEnumerable<Language>> GetAllAsync();
        Task<Language> GetByIdAsync(Guid id);
        Task<bool> AddAsync(Language language);
        Task<bool> UpdateAsync(Language language);
        Task<bool> DeleteId(Guid id);
    }
}
