﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExamSMTRPZ.DAL.Entities
{
    public class Element : BaseElementDTO
    {
        public DateTime DateInstall { get; set; }
        public TypeElement TypeElement { get; set; }
        public int TypeElementId { get; set; }
    }
}
