

namespace ContactManagerApplication
{
    internal class Email
    {

        private string Description;  // Backing field 

       


        public string email { get; set; }

        public string type { set; get; }    
        public string description
        { // take the string input and return it in multiple lines , split it by ','
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


        public void Get_Email()
        {
            Console.WriteLine("========================= Data of the Email ============================== ");

            Console.WriteLine($"- Enail :{email} \n- type :{type} \n- Details of the Email:{description} ");
        }
    }
}
