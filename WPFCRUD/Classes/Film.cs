using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCRUD.Classes
{
    [Serializable]
    public class Film
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Genre { get; set; }
        
        public float Duration { get; set; }

        public DateTime DateOfCreate { get; set; }
    }
}
