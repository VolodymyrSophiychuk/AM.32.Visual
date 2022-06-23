namespace Data.Templates
{
    public class NameSample
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }

        public NameSample() { }
        public NameSample((string first, string last) name)
        {
            Firstname = name.first;
            Lastname = name.last;
        }
    }
}
