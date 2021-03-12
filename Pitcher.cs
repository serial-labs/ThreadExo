using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventApp
{
    class Pitcher
    {
        public Pitcher(Ball ball)
        {
            //ball.BallInPlay += new EventHandler(ball_BallInPlay);
            ball.BallInPlay += ball_BallInPlay;
        }

        public void ball_BallInPlay(object sender, EventArgs e)
        {
            if(e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if ((ballEventArgs.Distance < 95) && (ballEventArgs.Trajectory < 60))
                {
                    CatchBall();
                }
                else
                    CoverFirstBase();
                //ballEventArgs.Distance = 0;
                //ballEventArgs.Trajectory
            }
            //int th = System.Threading.Thread.CurrentThread.ManagedThreadId;
            //Console.WriteLine("n° thread : " + th);
        }

        private void CoverFirstBase()
        {
            Console.WriteLine("Pitcher : I covered first base");
        }

        private void CatchBall()
        {
            Console.WriteLine("Pitcher : I caught the ball");
        }
    }
}
