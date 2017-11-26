using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhoozatAPI.Entities
{
    public class Estate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estate()
        {
            //this.blocks = new HashSet<block>();
            //this.gates = new HashSet<gate>();
            //this.units = new HashSet<unit>();
        }

        public Guid Id { get; set; }
        public int idEstate { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string postalCode { get; set; }
        public string city { get; set; }
        public int idCountry { get; set; }
        public string phone { get; set; }
        public string photo { get; set; }
        public int unitsNumber { get; set; }
        public string state { get; set; }
        public Nullable<int> idUserEstate { get; set; }
        public System.DateTime creationDate { get; set; }
        public System.DateTime lastUpdate { get; set; }
        public sbyte active { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<block> blocks { get; set; }
        //public virtual country country { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<gate> gates { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<unit> units { get; set; }
        //public virtual userunit userunit { get; set; }
    }
}
