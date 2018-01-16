using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public partial class Artis : IDisposable
    {
        [Key] public int ArtistID { get; set; }

        [Required()]
        [StringLength(100, MinimumLength = 2)]
        public String Name { get; set; }

        [Required()]
        [StringLength(100, MinimumLength = 2)]
        public String LastName { get; set; }

        [Required()]
        public int Age { get; set; }

        public virtual List<Album> Albums { get; set; }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
