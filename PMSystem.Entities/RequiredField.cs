namespace PMSystem.Entities
{
    public class RequiredField
	{
	    public RequiredField(string fn, string fv )
	    {
		    Name = fn;
		    Value = fv;
	    }

        public string Value { get; private set; }

        public string Name { get; private set; }
	}
}
