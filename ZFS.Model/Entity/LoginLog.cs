﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZFS.Model.Entity
{
    public class LoginLog : BaseEntity
    {
        public string Account { get; set; }

        public DateTime CurrentTime { get; set; }
    }
}
