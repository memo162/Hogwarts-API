using Hogwarts.Application.Interfaces;
using Hogwarts.Models;
using Hogwarts.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts.Application
{
    public class ApplicationAdmisionApplication : IApplicationAdmisionApplication
    {
        private readonly IApplicationAdmisionService _applicationAdmisionService;

        public ApplicationAdmisionApplication(IApplicationAdmisionService applicationAdmisionService) 
        {
            _applicationAdmisionService = applicationAdmisionService;
        }

        public async Task<bool> Add(ApplicationAdmision request)
        {
            return await _applicationAdmisionService.Add(request);
        }

        public async Task<bool> Delete(int id)
        {
            return await _applicationAdmisionService.Delete(id);
        }

        public async Task<List<ApplicationAdmision>> Get()
        {
            return await _applicationAdmisionService.Get();
        }

        public async Task<ApplicationAdmision> Get(int id)
        {
            return await _applicationAdmisionService.Get(id);
        }

        public async Task<bool> Update(ApplicationAdmision request)
        {
            return await _applicationAdmisionService.Update(request);
        }
    }
}
