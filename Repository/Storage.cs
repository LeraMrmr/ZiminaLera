namespace ZiminaLear.Repository
{
    public static class Storage
    {
        public static readonly CustomerStorage customerStorage = new();
        public static readonly PayStorage payStorage = new();
         public static readonly AcquiredProjectStorage acquiredProjectStorage = new();
         public static readonly BilledaccountStorage billedaccountStorage = new();
        public static readonly DesignerStorage designerStorage = new();
        public static readonly WorkerStorage workerStorage = new();
        public static readonly ProjectStorage projectStorage = new();
        public static readonly ForemanStorage foremanStorage = new();
        public static readonly PlanOfWorkStorage planOfWorkStorage = new();
    
    }
}