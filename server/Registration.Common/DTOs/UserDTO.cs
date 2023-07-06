using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Common.DTOs
{
    public enum EHMODTO { Macabi, Clalit, Meuchedet, Leumit }
    public enum EGenderDTO { Male, Female }

    public class UserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public DateTime DateBorn { get; set; }
        public EHMODTO HMO { get; set; }
        public EGenderDTO Gender { get; set; }
    }
}
