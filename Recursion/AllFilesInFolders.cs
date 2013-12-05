using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class AllFilesInFolders
    {
        private Dictionary<string, string> errors = new Dictionary<string, string>();
        private List<string> result = new List<string>();

        public void SearchForFiles(string path)
        {
            try
            {
                foreach (string fileName in Directory.GetFiles(path))//Gets all files in the current path
                {
                    result.Add(fileName);
                }

                foreach (string directory in Directory.GetDirectories(path))//Gets all folders in the current path
                {
                    SearchForFiles(directory);//The methods calls itself with a new parameter, here!
                }
            }
            catch (System.Exception ex)
            {
                errors.Add(path, ex.Message);//Stores Error Messages in a dictionary with path in key
            }
        }
    }
}
