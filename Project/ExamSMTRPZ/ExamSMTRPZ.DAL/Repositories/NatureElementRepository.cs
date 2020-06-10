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
    public class NatureElementRepository : IRepository<NatureElement>
    {
        private DatabaseContext db;
        public NatureElementRepository(DatabaseContext dbContext)
        {
            db = dbContext;
        }

        public IEnumerable<NatureElement> GetAll() => db.NatureElements;

        public NatureElement Get(int id) => db.NatureElements.Find(id);

        public void Create(NatureElement movie)
        {
            db.NatureElements.Add(movie);
        }

        public void Update(NatureElement natureElement)
        {
            db.Entry(natureElement).State = EntityState.Modified;
        }

        public IEnumerable<NatureElement> Find(Func<NatureElement, bool> predicate)
        {
            return db.NatureElements.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            NatureElement natureElement = db.NatureElements.Find(id);
            if (natureElement != null)
                db.NatureElements.Remove(natureElement);
        }
    }
}
