using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compito_18_02.Models
{
    public class CV
    {
        public InformazioniPersonali InformazioniPersonali { get; set; } = new InformazioniPersonali();
        public List<Studi> StudiEffettuati { get; set; } = new List<Studi>();
        public List<Esperienza> Impieghi { get; set; } = new List<Esperienza>();
    }
}
