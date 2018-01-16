using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model.Repositories
{
    class ArtisRepository : Repository<Artis>
    {
        public Artis Update(Artis obj)
        {
            Artis record = new Artis();
            record = Get(obj.ArtistID);
            record.Name = obj.Name;
            record.LastName = obj.LastName;
            record.Age = obj.Age;
            SaveChanges();
            return record;
        }
    }
}
