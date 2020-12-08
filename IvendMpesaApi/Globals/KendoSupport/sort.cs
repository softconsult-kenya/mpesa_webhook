namespace smcaptureLib.Globals.KendoSupport
{
    public enum SortOrder { asc, desc }

    public class sort
    {
        public string field { get; set; }
        public SortOrder dir { get; set; }
    }
}
