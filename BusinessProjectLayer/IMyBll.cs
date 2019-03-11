using System.Collections.Generic;

namespace BusinessProjectLayer
{
    public interface IMyBll
    {
        ICollection<PlaceBll> GetDBPlacesByAllParams(string icon, string openTime, string closeTime, string rate);
    }
}