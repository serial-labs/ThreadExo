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

        public static int findIndexFAll<T>(this List<T> listElement, T element)
        {
            for (int i = 0; i <listElement.Count; i++)
            {
                if (listElement[i].Equals(element))
                {
                    return i;
                }

            }
            return listElement.Count;
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
        public string nom { get; set; }
        public int profondeur { get; set; }
        public int repetition { get; set; }

        public override bool Equals(object other)
        {
            if (!(other is MesChamps))
                return false;
            return this.nom == ((MesChamps)other).nom;
            
        }


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


        public static  void findInProf(JToken Token, List<MesChamps> ch, int p=0)
        {
            
            string n = (Token is JProperty) ? (Token as JProperty).Name : "[Pas de nom]";
            Console.WriteLine("dans fonction a la profondeur {0}");
            foreach (JToken childToken in Token.Children())
            {
                if (!(childToken is JProperty)) continue;
                string propName =((JProperty)childToken).Name;
                int idx = ch.findIndexFAll<MesChamps>(new MesChamps() { nom = propName });
                if (idx < ch.Count)
                {
                    ch[idx].repetition = ch[idx].repetition + 1;
                }
                else
                {
                    ch.Add(new MesChamps() { nom = propName, repetition = 1, profondeur = p + 1 });
                }
                
                findInProf(childToken, ch,p+1);
            }
        }


        
        static void Main(string[] args)
        {
            MesChamps m = new MesChamps();
            Object o = new Object();

            Console.WriteLine(m.Equals(o));
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
            
            //var champs= new List<string>();
            //int indexdeToto = champs.findIndexF("toto");

            var nbChamps = new List<int>();

            var champs = new List<MesChamps>();
            
            //Console.WriteLine(jsonObj.ContainsKey("rows"));
            //Console.WriteLine(jsonObj.GetValue("rows").Children().Count());
            Console.WriteLine(jsonObj.GetValue("rows").Children().Count());
            //Console.WriteLine(jsonObj.First.First.Children().Count());
            //Console.WriteLine(jsonObj.First.First.Children().ElementAt(0).Children());
            //Console.WriteLine(jsonObj.First.First.Children().ElementAt(1));
            //Console.WriteLine(jsonObj.First.First.Children().ElementAt(1).Ancestors().ToString());
            findInProf(jsonObj, champs);
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
                    findInProf(rowsToken,champs);
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
