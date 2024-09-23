

namespace ContactManagerApplication
{
    internal class Phone
    {

        private string Description;

  
        public string phone { get; set; }
        public string type { set; get; }      // home , work , billing
        
        public string description
        { // take the string input and return it in multiple lines
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


        public void Get_Phone()
        {
            Console.WriteLine("========================= Data of the Phone ============================== ");
            Console.WriteLine($"Phone :{phone} \ntype :{type} \n Details of the Phone :{description} ");
        }


    }
}
