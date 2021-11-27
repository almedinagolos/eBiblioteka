﻿using eBiblioteka.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eBiblioteka.Model.Requests;

namespace eBiblioteka.Services
{
    public interface IBibliotekaService: ICRUDService<Biblioteka, BibliotekaSearchRequest, BibliotekaInsertRequest, BibliotekaInsertRequest>
    {
    }
}
