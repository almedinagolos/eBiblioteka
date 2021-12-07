﻿using eBiblioteka.Model.Requests;
using eBiblioteka.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Controllers
{
    public class BaseCRUDController<T, TSearch, TInsert, TUpdate> : BaseReadController<T, TSearch> where T : class where TSearch : BaseSearchRequest where TInsert : class where TUpdate : class
    {
        protected readonly ICRUDService<T, TSearch, TInsert, TUpdate> _crudService;
        public BaseCRUDController(ICRUDService<T, TSearch, TInsert, TUpdate> service) : base(service)
        {
            _crudService = service;
        }

        [HttpPost]
        public virtual T Insert([FromBody] TInsert request)
        {
            return _crudService.Insert(request);
        }

        [HttpPut("{id}")]
        public virtual T Update(int id, [FromBody] TUpdate request)
        {
            return _crudService.Update(id, request);
        }

        [HttpDelete("{id}")]
        public virtual T Delete(int id)
        {
            return _crudService.Delete(id);
        }
    }
}