using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppUI
{
    class RandomFile
    {
        private const int NAME_LENGTH = 64;

        public Dictionary<int, List<Movie>> movieNames;

        public List<Movie> movies;

        public RandomFile()
        {
            movieNames = new Dictionary<int, List<Movie>>();
            movies = new List<Movie>();
        }

        
        public void WriteBinaryFile()
        {
            try
            {
                // store collection to binary file
                //stu.bin is the file name
                using (BinaryWriter bWriter = new BinaryWriter(File.Open("movies.bin", FileMode.Create)))
                {
                   

                    foreach (KeyValuePair<int,List<Movie>> movie in movieNames)
                    {
                        //bWriter.Write(movie.Key.PadLeft(NAME_LENGTH).ToCharArray(0, NAME_LENGTH));
                        foreach(Movie m in movie.Value)
                        {
                            bWriter.Write(m.ToString());
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing students.bin due to the following exception: " + ex.Message);
            }
        }
        
        
        public List<Movie> ReadBinaryFile()
        {
            try
            {
                // read collection from binary file
                using (BinaryReader bReader = new BinaryReader(File.Open("movies.bin", FileMode.Open)))
                {
                    List<Movie> mv = new List<Movie>(); 
                    for (int i = 0; i < movieNames.Count; i++)
                    {
                        string name = new string(bReader.ReadChars(NAME_LENGTH));
                        int frequency = bReader.ReadInt32();
                        Console.WriteLine(name + " " + frequency);
                    }

                    // go directly to third record and read it
                    bReader.BaseStream.Seek(2 * (NAME_LENGTH + sizeof(int)), SeekOrigin.Begin);
                    string seekName = new string(bReader.ReadChars(NAME_LENGTH));
                    int seekFrequency = bReader.ReadInt32();
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading students.bin due to the following exception: " + ex.Message);
            }
            return null;
        }
    }
}
