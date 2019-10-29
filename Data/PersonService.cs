using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class PersonService
    {
        public void Delete(int id)
        {
            using (StoreDbContext db=new StoreDbContext())
            {
                var entity = db.People.Where(x => x.Id == id).FirstOrDefault();

                entity.DeletedAt = DateTime.Now;
                entity.IsDeleted = true;
                db.SaveChanges();

            }
        }
    }
}
