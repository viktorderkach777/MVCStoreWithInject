using System.Collections.Generic;

namespace DataAccessLayer
{
    public interface IMyDal
    {
        ICollection<DALPlace> GetDBPlacesByAllParams(string icon, string openTime, string closeTime, string rate);
    }
}