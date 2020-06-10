using ExamSMTRPZ.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSMTRPZ.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Element> Elements{ get; }
        IRepository<NatureElement> NatureElements { get; }
        IRepository<TypeElement> TypeElements { get; }
        IRepository<TypeNatureElement> TypeNatureElements { get; }
        void Save();
    }
}
