using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.IsolatedStorage;

namespace DeskopLuRaKasa.Services
{
    public static class IsolatedStorageServices
    {
        public static void Set(string key, string value)
        {
            using (IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForAssembly())
            { 
                using (IsolatedStorageFileStream stream = new IsolatedStorageFileStream("settings.txt", FileMode.Create, storage))
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.WriteLine(key + "=" + value);
                    }
                }
            
            }
        }

        public static string Get(string key)
        {
            using (IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForAssembly())
            {
                if (storage.FileExists("settings.txt"))
                {
                    using (IsolatedStorageFileStream stream = new IsolatedStorageFileStream("settings.txt", FileMode.Open, storage))
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                if (line.StartsWith(key + "="))
                                {
                                    return line.Substring(key.Length + 1);
                                }
                            }
                        }
                    }
                }
            }
            return null;
           
        }
    }
}
