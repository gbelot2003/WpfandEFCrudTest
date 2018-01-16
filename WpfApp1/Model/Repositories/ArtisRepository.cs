using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model.Repositories
{
    class ArtisRepository : Repository<Artis>
    {
        public void Update(Artis obj)
        {
            Artis record = new Artis();
            record = Get(obj.ArtistID);
            record.Name = obj.Name;
        }
    }
}
