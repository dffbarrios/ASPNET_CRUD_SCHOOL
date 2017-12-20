using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace diegofernandobarrios18122017_HitssPruebaAsp.Net.Models
{
    public class diegofernandobarrios18122017_HitssPruebaAspNetContext :
        DbContext
    {
        public diegofernandobarrios18122017_HitssPruebaAspNetContext() 
            : base("name=diegofernandobarrios18122017_HitssPruebaAspNetContext")
        {
            Database.SetInitializer
                <diegofernandobarrios18122017_HitssPruebaAspNetContext>
                (
                    new DropCreateDatabaseIfModelChanges
                    <diegofernandobarrios18122017_HitssPruebaAspNetContext>()
                );
        }
        public DbSet<Matter> Matters { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<MatterStudent> MattersStudents { get; set; }
    }
}
