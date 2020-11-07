using Hogwarts.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts.Application.Interfaces
{
    interface IApplicationAdmisionApplication
    {
        Task<bool> Add(ApplicationAdmision request);

        Task<bool> Update(ApplicationAdmision request);

        Task<List<ApplicationAdmision>> Get();

        Task<ApplicationAdmision> Get(Guid Id);

        Task<bool> Delete(Guid Id);
    }
}
