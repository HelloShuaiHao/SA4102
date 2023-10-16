namespace Routing_Workshop.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, Age {1}", Name, Age);
        }
    }
}
