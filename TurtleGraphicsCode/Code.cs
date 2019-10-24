using System;

namespace TurtleGraphicsCode
{

    public class Code
    {

        /// <summary>
        /// This is the place to put your turtle code
        /// </summary>
        public Turtle ToExecute()
        {
            Turtle t = new Turtle();
            t.Rotate(-90);
            for (int i = 0; i < 6; i++) {
                t.StoreTurtlePosition();
                for (int e = 0; e < 20; e++) { }
                {
                    DrawSection(t, 100);



                }
                t.RestoreTurtlePosition();
                t.Rotate(60);
            }


            t.StoreTurtlePosition();


           

            return t;

        }

        void DrawSection(Turtle t, int p)
        {
            t.Forward(10);
            t.StoreTurtlePosition();
            t.Rotate(-45);
            t.Forward(p);
            t.RestoreTurtlePosition();
            t.Rotate(45);
            t.Forward(p);
            t.RestoreTurtlePosition(true);

        }
    }
}














//Vytvořím si složku na disku Z: na mé projekty ve Visual Studiu
//Otevřu cmd/powershell v složce z řádku 11
//Zadám 'git clone https://github.com/Michal-MK/TurtleGraphics.git'
//Ovetřu stažený solution ve visual studiu(.sln soubor)
//Najdu projekt 'TurteGraphicsCode'
//Najdu soubor Code.cs a otevřu ho
//Jsem zde!