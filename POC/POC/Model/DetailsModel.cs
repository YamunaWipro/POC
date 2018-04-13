namespace POC
{
    public class DetailsModel
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string Image { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string NameSort => Name[0].ToString();
    }
}

