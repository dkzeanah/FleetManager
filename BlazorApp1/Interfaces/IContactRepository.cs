using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    public interface IContactRepository
    {
    }

    // IUnitOfWork.cs file
    public interface IUnitOfWork
    {
        IContactRepository Contacts { get; }
    }
}
