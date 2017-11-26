using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhoozatAPI.Dtos
{
    public class EstateDto
    {
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
    }
}
