namespace WarsawDengerousData.Services.DataModels
{
    public class Enums
    {
        public enum Category { Infrastruktura, Inne, Porządek, ProcesInterwencyjny };

        public enum City { Warszawa };

        public enum DeviceType { Unknown };

        public enum District { Wola };

        public enum NotificationType { Complaint, Incident };

        public enum Source { Call, Ckm, Portal };

        public enum Subcategory { Inne, KomunikacjaTransport, Śmieci };
    }
}