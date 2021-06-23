namespace Exercise3_2
{
    public class Flamingo : Bird
    {
        public int LegsOnGround { get; set; }
        public Flamingo(string name, int age, int weight, int wingSpan, int legsOnGround) : base(name, age, weight, wingSpan)
        {
            LegsOnGround = legsOnGround;
        }
        //public override void Dosound()
        //{
        //    Console.WriteLine($"The sound that a {GetType().Name} makes is a chirp"); ;
        //}
    }

}