using System.Collections.Generic;

namespace BusinessProjectLayer
{
    public class CountryBll
    {       

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<int> ProducersId { get; set; }
    }
}