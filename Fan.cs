using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventApp
{
    class Fan
    {
        public Fan(Ball ball)
        {
            ball.BallInPlay += new EventHandler(ball_BallInPlay);
        }

        private void ball_BallInPlay(object sender, EventArgs e)
        {
            if (e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if ((ballEventArgs.Distance >= 400) && (ballEventArgs.Trajectory >= 30))
                {
                    Console.WriteLine("Fan: Home RUN !!!!");
                }
                else
                    Console.WriteLine("Fan: woo hoo YEAH!!");
            }
            //int th = System.Threading.Thread.CurrentThread.ManagedThreadId;
            //Console.WriteLine("n° thread : " + th);
        }
    }
}
