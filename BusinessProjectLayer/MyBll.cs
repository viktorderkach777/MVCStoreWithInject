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
        private readonly IMyDal dal;

        public MyBll(IMyDal dal)
        {
            this.dal = dal;
        }
       

        public ICollection<PlaceBll> GetDBPlacesByAllParams(string icon, string openTime, string closeTime, string rate)
        {
            return dal.GetDBPlacesByAllParams(icon, openTime, closeTime, rate)
               .Select(c => new PlaceBll
               {
                   Id = c.Id,
                   Name = c.Name,
                   LinkRef = c.LinkRef,
                   LinkText = c.LinkText,
                   AboutPlace = c.AboutPlace,
                   OpenTime = c.OpenTime,
                   CloseTime = c.CloseTime,
                   Rate = c.Rate,
                   Icon = c.Icon,
                   Longitude = c.Longitude,
                   Latitude= c.Latitude
                   
               }).ToList();
        }
    }
}
