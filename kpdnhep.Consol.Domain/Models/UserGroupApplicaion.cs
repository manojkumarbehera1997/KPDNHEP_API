﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KPDNHEP.Console.Domain.Models
{
    public class UserGroupApplication
    {
        public int NewGroupId { get; set; }
        public int OldGroupId { get; set; }
        public int ApplicationId { get; set; }
    }
}
