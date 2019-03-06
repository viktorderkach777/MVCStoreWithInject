using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.

namespace BusinessProjectLayer
{
    public class MyBll : IMyBll
    {
        private readonly IMyDal dal;// = new MyDal();

        public MyBll(IMyDal dal)
        {
            this.dal = dal;
        }

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
