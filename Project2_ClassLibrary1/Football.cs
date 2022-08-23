using System;


namespace Project2_ClassLibrary1
{
    public class Football
    {
                     
        private string målforsøg;

        private string antalAfleveringer;


        public string Aflevering(int afleveringer)
        {           

            if (afleveringer < 1)
            {
                return "Shh";
            }           

            else if (afleveringer >= 10)
            {
                return "High Five – Jubel!!!";
            }
            else
            {
                for (int i = 0; i < afleveringer; i++)                                   

                    antalAfleveringer += "Huh!";

                    return antalAfleveringer;                
            }
            
        }

        public string Mål(int afleveringer, string målforsøg)
        {          

            if (målforsøg == "mål")
            {
                return "Ole ole ole!";
            }
            else
            {
               return Aflevering(afleveringer);
            }

           
        }


    }
}


    

    



    


