using Registration.Repositories.Entities;

namespace Registration.API.Models
{
    public enum EHMO { Macabi, Clalit, Meuchedet, Leumit }
    public enum EGender { Male, Female }

    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }
        public DateTime DateBorn { get; set; }
        public EHMO HMO { get; set; }
        public EGender Gender { get; set; }
    }
}
