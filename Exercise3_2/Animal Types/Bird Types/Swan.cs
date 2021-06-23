namespace Exercise3_2
{
    public class Swan : Bird
    {
        public string Angry { get; set; }
        public Swan(string name, int age, int weight, int wingSpan, string angry) : base(name, age, weight, wingSpan)
        {
            Angry = angry;
        }
        //public override void Dosound()
        //{
        //    Console.WriteLine($"The sound that a {GetType().Name} makes is a chirp"); ;
        //}
    }

}