namespace InheritanceLesson.Class
{
    public class Heyvan
    {
        public string Ad { get; set; }

        public Heyvan(string ad)
        {
            Ad = ad;
        }

        public virtual string SesCikar()
        {
            return "Hayvan ses çıxarır.";
        }
    }

}
