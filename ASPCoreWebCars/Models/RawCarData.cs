namespace ASPCoreWebCars.Models
{
    public class RawCarData
    {


        public class Rootobject
        {
            public Billingaccount BillingAccount { get; set; }
            public Technicalsupport TechnicalSupport { get; set; }
            public Request Request { get; set; }
            public Response Response { get; set; }
        }

        public class Billingaccount
        {
            public string AccountType { get; set; }
            public float AccountBalance { get; set; }
            public float TransactionCost { get; set; }
            public Extrainformation ExtraInformation { get; set; }
        }

        public class Extrainformation
        {
        }

        public class Technicalsupport
        {
            public string ServerId { get; set; }
            public string RequestId { get; set; }
            public int QueryDurationMs { get; set; }
            public string SupportDate { get; set; }
            public string SupportTime { get; set; }
            public string SupportCode { get; set; }
            public string[] SupportInformationList { get; set; }
        }

        public class Request
        {
            public string RequestGuid { get; set; }
            public string PackageId { get; set; }
            public int PackageVersion { get; set; }
            public int ResponseVersion { get; set; }
            public Datakeys DataKeys { get; set; }
        }

        public class Datakeys
        {
            public string Vrm { get; set; }
        }

        public class Response
        {
            public string StatusCode { get; set; }
            public string StatusMessage { get; set; }
            public Statusinformation StatusInformation { get; set; }
            public Dataitems DataItems { get; set; }
        }

        public class Statusinformation
        {
            public Lookup Lookup { get; set; }
        }

        public class Lookup
        {
            public string StatusCode { get; set; }
            public string StatusMessage { get; set; }
            public object[] AdviceTextList { get; set; }
        }

        public class Dataitems
        {
            public Ukvdenhanceddata UkvdEnhancedData { get; set; }
            public Technicaldetails TechnicalDetails { get; set; }
            public Classificationdetails ClassificationDetails { get; set; }
            public Vehiclestatus VehicleStatus { get; set; }
            public Vehiclehistory VehicleHistory { get; set; }
            public Vehicleregistration VehicleRegistration { get; set; }
            public Smmtdetails SmmtDetails { get; set; }
        }

        public class Ukvdenhanceddata
        {
            public object ElectricVehicleData { get; set; }
            public Identification Identification { get; set; }
        }

        public class Identification
        {
            public bool IsElectricVehicle { get; set; }
        }

        public class Technicaldetails
        {
            public Dimensions Dimensions { get; set; }
            public Safety Safety { get; set; }
            public General General { get; set; }
            public Performance Performance { get; set; }
            public Consumption Consumption { get; set; }
        }

        public class Dimensions
        {
            public object UnladenWeight { get; set; }
            public string RigidArtic { get; set; }
            public string BodyShape { get; set; }
            public object PayloadVolume { get; set; }
            public object PayloadWeight { get; set; }
            public object Height { get; set; }
            public object NumberOfDoors { get; set; }
            public int NumberOfSeats { get; set; }
            public object KerbWeight { get; set; }
            public object GrossTrainWeight { get; set; }
            public int FuelTankCapacity { get; set; }
            public object LoadLength { get; set; }
            public object DataVersionNumber { get; set; }
            public object WheelBase { get; set; }
            public object CarLength { get; set; }
            public object Width { get; set; }
            public int NumberOfAxles { get; set; }
            public int GrossVehicleWeight { get; set; }
            public int GrossCombinedWeight { get; set; }
        }

        public class Safety
        {
            public Euroncap EuroNcap { get; set; }
        }

        public class Euroncap
        {
            public object Child { get; set; }
            public object Adult { get; set; }
            public object Pedestrian { get; set; }
        }

        public class General
        {
            public Engine Engine { get; set; }
            public string PowerDelivery { get; set; }
            public string TypeApprovalCategory { get; set; }
            public Electricvehiclebattery ElectricVehicleBattery { get; set; }
            public object SeriesDescription { get; set; }
            public string DriverPosition { get; set; }
            public string DrivingAxle { get; set; }
            public object DataVersionNumber { get; set; }
            public string EuroStatus { get; set; }
            public object IsLimitedEdition { get; set; }
        }

        public class Engine
        {
            public string FuelCatalyst { get; set; }
            public object Stroke { get; set; }
            public string PrimaryFuelFlag { get; set; }
            public object ValvesPerCylinder { get; set; }
            public object Aspiration { get; set; }
            public object FuelSystem { get; set; }
            public object NumberOfCylinders { get; set; }
            public object CylinderArrangement { get; set; }
            public object ValveGear { get; set; }
            public object Location { get; set; }
            public object Description { get; set; }
            public object Bore { get; set; }
            public string Make { get; set; }
            public object FuelDelivery { get; set; }
        }

        public class Electricvehiclebattery
        {
            public object Capacity { get; set; }
            public object ChargePort { get; set; }
            public object ChargeTime { get; set; }
            public object Type { get; set; }
        }

        public class Performance
        {
            public Torque Torque { get; set; }
            public object NoiseLevel { get; set; }
            public object DataVersionNumber { get; set; }
            public Power Power { get; set; }
            public Maxspeed MaxSpeed { get; set; }
            public object Co2 { get; set; }
            public object Particles { get; set; }
            public Acceleration Acceleration { get; set; }
        }

        public class Torque
        {
            public object FtLb { get; set; }
            public int Nm { get; set; }
            public int Rpm { get; set; }
        }

        public class Power
        {
            public int Bhp { get; set; }
            public int Rpm { get; set; }
            public int Kw { get; set; }
        }

        public class Maxspeed
        {
            public object Kph { get; set; }
            public object Mph { get; set; }
        }

        public class Acceleration
        {
            public object Mph { get; set; }
            public object Kph { get; set; }
            public object ZeroTo60Mph { get; set; }
            public object ZeroTo100Kph { get; set; }
        }

        public class Consumption
        {
            public Extraurban ExtraUrban { get; set; }
            public Urbancold UrbanCold { get; set; }
            public Combined Combined { get; set; }
        }

        public class Extraurban
        {
            public object Lkm { get; set; }
            public object Mpg { get; set; }
        }

        public class Urbancold
        {
            public object Lkm { get; set; }
            public object Mpg { get; set; }
        }

        public class Combined
        {
            public object Lkm { get; set; }
            public object Mpg { get; set; }
        }

        public class Classificationdetails
        {
            public Smmt Smmt { get; set; }
            public Dvla Dvla { get; set; }
            public Ukvd Ukvd { get; set; }
        }

        public class Smmt
        {
            public string Make { get; set; }
            public Mvris Mvris { get; set; }
            public object Trim { get; set; }
            public string Range { get; set; }
        }

        public class Mvris
        {
            public object ModelCode { get; set; }
            public object MakeCode { get; set; }
        }

        public class Dvla
        {
            public string Model { get; set; }
            public string Make { get; set; }
        }

        public class Ukvd
        {
            public bool IsElectricVehicle { get; set; }
            public Vrmformat VrmFormat { get; set; }
        }

        public class Vrmformat
        {
            public bool IsGbGeneralFormat { get; set; }
            public bool IsNiGeneralFormat { get; set; }
        }

        public class Vehiclestatus
        {
            public Motved MotVed { get; set; }
        }

        public class Motved
        {
            public Vedrate VedRate { get; set; }
            public object VedCo2Emissions { get; set; }
            public object VedBand { get; set; }
            public object VedCo2Band { get; set; }
        }

        public class Vedrate
        {
            public Firstyear FirstYear { get; set; }
            public Premiumvehicle PremiumVehicle { get; set; }
            public Standard Standard { get; set; }
        }

        public class Firstyear
        {
            public object SixMonth { get; set; }
            public object TwelveMonth { get; set; }
        }

        public class Premiumvehicle
        {
            public Yeartwotosix YearTwoToSix { get; set; }
        }

        public class Yeartwotosix
        {
            public object TwelveMonth { get; set; }
            public object SixMonth { get; set; }
        }

        public class Standard
        {
            public object SixMonth { get; set; }
            public object TwelveMonth { get; set; }
        }

        public class Vehiclehistory
        {
            public int V5CCertificateCount { get; set; }
            public int PlateChangeCount { get; set; }
            public int NumberOfPreviousKeepers { get; set; }
            public V5ccertificatelist[] V5CCertificateList { get; set; }
            public int KeeperChangesCount { get; set; }
            public int VicCount { get; set; }
            public object ColourChangeCount { get; set; }
            public object ColourChangeList { get; set; }
            public object KeeperChangesList { get; set; }
            public object[] PlateChangeList { get; set; }
            public object VicList { get; set; }
            public Colourchangedetails ColourChangeDetails { get; set; }
        }

        public class Colourchangedetails
        {
            public string CurrentColour { get; set; }
            public int NumberOfPreviousColours { get; set; }
            public object OriginalColour { get; set; }
            public object LastColour { get; set; }
            public object DateOfLastColourChange { get; set; }
        }

        public class V5ccertificatelist
        {
            public DateTime CertificateDate { get; set; }
        }

        public class Vehicleregistration
        {
            public DateTime DateOfLastUpdate { get; set; }
            public string Colour { get; set; }
            public string VehicleClass { get; set; }
            public bool CertificateOfDestructionIssued { get; set; }
            public string EngineNumber { get; set; }
            public string EngineCapacity { get; set; }
            public object TransmissionCode { get; set; }
            public bool Exported { get; set; }
            public string YearOfManufacture { get; set; }
            public string WheelPlan { get; set; }
            public object DateExported { get; set; }
            public bool Scrapped { get; set; }
            public object Transmission { get; set; }
            public DateTime DateFirstRegisteredUk { get; set; }
            public string Model { get; set; }
            public object GearCount { get; set; }
            public bool ImportNonEu { get; set; }
            public object PreviousVrmGb { get; set; }
            public int GrossWeight { get; set; }
            public string DoorPlanLiteral { get; set; }
            public object MvrisModelCode { get; set; }
            public string Vin { get; set; }
            public string Vrm { get; set; }
            public DateTime DateFirstRegistered { get; set; }
            public object DateScrapped { get; set; }
            public string DoorPlan { get; set; }
            public string YearMonthFirstRegistered { get; set; }
            public string VinLast5 { get; set; }
            public bool VehicleUsedBeforeFirstRegistration { get; set; }
            public int MaxPermissibleMass { get; set; }
            public string Make { get; set; }
            public string MakeModel { get; set; }
            public object TransmissionType { get; set; }
            public int SeatingCapacity { get; set; }
            public string FuelType { get; set; }
            public object Co2Emissions { get; set; }
            public bool Imported { get; set; }
            public object MvrisMakeCode { get; set; }
            public object PreviousVrmNi { get; set; }
            public object VinConfirmationFlag { get; set; }
        }

        public class Smmtdetails
        {
            public string Range { get; set; }
            public string FuelType { get; set; }
            public string EngineCapacity { get; set; }
            public string MarketSectorCode { get; set; }
            public string CountryOfOrigin { get; set; }
            public string ModelCode { get; set; }
            public object ModelVariant { get; set; }
            public object DataVersionNumber { get; set; }
            public object NumberOfGears { get; set; }
            public float NominalEngineCapacity { get; set; }
            public string MarqueCode { get; set; }
            public object Transmission { get; set; }
            public object BodyStyle { get; set; }
            public string VisibilityDate { get; set; }
            public string SysSetupDate { get; set; }
            public string Marque { get; set; }
            public string CabType { get; set; }
            public string TerminateDate { get; set; }
            public object Series { get; set; }
            public object NumberOfDoors { get; set; }
            public string DriveType { get; set; }
        }

    }
}
