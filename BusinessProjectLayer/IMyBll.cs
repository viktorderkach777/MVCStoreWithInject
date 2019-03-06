using System.Collections.Generic;

namespace BusinessProjectLayer
{
    public interface IMyBll
    {
        ICollection<CountryBll> GetCountriesByConcreteMark(string concreteMark);
        int GetProducersCountByConcreteMark(string concreteMark);
    }
}