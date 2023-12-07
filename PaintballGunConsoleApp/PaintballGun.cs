using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintballGunConsoleApp
{
    class PaintballGun
    {
        public const int MAGAZINE_SIDE = 16;

        private int balls = 0;
        private int ballsLoaded = 0;

        public int GetBallsLoaded() { return ballsLoaded; }
        public bool IsEmpty() { return ballsLoaded == 0; }
       public int Balls
        {
            get { return balls; }
            set
            {
                if (value > 0)
                    balls = value;
                Reload();
            }
        }

        public void Reload()
        {
            if (balls > MAGAZINE_SIDE)
                ballsLoaded = MAGAZINE_SIDE;
            else
                ballsLoaded = balls;
        }
        public bool Shoot ()
        {
            if (ballsLoaded == 0) return false;
            ballsLoaded--;
            balls--;
            return true;
        }
    }
}
