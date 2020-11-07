using Hogwart.Repository.Interfaces;
using Hogwarts.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hogwart.Repository
{
    public class ApplicationAdmisionRepository : IApplicationAdmisionRepository
    {
        public Task<bool> Add(ApplicationAdmision request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ApplicationAdmision>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationAdmision> Get(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(ApplicationAdmision request)
        {
            throw new NotImplementedException();
        }
    }
}
