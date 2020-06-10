using ExamSMTRPZ.DAL.Entities;
using ExamSMTRPZ.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSMTRPZ.DAL.Repositories
{
    public class ElementRepository : IRepository<Element>
    {
        private DatabaseContext db;
        public ElementRepository(DatabaseContext dbContext)
        {
            db = dbContext;
        }

        public IEnumerable<Element> GetAll() => db.Elements;

        public Element Get(int id) => db.Elements.Find(id);

        public void Create(Element element)
        {
            db.Elements.Add(element);
        }

        public void Update(Element element)
        {
            db.Entry(element).State = EntityState.Modified;
        }

        public IEnumerable<Element> Find(Func<Element, bool> predicate)
        {
            return db.Elements.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Element element = db.Elements.Find(id);
            if (element != null)
                db.Elements.Remove(element);
        }
    }
}
