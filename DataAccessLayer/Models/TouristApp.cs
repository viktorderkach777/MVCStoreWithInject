namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TouristApp : DbContext
    {
       public TouristApp()
            : base("name=TouristApp")
        {
            Database.SetInitializer<TouristApp>(new CustomInitializer<TouristApp>());
        }    
       
        public virtual DbSet<DALPlace> DALPlaces { get; set; }
    }
}