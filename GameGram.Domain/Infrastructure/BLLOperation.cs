﻿using GameGram.Domain.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGram.Domain.Infrastructure
{
    public class BLLOperation<T>
    {
        public T Item { get; set; }

        public string Message { get; set; }

        public OperationStatus Status { get; set; }
    }
}
