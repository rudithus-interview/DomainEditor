namespace DomainEditor.Models.Primitives
{
    public class DomainId
    {
        private readonly int _value;

        public DomainId(int value)
        {
            _value = value;
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}