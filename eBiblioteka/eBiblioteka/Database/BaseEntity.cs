using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace eBiblioteka.Database
{
    public class BaseEntity
    {
        [DefaultValue(true)]
        public bool Aktivan { get; set; } = true;
    }
}
