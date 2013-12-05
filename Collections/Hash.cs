using System.Collections.Generic;

namespace Collections
{
    /// <summary>
    /// Hash set stores a set of unique items
    /// Performant for checking if items exist in set i.e. fast searching
    /// 
    /// </summary>
    class Hash
    {
        public void MyHash()
        {
            var hashset = new HashSet<string>
                {
                    "Yellow", "Green", "Red", "Blue"
                };

            bool result = hashset.Contains("Green");

            foreach (var colour in hashset)
            {
                
            }
        }
    }
}
