using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieAppUI
{
    public partial class MovieReviewForm : Form
    {
        private const int NAME_LENGTH = 64;
        private const int TOTAL_RECORDS = 10;

        List<Movie> movies = new List<Movie>();
        List<Movie> binaryMovies = new List<Movie>();

        BindingSource source = new BindingSource();
 


        public MovieReviewForm()
        {
            InitializeComponent();
            source.DataSource = movies;

            //source2.DataSource = binaryMovies;
            lstMovies.DataSource = source;
           // lstMovies.DataSource = source2;
            
        }

        private void MovieReviewForm_Load(object sender, EventArgs e)
        {

        }

      

        public void WriteMoviesToSeqFile()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("SeqMovies.txt"))
                {
                    foreach (Movie m in movies)
                    {
                        sw.WriteLine(m.ToFileString());
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing Movies.txt due to the following exception: " + ex.Message);
            }
        }

        public void ReadMoviesFromSeqFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader("SeqMovies.txt"))
                {
                    string[] ar = null;

                    while (!sr.EndOfStream)
                    {
                        string s = sr.ReadLine();
                        ar = s.Split(':');
                        Movie movie = new Movie(ar[0],
                                                ar[1],
                                                ar[2],
                                                ar[3],
                                                ar[4],
                                                ar[5],
                                                ar[6],
                                    Double.Parse(ar[7]));
                        //Pet p = new Pet { Name = ar[0], Species = ar[1], AgeYear = int.Parse(ar[2]) };
                        //myPets.Add(p);
                        movies.Add(movie);

                    }


                    source.ResetBindings(false);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading Pets.txt due to the following exception: " + ex.Message);
            }
        }

        private void OnClickLoadFromSequentialFile(object sender, EventArgs e)
        {
            btnLoadMoviesToBinary.Enabled = false;
            btnSaveToBinary.Enabled = false;
            btnFinBinary.Enabled = false;
            ReadMoviesFromSeqFile();
           
        }

        private void OnClickSaveToSequentialFile(object sender, EventArgs e)
        {
            btnLoadMoviesToBinary.Enabled = false;
            btnSaveToBinary.Enabled = false;
            btnFinBinary.Enabled = false;

            if (movies.Count != 0)
                WriteMoviesToSeqFile();
            else
                MessageBox.Show("Please Add movies");
        }

        private void lstMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            Movie m = (Movie)lstMovies.SelectedValue;
            setControl(m);
   

        }

        private void OnClickUpdateMovie(object sender, EventArgs e)
        {
            
            try
            {
                Movie movie = new Movie(txtMovieName.Text,
                                  txtISBN.Text,
                                  dtReleaseDate.Text,
                                  cbLocation.Text,
                                  cbGenre.Text,
                                  cbRating.Text,
                                  txtDuration.Text,
                                  Double.Parse(txtPrice.Text));

                if(movies.Count == 0)
                {
                    binaryMovies[lstMovies.SelectedIndex] = movie;
                }

                if (binaryMovies.Count == 0)
                {
                    movies[lstMovies.SelectedIndex] = movie;
                }

                //movies[lstMovies.SelectedIndex] = movie;





            }
             catch
            {
                MessageBox.Show("Please Enter the values");
            } 
                
           
           
            source.ResetBindings(false);
        }

        private void OnClickDeleteMovie(object sender, EventArgs e)
        {
            try
            {
                if(movies.Count != 0)
                {
                    movies.RemoveAt(lstMovies.SelectedIndex);
                    source.ResetBindings(false);
                }
                
                if(binaryMovies.Count != 0)
                {
                    binaryMovies.RemoveAt(lstMovies.SelectedIndex);

                    source.DataSource = binaryMovies;
                    lstMovies.DataSource = source;
                    source.ResetBindings(false);
                }
                
            }
            catch
            {
                MessageBox.Show("Please select movie");
            }
            



        }

        private void OnClickAddMovie(object sender, EventArgs e)
        {
            try
            {

                Movie movie = new Movie(txtMovieName.Text,
                                   txtISBN.Text,
                                   dtReleaseDate.Text,
                                   cbLocation.Text,
                                   cbGenre.Text,
                                   cbRating.Text,
                                   txtDuration.Text,
                                   Double.Parse(txtPrice.Text));

                movies.Add(movie);
                binaryMovies.Add(movie);
          
                source.ResetBindings(false);
            }
            catch
            {
                MessageBox.Show("Please enter valid data");
            }
        }

        //finding from sequential file
        private void OnClickFindMovie(object sender, EventArgs e)
        {
            List<Movie> searchedMovies = new List<Movie>();
            try
            {

                using (StreamReader sr = new StreamReader("SeqMovies.txt"))
                {
                    string[] ar = null;

                    while (!sr.EndOfStream)
                    {
                        string s = sr.ReadLine();
                        ar = s.Split(':');
                        Movie movie = new Movie(ar[0],
                                                ar[1],
                                                ar[2],
                                                ar[3],
                                                ar[4],
                                                ar[5],
                                                ar[6],
                                    Double.Parse(ar[7]));
                        
                        searchedMovies.Add(movie);

                    }


                   

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading Pets.txt due to the following exception: " + ex.Message);
            }

            

            //searching in the list
            searchedMovies = searchedMovies.Where(x => x.MovieName.ToUpper() == txtFindMovie.Text.ToUpper()).ToList();

            try
            {
               // MessageBox.Show("Movie Found");
                setControl(searchedMovies[0]);
            }
            catch
            {
                MessageBox.Show("Nothing matched");
            }
           
   

            
        }

        public void setControl(Movie m)
        {
            txtMovieName.Text = m.MovieName;
            txtISBN.Text = m.ISBNNum;
            txtDuration.Text = m.Duration;
            txtPrice.Text = m.Price.ToString();
            dtReleaseDate.Text = m.ReleaseDate;
            cbGenre.Text = m.Genre;
            cbLocation.Text = m.Location;
            cbRating.Text = m.Rating;
        }

        public void WriteBinaryFile()
        {
            try
            {
                
                using (BinaryWriter bWriter = new BinaryWriter(File.Open("movie.bin", FileMode.Create)))
                {
                    foreach (Movie movie in binaryMovies)
                    {
                        bWriter.Write(movie.ToFileString().PadLeft(NAME_LENGTH).ToCharArray(0, NAME_LENGTH));
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing students.bin due to the following exception: " + ex.Message);
            }
        }

        private void OnClickSaveToBinary(object sender, EventArgs e)
        {
            btnLoadMoviesSeq.Enabled = false;
            btnLoadMoviesSeq.Enabled = false;
            btnFindMovie.Enabled = false;
            WriteBinaryFile();
        }

        public  void ReadBinaryFile()
        {
            try
            {
                // read collection from binary file
                using (BinaryReader bReader = new BinaryReader(File.Open("movie.bin", FileMode.Open)))
                {
                    
                    string[] ar = null;

                    int c = 0;
                    while (bReader.BaseStream.Position != bReader.BaseStream.Length)
                    {
                        bReader.BaseStream.Seek(c * (NAME_LENGTH), SeekOrigin.Begin);
                        string seekName = new string(bReader.ReadChars(NAME_LENGTH));

                        ar = seekName.Split(':');
                        Movie movie = new Movie(ar[0].Trim(),
                                                ar[1],
                                                ar[2],
                                                ar[3],
                                                ar[4],
                                                ar[5],
                                                ar[6],
                                    Double.Parse(ar[7]));

                         binaryMovies.Add(movie);
                         
                        c++;
                    }

                    //changing source from seq -> binary
                    source.DataSource = binaryMovies;
                    lstMovies.DataSource = source;
                    source.ResetBindings(false);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading students.bin due to the following exception: " + ex.Message);
            }
        }

        private void OnClickLoadFromBinary(object sender, EventArgs e)
        {
            btnFindMovie.Enabled = false;
            btnLoadMoviesSeq.Enabled = false;
            btnSaveMovieSeq.Enabled = false;

            ReadBinaryFile();
        }

        private void OnClickFindMovieInBinary(object sender, EventArgs e)
        {
            List<Movie> searchedMoviesBin = new List<Movie>();
            try
            {
                // read collection from binary file
                using (BinaryReader bReader = new BinaryReader(File.Open("movie.bin", FileMode.Open)))
                {

                    string[] ar = null;

                    int c = 0;
                    while (bReader.BaseStream.Position != bReader.BaseStream.Length)
                    {
                        bReader.BaseStream.Seek(c * (NAME_LENGTH), SeekOrigin.Begin);
                        string seekName = new string(bReader.ReadChars(NAME_LENGTH));

                        ar = seekName.Split(':');
                        Movie movie = new Movie(ar[0].Trim(),
                                                ar[1],
                                                ar[2],
                                                ar[3],
                                                ar[4],
                                                ar[5],
                                                ar[6],
                                    Double.Parse(ar[7]));

                        searchedMoviesBin.Add(movie);

                        c++;
                    }

                    
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading students.bin due to the following exception: " + ex.Message);
            }

            searchedMoviesBin = searchedMoviesBin.Where(x => x.MovieName.ToUpper() == txtFindMovie.Text.ToUpper()).ToList();

            try
            {
               
                setControl(searchedMoviesBin[0]);
               
            }
            catch
            {
                MessageBox.Show("Nothing matched");
            }
        }

        private void OnClickSearchByRecord(object sender, EventArgs e)
        {
            try
            {
                // read collection from binary file
                using (BinaryReader bReader = new BinaryReader(File.Open("movie.bin", FileMode.Open)))
                {

                    string[] ar = null;

                   
                        bReader.BaseStream.Seek((int.Parse(txtFindMovie.Text) - 1) * (NAME_LENGTH), SeekOrigin.Begin);
                        string seekName = new string(bReader.ReadChars(NAME_LENGTH));

                        ar = seekName.Split(':');
                        Movie movie = new Movie(ar[0].Trim(),
                                                ar[1],
                                                ar[2],
                                                ar[3],
                                                ar[4],
                                                ar[5],
                                                ar[6],
                                    Double.Parse(ar[7]));


                      setControl(movie);
                      MessageBox.Show(" Record Found");
                       
                    }




                }
            
            catch (Exception ex)
            {
                MessageBox.Show("No Record found");
            }
        }

        private void OnClickShowInfo(object sender, EventArgs e)
        {
            MessageBox.Show("Designed By:\n" + "Inderpreet Singh");
        }
    }
}
