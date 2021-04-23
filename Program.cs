using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonApp2
{
    public static class Exs
    {
        public static int indexInList<T>(this List<List<T>> maList, T valeur)
        {
            for(int i = 0; i < maList.Count; i++)
            {
                if (maList[i].Equals(valeur))
                {
                    return i;
                }
            }
            return maList.Count;
        }
    }

    public class MonItem
    {
        public string nomItem { get; set; }
        public int numProf { get; set; }
        public int nbRep { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is MonItem))
                return false;
            return this.nomItem == ((MonItem)obj).nomItem;
        }
    }
    class Program
    {

        static void SearchObjInProf(JToken token, List<List<MonItem>> maList, int p = 0)
        {
            
            var listP = new List<MonItem>();

            foreach(JToken childToken in token.Children())
            {
                
                if (childToken is JArray || childToken is JObject)
                {
                    SearchObjInProf(childToken, maList, p + 1);
                }
                if (!(childToken is JProperty)) continue;
                string nameProperty = ((JProperty)childToken).Name;
                int index = maList.indexInList<MonItem>(new MonItem() { nomItem = nameProperty });
                if(index < maList.Count)
                {
                    maList[p][index].nbRep = maList[p][index].nbRep + 1;
                }
                else
                {
                    listP.Add(new MonItem() { nomItem = nameProperty, numProf = p + 1, nbRep = 1 });
                }
                
                SearchObjInProf(childToken, maList, p + 1);
            }
            
        }


        static void Main(string[] args)
        {
            JObject jsonObj = JObject.Parse(File.ReadAllText(@"C:\Users\amega\source\repos\JsonAppCons\data.json"));
            var mesItems = new List<List<MonItem>>();
            SearchObjInProf(jsonObj, mesItems);
            Console.WriteLine("{0,10} {1,10} {2,10}", "Nom du champs", "Profondeur", "Nombre de repetition");
            
        }
    }
}
