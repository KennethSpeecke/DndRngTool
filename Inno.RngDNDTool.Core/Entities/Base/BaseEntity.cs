﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.Entities.Base
{
    public class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
    }
}