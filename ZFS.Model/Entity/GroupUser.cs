﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ZFS.Model.Entity
{
    public class GroupUser : BaseEntity
    {
        public string GroupCode { get; set; }

        public string Account { get; set; }
    }
}
