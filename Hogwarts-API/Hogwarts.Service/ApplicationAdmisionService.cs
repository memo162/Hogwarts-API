using Hogwarts.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hogwarts.Service
{
    public class ApplicationAdmisionService : IApplicationAdmisionService
    {
        private readonly IApplicationAdmisionService _howgartApplicationAdmisionServie;

        public ApplicationAdmisionService(IApplicationAdmisionService applicationAdmisionService) 
        {
            _howgartApplicationAdmisionServie = applicationAdmisionService;
        }

        public async Task<bool> Add(ApplicationAdmision request)
        {
            return await _howgartApplicationAdmisionServie.Add(request);
        }

        public async Task<bool> Delete(Guid Id)
        {
            return await _howgartApplicationAdmisionServie.Delete(Id);
        }

        public async Task<List<ApplicationAdmision>> Get()
        {
            return await _howgartApplicationAdmisionServie.Get();
        }

        public async Task<ApplicationAdmision> Get(Guid Id)
        {
            return await _howgartApplicationAdmisionServie.Get(Id);
        }

        public async Task<bool> Update(ApplicationAdmision request)
        {
            return await _howgartApplicationAdmisionServie.Update(request);
        }
    }
}
