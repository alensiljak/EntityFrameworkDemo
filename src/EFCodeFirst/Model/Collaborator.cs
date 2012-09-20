﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCodeFirst.Model
{
    public class Collaborator : Person
    {
        public int CollaboratorId { get; set; }
        public string ManagerCode { get; set; }
        public virtual Manager Manager { get; set; }
    }
}
