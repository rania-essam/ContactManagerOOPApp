

namespace ContactManagerApplication
{
    internal class Address
    {

        private string Description;

        public string city { set; get; }
        public string country { set; get; }
        public int zipcode { set; get; }
    
        public string type { set; get; }      // home , work , billing
      
        public string description { // take the string input and return it in multiple lines
            set
            {
                Description = value;
            }
            get
            {
               
                string[] strings = Description.Split(',');
                string concat = "";
                foreach (string s in strings) concat += s + "\n";  
                return concat;
            }
        } 


        public void Get_Address()
        {
            Console.WriteLine("========================= Data of the Address ============================== ");
            Console.WriteLine($" -  City : {city} \n- Country :{country} \n- zipcode :{zipcode}\n- type :{type} \n- Details of the Adrress :{description} ");
        }



    }
}
