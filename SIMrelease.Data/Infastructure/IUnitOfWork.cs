﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simrelease.Data.Infastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
