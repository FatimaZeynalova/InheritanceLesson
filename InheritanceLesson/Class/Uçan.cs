namespace InheritanceLesson.Class
{
    public class Uçan : Heyvan
    {
        public Uçan(string ad) : base(ad) { }

        public override string SesCikar()
        {
            return "Quş ses çıxarır.";
        }

        public string Uç()
        {
            return $"{Ad} uçuyor.";
        }
    }



}
