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
    public class TypeNatureElementRepository : IRepository<TypeNatureElement>
    {
        private DatabaseContext db;
        public TypeNatureElementRepository(DatabaseContext dbContext)
        {
            db = dbContext;
        }

        public IEnumerable<TypeNatureElement> GetAll() => db.TypeNatureElements;

        public TypeNatureElement Get(int id) => db.TypeNatureElements.Find(id);

        public void Create(TypeNatureElement typeNatureElement)
        {
            db.TypeNatureElements.Add(typeNatureElement);
        }

        public void Update(TypeNatureElement typeNatureElement)
        {
            db.Entry(typeNatureElement).State = EntityState.Modified;
        }

        public IEnumerable<TypeNatureElement> Find(Func<TypeNatureElement, bool> predicate)
        {
            return db.TypeNatureElements.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            TypeNatureElement typeNatureElement = db.TypeNatureElements.Find(id);
            if (typeNatureElement != null)
                db.TypeNatureElements.Remove(typeNatureElement);
        }
    }
}
