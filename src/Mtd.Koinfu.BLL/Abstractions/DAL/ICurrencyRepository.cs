﻿using Optional;
using System;
using System.Threading.Tasks;

namespace Mtd.Koinfu.BLL
{
    public interface ICurrencyRepository : IBaseRepository<Currency>
    {
        Task<Option<int>> GetIdAsync(Currency currency);
    }
}
