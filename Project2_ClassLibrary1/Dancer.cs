namespace Project2_ClassLibrary1
{
    public class Dancer
    {
        public int _Points { get; set; }
        public string Name { get; set; }       


        public Dancer()
        {

        }

        public Dancer(string name, int points)
        {
            this.Name = name;
            _Points = points;          
        }

        public static Dancer operator +(Dancer dancer1, Dancer dancer2)
        {
            Dancer dancer = new Dancer();
            dancer._Points = dancer1._Points + dancer2._Points;
            dancer.Name = dancer1.Name + " og " + dancer2.Name;

            return dancer;
        }
    }
}
