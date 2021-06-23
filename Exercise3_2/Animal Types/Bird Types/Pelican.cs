namespace Exercise3_2
{
    public class Pelican : Bird
    {
        public int MouthVolume { get; set; }
        public Pelican(string name, int age, int weight, int wingSpan, int mouthVolume) : base(name, age, weight, wingSpan)
        {
            MouthVolume = mouthVolume;
        }
        //public override void Dosound()
        //{
        //    Console.WriteLine($"The sound that a {GetType().Name} makes is a chirp"); ;
        //}
    }

}