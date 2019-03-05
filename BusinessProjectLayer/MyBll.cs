using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.

namespace BusinessProjectLayer
{
    public class MyBll
    {
        private readonly MyDal dal = new MyDal();

        public int GetProducersCountByConcreteMark(string concreteMark)
        {
            return dal.GetProcersCountByConcreteMark(concreteMark);
        }

        public ICollection<CountryBll> GetCountriesByConcreteMark(string concreteMark)
        {
            return dal.GetCountriesByConcreteMark(concreteMark)
                .Select(c => new CountryBll
                {
                    Id = c.Id,
                    Name = c.Name,
                    ProducersId = c.Producers.Select(p => p.Id).ToList()
                }).ToList();
           
        }
    }
}
