﻿using System.Collections.Generic;
using WU18.KingPim.Data.Models;

namespace WU18.KingPim.Entities.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}