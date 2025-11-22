namespace MonitoraggioPAC25_27.Extensions
{
    public static class ParereMinisteroExtensions
    {
        public static string ToLabel(this int? parere)
        {
            return parere switch
            {
                1 => "Conforme",
                2 => "Parzialmente conforme",
                3 => "Non conforme",
                _ => "Non definito"
            };
        }
    }
}