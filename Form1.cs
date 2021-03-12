using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventApp
{
    public partial class Form1 : Form
    {
        Ball ball = new Ball();
        Pitcher pitcher;
        Fan fan;
        Lequipe lequipe = new Lequipe();

        Supporter ethan = new Supporter("Ethan");
        Supporter ruben = new Supporter("Ruben");
        Supporter sami = new Supporter("Sami");
        int cpt=0;
        public Form1()
        {
            InitializeComponent();
            pitcher = new Pitcher(ball);
            fan = new Fan(ball);
            Console.WriteLine("\n \n ------------------ \n \n");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Play_Click(object sender, EventArgs e)
        {
            BallEventArgs ballEventArgs = new BallEventArgs((int)Trajectory.Value, (int)Distance.Value);
            ball.OnBallInPlay(ballEventArgs);
            ball.BallInPlay += newAbo;
            //ball.BallInPlay -= pitcher.ball_BallInPlay;
        }

        private void newAbo(object sender, EventArgs e)
        {
            Console.WriteLine("nouvelle abonne");
            int th = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine("n° thread : " + th);
        }

        private void TestThread_Click(object sender, EventArgs e)
        {
            
            int compteur = 0;
            int th = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine("n° thread : " + th);
            Thread th2 = new Thread(boucle2);


            th2.Start();
            for (int i = 0; i < 10; i++)
            {
                
                compteur++; Thread.Sleep(20);
                Console.WriteLine("Compteur : " + compteur);
                if (i == 5)
                {
                    
                    
                    
                    
                    th2.Name = "Second Thread";
                    Console.WriteLine("nom thread pour la boucle 2: " + th2.Name);
                }
                
                
            }
            Console.WriteLine("n° thread : " + th);
        }

        public  void boucle2()
        {
            int compteur = 0;
            Thread th2 = Thread.CurrentThread;
            
            Console.WriteLine($"n° thread pour la boucle 2: ${ th2.ManagedThreadId} nom du thread : ${th2.Name}");
            for (int i = 0; i < 10; i++)
            {
                compteur++; Thread.Sleep(50);
                Console.WriteLine("Compteur 2 : " + compteur);
                
                

            }
            Console.WriteLine($"n° thread pour la boucle 2: ${ th2.ManagedThreadId}nom du thread : ${th2.Name}");
        }

        private void bclTread_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Thread currentTh = Thread.CurrentThread;
            //Console.WriteLine($"n° thread : { currentTh.ManagedThreadId} \t n° compteur: {cpt}");
            
            
            //-------------------------------------------------------------------------------------------------------------------
            //creation de plusieur thread mais le multi trhead n'est pas forcement plus rapide
            //il permet de donner l'impression que c'est plus rapide et evite de planter les programme si une action demande du temps
            //et l'utilisateur peut toujours utiliser le programme
            //on ne choisi pas forcement l'ordre execution des thread 
            //--------------------------------------------------------------------------------------------------------------------


            Thread th = new Thread(boucle);
            Thread th2 = new Thread(boucle);
            Thread th3 = new Thread(boucle);
            th.Start(); 
            //th2.Start(); 
            //th3.Start();
            while ( th.IsAlive || th2.IsAlive || th3.IsAlive)//<=> (!th.isAlive && !th2.isAlive && !th3.isAlive)Attention au erreur de logique
            {

            }
            sw.Stop();
            
            Console.WriteLine($"n°  current thread : { currentTh.ManagedThreadId} \t n° compteur: {cpt}");
            
            Console.WriteLine($"Time : { sw.ElapsedMilliseconds} ");
        }

        public void boucle()
        {
            Thread th = Thread.CurrentThread;
            for (int i = 0; i < 45; i++)
            {

                //Thread.Sleep(500);
                cpt++;
                Console.WriteLine($"n° thread : { th.ManagedThreadId} a \t n° compteur: {cpt}");
                cpt++;
                Console.WriteLine($"n° thread : { th.ManagedThreadId} b\t n° compteur: {cpt}");
                cpt++;
                Console.WriteLine($"n° thread : { th.ManagedThreadId}  c\t n° compteur: {cpt}");
            }
            Console.WriteLine($"n°  current thread : { th.ManagedThreadId} \t n° compteur: {cpt}");
        }

        private void freez_Click(object sender, EventArgs e)
        {
            //--------------------------------test exemple livre 
            //lequipe.InfoL1 += ethan.ReceptionInfo;
            //lequipe.InfoLdc += ruben.ReceptionInfo;
            //lequipe.InfoLdc += sami.ReceptionInfo;
            //lequipe.InfoL1 += sami.ReceptionInfo;

            //------test de boucle avec attente pour voir si programme plante 

            lequipe.InfoL1 += b3;

            lequipe.OnInfoL1(new InfoEventArgs("Sochaux bat Marseille 2:1"));
            //lequipe.OnInfoLdc(new InfoEventArgs("Barça une deuxieme remontada ??"));
        }


        public void b3(object sender, EventArgs e)
        {
            int conpt=0;
            for(int i = 0; i < 10; i++)
            {
                conpt++;
                Console.WriteLine($"valeur du compteur {conpt}");
                Thread.Sleep(1000);
            }
        }
    }
}
