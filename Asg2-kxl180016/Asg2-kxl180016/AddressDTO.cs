using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asg2_kxl180016
{
    class AddressDTO
    {
        private string streetName;
        private string apartemntName;
        private string city;
        private String state;
        private String postCode;

        public AddressDTO() {         }
        public AddressDTO(string streetName, string apartemntName, string city, string state, string postCode)
        {
            this.StreetName = streetName;
            this.ApartemntName = apartemntName;
            this.City = city;
            this.State = state;
            this.PostCode = postCode;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(streetName).Append(",");
            sb.Append(string.IsNullOrEmpty(apartemntName) ? "" : apartemntName).Append(",");
            sb.Append(city).Append(",").Append(state).Append(",").Append(postCode);
            return sb.ToString();
        }

        public string StreetName { get => streetName; set => streetName = value; }
        public string ApartemntName { get => apartemntName; set => apartemntName = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string PostCode { get => postCode; set => postCode = value; }
    }

}
