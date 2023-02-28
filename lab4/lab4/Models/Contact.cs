namespace lab4.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        // other contact attributes as needed

        public void Save()
        {
            // save the contact to the database or data store
        }
    }
}
