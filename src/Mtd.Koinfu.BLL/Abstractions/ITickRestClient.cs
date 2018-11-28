﻿using Optional;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mtd.Koinfu.BLL
{
    public interface ITickRestClient
    {
        Task<Option<Tick>> GetTickAsync(CancellationToken token);
    }
}
