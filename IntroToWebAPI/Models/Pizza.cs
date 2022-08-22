namespace IntroToWebAPI.Models
{
    public class Pizza
    {   
        // models are mostly going to be properties
        // contain data so we can do something with it
        public int Id { get; set; }
        public string Size { get; set; }  
        public List<string> Toppings { get; set; }
        public string CrustType { get; set; }
        public string Extras { get; set; } 

    }
}
