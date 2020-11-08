using Hogwart.Repository.Interfaces;
using Hogwarts.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hogwarts.Service
{
    public class ApplicationAdmisionService : IApplicationAdmisionService
    {
        private readonly IApplicationAdmisionRepository _applicationAdmisionRepository;

        public ApplicationAdmisionService(IApplicationAdmisionRepository applicationAdmisionRepository)
        {
            _applicationAdmisionRepository = applicationAdmisionRepository;
        }

        public async Task<bool> Add(ApplicationAdmision request)
        {
            return await _applicationAdmisionRepository.Add(request);
        }

        public async Task<bool> Delete(int id)
        {
            return await _applicationAdmisionRepository.Delete(id);
        }

        public async Task<List<ApplicationAdmision>> Get()
        {
            return await _applicationAdmisionRepository.Get();
        }

        public async Task<ApplicationAdmision> Get(int id)
        {
            return await _applicationAdmisionRepository.Get(id);
        }

        public async Task<bool> Update(ApplicationAdmision request)
        {
            return await _applicationAdmisionRepository.Update(request);
        }
    }
}
