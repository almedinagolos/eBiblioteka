using AutoMapper;
using eBiblioteka.Database;
using eBiblioteka.DB;
using eBiblioteka.Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Services
{
    public class TipClanarineService : BaseReadService<Model.TipClanarine, Database.TipClanarine, BaseSearchRequest>, ITipClanarineService
    {
        public TipClanarineService(MojDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

     
    }
}
