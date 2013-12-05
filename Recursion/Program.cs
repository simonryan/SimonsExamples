using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////
            /*var perms = new StringPermutation();
            var result = perms.GetPerms("abc");
            foreach (var perm in result)
            {
                Console.WriteLine(perm);    
            }*/
            //////////////////////////////////////////

            var filesInFolders = new AllFilesInFolders();
            filesInFolders.SearchForFiles(@"C:\Users\ryansi\Documents\Work");

            Console.ReadKey();
        }
    }
}
