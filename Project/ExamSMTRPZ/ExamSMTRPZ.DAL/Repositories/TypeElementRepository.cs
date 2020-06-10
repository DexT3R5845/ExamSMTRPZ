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
    class TypeElementRepository : IRepository<TypeElement>
    {
        private DatabaseContext db;
        public TypeElementRepository(DatabaseContext dbContext)
        {
            db = dbContext;
        }

        public IEnumerable<TypeElement> GetAll() => db.TypeElements;

        public TypeElement Get(int id) => db.TypeElements.Find(id);

        public void Create(TypeElement typeElement)
        {
            db.TypeElements.Add(typeElement);
        }

        public void Update(TypeElement typeElement)
        {
            db.Entry(typeElement).State = EntityState.Modified;
        }

        public IEnumerable<TypeElement> Find(Func<TypeElement, bool> predicate)
        {
            return db.TypeElements.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            TypeElement typeElement = db.TypeElements.Find(id);
            if (typeElement != null)
                db.TypeElements.Remove(typeElement);
        }
    }
}
