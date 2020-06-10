using ExamSMTRPZ.DAL.Entities;
using ExamSMTRPZ.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSMTRPZ.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private DatabaseContext db;
        private TypeNatureElementRepository TypeNatureElementRepository;
        private ElementRepository ElementRepository;
        private NatureElementRepository NatureElementRepository;
        private TypeElementRepository TypeElementRepository;

        public EFUnitOfWork()
        {
            db = new DatabaseContext("Server=(localdb)\\mssqllocaldb;Database=cinemasdbstore;Trusted_Connection=True;");
        }

        public IRepository<TypeNatureElement> TypeNatureElements
        {
            get
            {
                if (TypeNatureElementRepository == null)
                    TypeNatureElementRepository = new TypeNatureElementRepository(db);
                return TypeNatureElementRepository;
            }
        }

        public IRepository<Element> Elements
        {
            get
            {
                if (ElementRepository == null)
                    ElementRepository = new ElementRepository(db);
                return ElementRepository;
            }
        }
        
        public IRepository<NatureElement> NatureElements
        {
            get
            {
                if (NatureElementRepository == null)
                    NatureElementRepository = new NatureElementRepository(db);
                return NatureElementRepository;
            }
        }

        public IRepository<TypeElement> TypeElements
        {
            get
            {
                if (TypeElementRepository == null)
                    TypeElementRepository = new TypeElementRepository(db);
                return TypeElementRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
