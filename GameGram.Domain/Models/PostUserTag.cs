﻿using GameGram.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGram.Domain.Models
{
    public class PostUserTag : BaseModel
    {
        public Guid? PostId { get; set; }

        public Guid? UserId { get; set; }

        public virtual Post Post { get; set; }

        public virtual User User { get; set; }
    }
}
