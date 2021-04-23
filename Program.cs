using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonAppCons
{

    public static  class MesExtensions
    {

        public static int findIndexF(this List<string> champs, string name)
        {
            for (int i = 0; i < champs.Count; i++)
            {
                if (champs[i].Equals(name))
                {
                    return i;
                }

            }
            return champs.Count;
        }

        public static int findIndexFAll<T>(this List<T> champs, T name)
        {
            for (int i = 0; i < champs.Count; i++)
            {
                if (champs[i].Equals(name))
                {
                    return i;
                }

            }
            return champs.Count;
        }

    }

    public class Livre
    {
        public string titre;
        public int nbPages;
        public decimal prix;
        public string auteur;
        public List<Livre> livresSimilaires;

        
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }

    public class MesChamps
    {
        string nom { get; set; }
        int profondeur { get; set; }
        int repetition { get; set; }


    }
    public class Program
    {
        

        public int findIndexFE(List<string> champs, string name)
        {
            int i = 0;
            foreach (string champ in champs)
            {
                if (champ[i].Equals(name))
                {
                    return i;
                }
                i = i + 1;
            }


            return i;
        }


        public static  void findInProf(JToken rToken,int p=0)
        {
            
            foreach(JToken orToken in rToken.Children())
            {
                
                foreach (JToken childORToken in orToken.Children())
                {
                    
                    if (!(childORToken is JProperty)) continue;

                    
                    JProperty jprop = childORToken.ToObject<JProperty>();
                    Console.WriteLine("{0} est de profondeur {1}", jprop.Name, p);
                    
                    foreach(JToken childT in childORToken.Children())
                    {
                        if (!(childT is JArray)) continue;
                        findInProf(childT, ++p);
                    }
                }
            }
        }


        
        static void Main(string[] args)
        {
            //int j = 0;
            //int resulAffec = (j=j+1);
            //Console.WriteLine(((resulAffec))); 

            //int k = 0;
            //Console.WriteLine(++k);

            //int l = 0;
            //Console.WriteLine(l++);
            //var jsonObj = File.ReadAllText(@"C:\Users\amega\source\repos\JsonAppCons\data.json");
            //var obj = JsonConvert.DeserializeObject(jsonObj);
            //Console.WriteLine(obj);

            JObject jsonObj = JObject.Parse(File.ReadAllText(@"C:\Users\amega\source\repos\JsonAppCons\data.json"));
            
            var champs= new List<string>();
            int indexdeToto = champs.findIndexF("toto");

            var nbChamps = new List<int>();
            //Console.WriteLine(jsonObj.ContainsKey("rows"));
            //Console.WriteLine(jsonObj.GetValue("rows").Children().Count());
            Console.WriteLine(jsonObj.GetValue("rows").Children().Count());
            //Console.WriteLine(jsonObj.First.First.Children().Count());
            //Console.WriteLine(jsonObj.First.First.Children().ElementAt(0).Children());
            //Console.WriteLine(jsonObj.First.First.Children().ElementAt(1));
            //Console.WriteLine(jsonObj.First.First.Children().ElementAt(1).Ancestors().ToString());
            
            if (jsonObj.ContainsKey("rows"))
            {
                JToken rowsToken = jsonObj.GetValue("rows");
                   
                if( rowsToken is JArray)
                {
                    //foreach(JToken oneRowToken in rowsToken)
                    //{

                    //    foreach (JToken propToken in oneRowToken.Children())
                    //    {

                    //        if (!(propToken is JProperty)) continue;

                    //        JProperty jprop = propToken.ToObject<JProperty>();
                    //        //Console.WriteLine(jprop.Name);
                    //        if (!champs.Contains(jprop.Name))
                    //        {
                    //            champs.Add(jprop.Name);
                    //            nbChamps.Add(1);
                    //        }
                    //        else
                    //        {
                    //            int idx = champs.findIndexF(jprop.Name);
                    //            nbChamps[idx] = nbChamps[idx] + 1;
                    //        }
                    //    }
                    //    //Console.WriteLine("\n");
                    //}
                    findInProf(rowsToken);
                }
                else
                {
                    Console.WriteLine(jsonObj.GetValue("rows"));
                }
                
            }
            
            Livre l1 = new Livre() { titre = "c#8", prix = 5.0M };
            Livre l2 = new Livre() { titre = "c#8", prix = 6.0M };
            var li = new List<Livre>();
            li.Add(l1);
            int test = li.findIndexFAll(l2);


            //JToken rowsToken = jsonObj.GetValue("rows").Children();
            //var over50 = new List<string>();
            //var under50 = new List<string>();
            //for (int i = 0; i < nbChamps.Count; i++)
            //{
            //    if(nbChamps[i] > rowsToken.Count / 2)
            //    {
            //        over50.Add(champs[i]);
            //    }
            //    else
            //    {
            //        under50.Add(champs[i]);
            //    }
            //}

            //Console.WriteLine("\nListe des champs:\n");
            //foreach (string champ in champs)
            //{
            //    Console.WriteLine(champ);
            //}

            //Console.WriteLine("\nListe des champs au dessus de 50%:\n");
            //foreach (string champ in over50)
            //{
            //    Console.WriteLine(champ);
            //}

            //Console.WriteLine("\nListe des champs en dessous de 50%:\n");
            //foreach (string champ in under50)
            //{
            //    Console.WriteLine(champ);
            //}

            //Console.WriteLine("\n");
            Console.ReadLine();
        }

       
    }

    

    
}
