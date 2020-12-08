namespace smcaptureLib.Globals.KendoSupport
{
    public enum Operator
    {
        eq = 1,
        neq,
        gt,
        gte,
        lt,
        lte,
        startswith,
        contains,
        endswith,
        doesnotcontain
    }

    public class descriptor
    {
        public string field { get; set; }
        public object value { get; set; }
        public Operator @operator { get; set; }
    }
}

