using System;
using System.Collections.Generic;
using System.Text;

namespace ExamSMTRPZ.DAL.Entities
{
    public class NatureElement
    {
        public DateTime DateLanding { get; set; }
        public TypeNatureElement TypeElement { get; set; }
        public int TypeNatureElementId { get; set; }
    }
}
