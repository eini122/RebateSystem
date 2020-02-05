using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asg2_kxl180016
{
   
    class DTO
    {
        private string firstName;
        private char middleName;
        private string lastName;
        private AddressDTO address = new AddressDTO();
        private string gender;
        private string phone;
        private string email;
        private bool proof;
        private string data;
        private DateTime start;
        private DateTime end;
        private int backCount;

        public DTO() { }

        public DTO(string firstName, char middleName, string lastName, AddressDTO address, string gender, string phone, string email, bool proof, string data)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Address = address;
            this.Gender = gender;
            this.Phone = phone;
            this.Email = email;
            this.Proof = proof;
            this.Data = data;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public char MiddleName { get => middleName; set => middleName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public bool Proof { get => proof; set => proof = value; }
        public string Data { get => data; set => data = value; }
        public DateTime Start { get => start; set => start = value; }
        public DateTime End { get => end; set => end = value; }
        public int BackCount { get => backCount; set => backCount = value; }
        internal AddressDTO Address { get => address; set => address = value; }
    }
}
