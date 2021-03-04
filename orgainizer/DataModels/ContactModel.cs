/// <summary>
/// Модель для представления таблицы Contact
/// </summary>
namespace orgainizer.DataModels
{
    public class ContactModel : IDataModel
    {
        public int ID { get; }
        public string Phone { get; }
        public string Surname { get; }
        public string Initials { get; }
        public string Email { get; }

        public ContactModel(int ID)
        {
            this.ID = ID;
        }

        public ContactModel(string Phone, string Surname, string Initials)
        {
            this.Phone = Phone;
            this.Surname = Surname;
            this.Initials = Initials;
            this.Email = "none";
        }

        public ContactModel(string Phone, string Surname, string Initials, string Email)
        {
            this.Phone = Phone;
            this.Surname = Surname;
            this.Initials = Initials;
            this.Email = Email;
        }

        public ContactModel(int ID, string Phone, string Surname, string Initials, string Email)
        {
            this.ID = ID;
            this.Phone = Phone;
            this.Surname = Surname;
            this.Initials = Initials;
            this.Email = Email;
        }
    }
}
