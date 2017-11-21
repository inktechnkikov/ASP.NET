namespace AspIntroduction.DataDB
{
    using AspIntroduction.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StoreContext : DbContext
    {
       
        public StoreContext()
            : base("name=StoreContext")
        {
        }
        public IDbSet<User> Users { get; set; }

        public IDbSet<Game> Games { get; set; }
    }

   
}