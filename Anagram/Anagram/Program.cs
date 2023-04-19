// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Linq;

var pair1 = new List<string>() { "test", "sett" }; /*true*/
var pair2 = new List<string>() { "secure", "rescue" }; /*true*/
var pair3 = new List<string>() { "fr om", "mrof" }; /*true*/
var pair4 = new List<string>() { "google", "facebook" }; /*false*/
var pair5 = new List<string>() { "tespp", "settp" }; //false
var pair6 = new List<string>() { "", " " }; //true
var pair7 = new List<string>(); //false;
var pair8 = new List<string>() { "test", "test", "test" }; //false;
var pair9 = new List<string>() { "Test", "test" }; //true;


var pairs = new HashSet<List<string>>();
pairs.Add(pair1);
pairs.Add(pair2);
pairs.Add(pair3);
pairs.Add(pair4);
pairs.Add(pair5);
pairs.Add(pair6);
pairs.Add(pair7);
pairs.Add(pair8);
pairs.Add(pair9);


int n = 0;
foreach (var pair in pairs)
{
    var isAnagram = CheckIsAnagram(pair);
    Console.WriteLine("Pair{0} isAnagram = {1}", n, isAnagram);
}


static bool CheckIsAnagram(List<string> pair)
{

    if (pair.Count == 2)
    {
        string word1 = pair[0].ToString().Trim().ToLower().Replace(" ", "");
        string word2 = pair[1].ToString().Trim().ToLower().Replace(" ", "");

        char[] w1chars = word1.ToCharArray();
        char[] w2chars = word2.ToCharArray();

        if(w1chars.Length != w2chars.Length)
        {
            return false;
        }

        for (int i = 0; i < word1.Length; i++)
        {
            var w1Count = word1.Where(w => w.Equals(w1chars[i])).Count();
            var w2Count = word2.Where(w => w.Equals(w1chars[i])).Count();

            var charnum = w1Count == w2Count;
            if (!w1chars.Contains(w2chars[i]))
            {
                return false;
            }
            else if (!charnum)
            {
                return false;
            }
        }

        return true;
    }
    else
    {
        return false;
    }

}