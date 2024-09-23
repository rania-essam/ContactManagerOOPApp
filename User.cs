

namespace ContactManagerApplication
{
    internal class User
    {
        public int id;
        public string first_name;
        public string last_name;
        public enum Gender
        {
            male = 1  , female = 2
        }
        public Gender UserGender { get; set; }
        public DateTime added_date;


        // generic list 
        public List<Address> ADdress = new List<Address>();
        public List<Phone> PHone = new List<Phone>();
        public List<Email> EMail = new List<Email>();


        public bool search(string query)
        {
            string find = query.ToLower();

            if (
                id.ToString().ToLower().Contains(find) || first_name.ToLower().Contains(find)
                || last_name.ToLower().Contains(find) || ((int)Gender.male).ToString().ToLower().Contains(find) ||
                ((int)Gender.female).ToString().ToLower().Contains(find) 
                || added_date.ToString().ToLower().Contains(find)
               ) return true;

            foreach (Address address in ADdress)
            {
                if (address.city.ToLower().Contains(find) || address.country.ToLower().Contains(find) || address.description.ToLower().Contains(find)
                    || address.zipcode.ToString().ToLower().Contains(find) ||
                     address.type.ToLower().Contains(find)) return true;
            }
            foreach (Phone phone in PHone)
            {
                if (phone.type.ToLower().Contains(find) || phone.phone.ToLower().Contains(find) || phone.description.ToLower().Contains(find)) return true;
            }
           foreach(Email email in EMail)
           {
                if (email.email.ToLower().Contains(find) || email.description.ToLower().Contains(find) || email.type.ToLower().Contains(find)) return true;
           }

           // no matches found
           return false;


        }


        // add new value
        public void add_phone(Phone phone)
        {
            PHone.Add(phone);
        }
        public void add_email(Email email)
        {
            EMail.Add(email);
        }
        public void add_address(Address address)
        {
             ADdress.Add(address);
        }
        // replace a value at specific index 
        public void edit_phone(int target_index, Phone phone)
        {
            PHone[target_index] = phone;
        }
        public void edit_email(int target_index, Email email)
        {
            EMail[target_index] = email;
        }
        public void edit_Address(int target_index, Address address)
        {
            ADdress[target_index] = address;
        }
        // removes a value at specific index 
        public void delete_phone(int target_index, Phone phone)
        {
            PHone.RemoveAt(target_index);
        }
        public void delete_email(int target_index,Email email)
        {
            EMail.RemoveAt(target_index);
        }
        public void delete_address(int target_index,Address address)
        {
            ADdress.RemoveAt(target_index);
        }

        //=================================================
        // print all Data of the user

        public void Display_User_Information()
        {
            Console.WriteLine("visited ");
            Console.WriteLine($"1 - id : {id} \n2 - Full_Name : {first_name} {last_name}\n3 - Gender : {((int)Gender.female == 1 ? "Female" : "male")} ");
            // print list of addresses for the user
            foreach (Address address in ADdress) address.Get_Address();
            //print list of emails for the user
            foreach (Email email in EMail) email.Get_Email();
            //print list of phones for the user
            foreach (Phone phone in PHone) phone.Get_Phone();

        }

    }
}
