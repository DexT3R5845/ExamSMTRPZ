using System;
using System.Collections.Generic;
using System.Text;

namespace ExamSMTRPZ.DAL.Entities
{
    public class BaseElement
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public DateTime LifeTime { get; set; }
        public int PriceService { get; set; }
    }
}
