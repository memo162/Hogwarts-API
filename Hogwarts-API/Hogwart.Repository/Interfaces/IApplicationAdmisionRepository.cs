using Hogwarts.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hogwart.Repository.Interfaces
{
    public interface IApplicationAdmisionRepository
    {
        Task<bool> Add(ApplicationAdmision request);

        Task<bool> Update(ApplicationAdmision request);

        Task<List<ApplicationAdmision>> Get();

        Task<ApplicationAdmision> Get(int id);

        Task<bool> Delete(int id);
    }
}
