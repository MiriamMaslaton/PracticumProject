using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Registration.Repositories.Entities
{
    public enum EHMO { Macabi, Clalit, Meuchedet, Leumit }
    public enum EGender { Male, Female}

    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public DateTime DateBorn { get; set; }
        public EHMO HMO { get; set; }
        public EGender Gender { get; set; }
        public List<Child> children  { get; set; }



}
}
