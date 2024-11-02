namespace InheritanceLesson.Class
{
    public class Yürüyən : Heyvan
    {
        public Yürüyən(string ad) : base(ad) { }

        public override string SesCikar()
        {
            return "It ses çıxarır.";
        }

        public string Yürüy()
        {
            return $"{Ad} yürüyor.";
        }
    }

}
