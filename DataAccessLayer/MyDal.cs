using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class MyDal : IMyDal
    {
        private readonly DbContext ctx;// = new ConcreteMarket();

        public MyDal(DbContext ctx)
        {
            this.ctx = ctx;
        }

        public int GetProcersCountByConcreteMark(string concreteMark)
        {
            return ctx.Set<Concrete>()
                .Where(c => c.Mark == concreteMark)
                .Select(p => p.Producer)
                .Distinct()
                .Count();
        }

        public ICollection<Country> GetCountriesByConcreteMark(string concreteMark)
        {
            return ctx.Set<Concrete>()
                .Where(c => c.Mark == concreteMark)
                .Select(p => p.Producer.Country)
                .Distinct()
               .ToList();
        }
    }
}
