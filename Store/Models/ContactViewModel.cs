using BusinessProjectLayer;
using System.Collections.Generic;

namespace Store.Models
{
    public class ContactViewModel
    {
        public string ConcreteMark { get; set; }

        public IEnumerable<CountryBll> Countries { get; set; }
    }
}