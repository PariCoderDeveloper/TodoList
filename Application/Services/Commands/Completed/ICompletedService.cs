﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Commands.Completed
{
    public interface ICompletedService
    {
        Task<bool> ExecuteAsync(long id);
    }
}
