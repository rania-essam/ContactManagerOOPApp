
using System.Net;

namespace ContactManagerApplication
{
   
    static internal class Contact
    {
        static List<User> users = new List<User>();
       
        static Dictionary<int, int> primary_k = new Dictionary<int, int>();
        // static Directory
        // add , edit and delete a user will be done using the primary key ---> user_id


        //{   functions for valdiations in input data  }
        static bool is_string_of_cahrs(string input)
        {
            foreach(char ch in input)
            {
                if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z' || ch==',' ||ch==' ') continue;
                else return false;
            }
            return true;
        }

        static bool is_string_of_digits(string input)
        {
            foreach (char ch in input)
            {
                if (ch >= '0' && ch <= '9') continue;
                else return false;
            }
            return true;
        }

        static public void add_user()
        {
            User user = new User(); // define new user 

            // 1 - ID
            #region ID
            Console.WriteLine("1 - ID : \n" +
           "Enter ID of the USer :");
            int id = 0;
            int.TryParse(Console.ReadLine(), out id);
            
            bool f = true;
            while (f)
            {
                try
                {
                    if (primary_k.ContainsKey(id) == false && id > 0)
                    {
                        user.id = id;
                        f = false;

                    }
                    else
                    {
                        throw new Exception("Not a valid data");
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.ToString());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("PLease enter new value :");
                    int.TryParse(Console.ReadLine(), out id);
                }
            }


            primary_k[id] = 1;


            Console.WriteLine("=====================================================================================================");
            #endregion


            #region NAME
            Console.WriteLine("Enter your First_Name :");
            bool flag = true;
            while (flag)
            {
                try
                {
                    string f_name = Console.ReadLine();
                    if (is_string_of_cahrs(f_name))
                    {
                        user.first_name = f_name;
                        flag = false; // break from loop
                    }
                    else
                    {
                        throw new Exception("NOT A VALID DATA ,  Please Enter New value ");
                    }

                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.ToString());
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }
            Console.WriteLine("Enter your Last_Name :");

            flag = true;
            while (flag)
            {
                try
                {
                    string l_name = Console.ReadLine();
                    if (is_string_of_cahrs(l_name))
                    {
                        user.last_name = l_name;
                        flag = false;
                    }
                    else
                    {
                        throw new Exception("NOT A VALID DATA ,  Please Enter New value");
                    }

                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.ToString());
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }

            Console.WriteLine("=====================================================================================================");

            #endregion
            // 2 - Genderr
            #region gender
            Console.WriteLine("2 - Gender : \n" +
          "Enter 1 if you are a male and 2 if you are a female ");
            flag = true;
            int choose_gender = 0;
            while (flag)
            {
                try
                {
                    int.TryParse(Console.ReadLine(), out int type);

                    if (type == 1 || type == 2)
                    {
                        choose_gender = type;
                        flag = false;
                    }
                    else
                    {
                        throw new Exception("Not a Valid Data ,  Please Enter New value");
                    }

                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.ToString());
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            if (choose_gender == 1) user.UserGender = User.Gender.male;
            else if (choose_gender == 2) user.UserGender = User.Gender.female;
           
            Console.WriteLine("=====================================================================================================");
            #endregion


            #region DATE
            // 3  - (DATE )  ----> RegistrationDate
            user.added_date = DateTime.Now;
            #endregion

            #region Address
            // 4 - ADDRESS ---> ( Address  of the User)
            Console.WriteLine("4 - Address : ");
            Console.WriteLine("Enter Number of Addresses you have :");
            flag = true;
            int counter = 0;
            while (flag)
            {
                try
                {
                    int.TryParse(Console.ReadLine(), out counter);
                    if (counter >= 1 && counter <= 100)
                    {
                        flag = false;
                    }
                    else
                    {
                        throw new Exception("Data is not valid , please Enter valid one ");
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.ToString());
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            int num = 1;
            while (counter > 0)
            {
                Console.WriteLine("=========================================================");

                Console.WriteLine($"Address number {num++} ");

                Address address = new Address(); // object of Address

                Console.WriteLine("Enter your City  :");
                flag = true;
                while (flag)
                {
                    try
                    {
                        string city = Console.ReadLine();
                        if (is_string_of_cahrs(city))
                        {
                            address.city = city;
                            flag = false;
                        }
                        else
                        {
                            throw new Exception("NOT a valid data  , Please Enter New value");
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.ToString());
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                //---------------------------------------------------------------------------------
                Console.WriteLine("Enter your Country: ");
                flag = true;
                while (flag)
                {
                    try
                    {
                        string country = Console.ReadLine();
                        if (is_string_of_cahrs(country))
                        {
                            address.country = country;
                            flag = false;
                        }
                        else
                        {
                            throw new Exception("NOT a valid data  , Please Enter New value");
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.ToString());
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                //----------------------------------------------------------------------------------------------
                Console.WriteLine("Enter type of the Address ");
                flag = true;
                while (flag)
                {
                    try
                    {
                        string type = Console.ReadLine();
                        if (is_string_of_cahrs(type))
                        {
                            address.type = type;
                            flag = false;
                        }
                        else
                        {
                            throw new Exception("NOT a valid data  , Please Enter New value");
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.ToString());
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                //---------------------------------------------------------------------------------------------
                Console.WriteLine("Enter ZIP_CODE OF YOUR COUNTRY ");
                int.TryParse(Console.ReadLine(), out int code);
                if(code > 0) address.zipcode = code;
                else
                {
                    Console.WriteLine("not a valid data , please valid value ");
                    address.zipcode = int.Parse(Console.ReadLine());
                }
                //----------------------------------------------------------------------------------------------

                Console.WriteLine("Please Enter your Address Description : ");
                flag = true;
                while (flag)
                {
                    try
                    {
                        string description = Console.ReadLine();
                        if (is_string_of_cahrs(description))
                        {
                            address.description = description;
                            flag = false;
                        }
                        else
                        {
                            throw new Exception("NOT a valid data  , Please Enter New value");
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.ToString());
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                counter--;
                user.ADdress.Add(address);
            }
           
            #endregion


            // 5  PHONE
            #region Phone
            Console.WriteLine("5 - Phone :");
            Console.WriteLine("Enter Number of phones you have : ");
            flag = true;
            counter = 0;
            while (flag)
            {
                try
                {
                    int.TryParse(Console.ReadLine(), out counter);
                    if (counter >=1 && counter <=100 )
                    {
                        flag = false;
                    }
                    else
                    {
                        throw new Exception("Data is not valid , please Enter valid one ");
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.ToString());
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            num = 1;
            while (counter > 0)
            {
                Console.WriteLine("=========================================================");
                Console.WriteLine($"phone number {num++} ");
                Phone phonee = new Phone();
                Console.WriteLine("Enter Your phone Number ");
                flag = true;
                while (flag)
                {
                    try
                    {
                        string phone = Console.ReadLine();
                        if (is_string_of_digits(phone))
                        {
                            phonee.phone = phone;
                            flag = false;
                        }
                        else
                        {
                            throw new Exception("NOT a valid data  , Please Enter New value");
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.ToString());
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.WriteLine("Enter the type of your phone ( Work_phone or  home phone or billing phone , personal phone ) : ");
                flag = true;
                while (flag)
                {
                    try
                    {
                        string phone_type = Console.ReadLine();
                        if (is_string_of_cahrs(phone_type))
                        {
                            phonee.type = phone_type;
                            flag = false;
                        }
                        else
                        {
                            throw new Exception("NOT a valid data  , Please Enter New value");
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.ToString());
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.WriteLine("Enter Details of your phone : ");
                flag = true;
                while (flag)
                {
                    try
                    {
                        string description = Console.ReadLine();
                        if (is_string_of_cahrs(description))
                        {
                            phonee.description = description;
                            flag = false;
                        }
                        else
                        {
                            throw new Exception("NOT a valid data  , Please Enter New value");
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.ToString());
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                user.PHone.Add(phonee);
                counter--; 
                #endregion
            }
            // 6  Email
            #region Email
            Console.WriteLine("6 - Email :");
            Console.WriteLine("Enter Number of Emails you have :");
            flag = true;
            counter = 0;
            while (flag)
            {
                try
                {
                    int.TryParse(Console.ReadLine(), out counter);
                    if (counter >= 1 && counter <= 100)
                    {
                        flag = false;
                    }
                    else
                    {
                        throw new Exception("Data is not valid , please Enter valid one ");
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.ToString());
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            num = 1;
            while (counter > 0)
            {
                Console.WriteLine("=========================================================");

                Console.WriteLine($"Email number {num++}");
                Email emaill = new Email();
                Console.WriteLine("Enter Your Email");
                flag = true;
                while (flag)
                {
                    try
                    {
                        string email = Console.ReadLine();
                        bool valid = true;
                        foreach(char ch in email)
                        {
                            if ((ch >= '0' && ch <= '9') || (ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z') || ch == '@' || ch=='.') continue;
                            else valid = false;
                        }
                        if ( valid )
                        {
                            emaill.email = email;
                            flag = false;
                        }
                        else
                        {
                            throw new Exception("NOT a valid data  , Please Enter New value");
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.ToString());
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.WriteLine("Enter the type of your Email ( Work_Email or  School_email or Personal_Email ) : ");
                flag = true;
                while (flag)
                {
                    try
                    {
                        string type = Console.ReadLine();
                        if (is_string_of_cahrs(type))
                        {
                            emaill.type = type;
                            flag = false;
                        }
                        else
                        {
                            throw new Exception("NOT a valid data  , Please Enter New value");
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.ToString());
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.WriteLine("Enter Details of your Email ( what this email will be used for ) ");
                flag = true;
                while (flag)
                {
                    try
                    {
                        string description = Console.ReadLine();
                        if (is_string_of_cahrs(description))
                        {
                            emaill.description = description;
                            flag = false;
                        }
                        else
                        {
                            throw new Exception("NOT a valid data  , Please Enter New value");
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.ToString());
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                user.EMail.Add(emaill);
                counter--;
            } 
            #endregion

            users.Add(user);
            Console.WriteLine(users.Count());
        }
        #region Delete
        static public void delete_user()
        {
            Console.WriteLine("=====================================================================================================");

            Console.WriteLine("Enter ID of the user that you want to delete : ");
            int id;
            int.TryParse(Console.ReadLine(), out id);
            foreach (User user in users)
            {
                if (user.id == id)
                {
                    users.Remove(user);
                    primary_k.Remove(id);
                    break;
                }
            }
        }

        #endregion
        // print data of all users 
        static int c = 1;
        #region all users
        public static void print_data_of_all_users()
        {
          
            foreach (User user in users)
            {
                Console.WriteLine("========================================================================");

                Console.WriteLine($"Data of User {c++}");
                user.Display_User_Information();
                

            }
        } 
        #endregion



    }
}
