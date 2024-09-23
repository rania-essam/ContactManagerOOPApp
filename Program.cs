using System.Xml.Serialization;

namespace ContactManagerApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Contact.add_user();

            Contact.print_data_of_all_users();

            Contact.delete_user();

            Contact.add_user();

            Contact.print_data_of_all_users();

        }
    }
}
