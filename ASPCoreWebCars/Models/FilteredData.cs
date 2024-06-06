namespace ASPCoreWebCars.Models
{
    public class FilteredData
    {
        //Only the data we will use in the "view"
        public string numberPlate { get; set; } = "unset";
        public string make { get; set; } = "unset";
        public string model { get; set; } = "unset";
        public string EngineSize { get; set; } = "unset";
        public string topSpeed { get; set; } = "unset";
        public string yearlyTax { get; set; } = "unset";
        public string noOfKeepers { get; set; } = "unset";
        public string fuelType { get; set; } = "unset";
        public string transmission { get; set; } = "unset";
        public string kerbWeight { get; set; } = "unset";

        public string colour { get; set; } = "unset";
        public string carImage { get; set; } = "unset";  //Comes from a separate call managed by a separate function.
    }
}
