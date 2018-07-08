namespace MovieAppUI
{
    partial class MovieReviewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieReviewForm));
            this.dtReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.lblIsbnNum = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.picMovie = new System.Windows.Forms.PictureBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lstMovies = new System.Windows.Forms.ListBox();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.cbRating = new System.Windows.Forms.ComboBox();
            this.btnLoadMoviesSeq = new System.Windows.Forms.Button();
            this.btnSaveMovieSeq = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFindMovie = new System.Windows.Forms.Button();
            this.txtFindMovie = new System.Windows.Forms.TextBox();
            this.btnSaveToBinary = new System.Windows.Forms.Button();
            this.btnLoadMoviesToBinary = new System.Windows.Forms.Button();
            this.btnFinBinary = new System.Windows.Forms.Button();
            this.btnSearchByRecord = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // dtReleaseDate
            // 
            this.dtReleaseDate.Location = new System.Drawing.Point(172, 243);
            this.dtReleaseDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtReleaseDate.Name = "dtReleaseDate";
            this.dtReleaseDate.Size = new System.Drawing.Size(176, 31);
            this.dtReleaseDate.TabIndex = 0;
            this.toolTip.SetToolTip(this.dtReleaseDate, "Release date for the movie");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Release Date";
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Agency FB", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.Location = new System.Drawing.Point(32, 161);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(90, 26);
            this.lblMovieName.TabIndex = 2;
            this.lblMovieName.Text = "Movie Name";
            // 
            // lblIsbnNum
            // 
            this.lblIsbnNum.AutoSize = true;
            this.lblIsbnNum.Font = new System.Drawing.Font("Agency FB", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsbnNum.Location = new System.Drawing.Point(32, 321);
            this.lblIsbnNum.Name = "lblIsbnNum";
            this.lblIsbnNum.Size = new System.Drawing.Size(64, 26);
            this.lblIsbnNum.TabIndex = 3;
            this.lblIsbnNum.Text = "ISBN No";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Agency FB", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(32, 391);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(67, 26);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Text = "Location";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Agency FB", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(32, 465);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(52, 26);
            this.lblGenre.TabIndex = 5;
            this.lblGenre.Text = "Genre";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Agency FB", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(35, 550);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(54, 26);
            this.lblRating.TabIndex = 6;
            this.lblRating.Text = "Rating";
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(172, 161);
            this.txtMovieName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(176, 31);
            this.txtMovieName.TabIndex = 7;
            this.toolTip.SetToolTip(this.txtMovieName, "Enter movie name");
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(172, 321);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(176, 31);
            this.txtISBN.TabIndex = 8;
            this.toolTip.SetToolTip(this.txtISBN, "ISBN Number (optional)");
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(172, 698);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(176, 31);
            this.txtPrice.TabIndex = 11;
            this.toolTip.SetToolTip(this.txtPrice, "Price of the movie");
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(172, 630);
            this.txtDuration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(176, 31);
            this.txtDuration.TabIndex = 12;
            this.toolTip.SetToolTip(this.txtDuration, "Duration in minute");
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Items.AddRange(new object[] {
            "Action",
            "Biography",
            "Comedy",
            "Drama",
            "Educational",
            "History",
            "Horror",
            "Musical",
            "Mystery",
            "Romance",
            "Sci-Fi",
            "Thriller",
            "Western"});
            this.cbGenre.Location = new System.Drawing.Point(172, 465);
            this.cbGenre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(176, 32);
            this.cbGenre.TabIndex = 14;
            this.cbGenre.Text = "Choose Genre";
            this.toolTip.SetToolTip(this.cbGenre, "Genre of the movie");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.picMovie);
            this.panel1.Location = new System.Drawing.Point(-1, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 122);
            this.panel1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Agency FB", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(363, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(338, 108);
            this.label7.TabIndex = 0;
            this.label7.Text = "Movie Review";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picMovie
            // 
            this.picMovie.Image = global::MovieAppUI.Properties.Resources.Folder_TV_Disney_icon;
            this.picMovie.Location = new System.Drawing.Point(22, 4);
            this.picMovie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picMovie.Name = "picMovie";
            this.picMovie.Size = new System.Drawing.Size(188, 105);
            this.picMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMovie.TabIndex = 18;
            this.picMovie.TabStop = false;
            this.toolTip.SetToolTip(this.picMovie, "Click to display info");
            this.picMovie.Click += new System.EventHandler(this.OnClickShowInfo);
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Agency FB", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(32, 630);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(69, 26);
            this.lblDuration.TabIndex = 16;
            this.lblDuration.Text = "Duration";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Agency FB", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(35, 698);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 26);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Price";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(394, 479);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(185, 65);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Add Movie";
            this.toolTip.SetToolTip(this.btnSubmit, "Add Movie to the list box");
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.OnClickAddMovie);
            // 
            // lstMovies
            // 
            this.lstMovies.FormattingEnabled = true;
            this.lstMovies.ItemHeight = 24;
            this.lstMovies.Location = new System.Drawing.Point(376, 161);
            this.lstMovies.Name = "lstMovies";
            this.lstMovies.Size = new System.Drawing.Size(617, 292);
            this.lstMovies.TabIndex = 20;
            this.toolTip.SetToolTip(this.lstMovies, "List of movies");
            this.lstMovies.SelectedIndexChanged += new System.EventHandler(this.lstMovies_SelectedIndexChanged);
            // 
            // cbLocation
            // 
            this.cbLocation.AutoCompleteCustomSource.AddRange(new string[] {
            "Canada",
            "International"});
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Items.AddRange(new object[] {
            "Canada",
            "International"});
            this.cbLocation.Location = new System.Drawing.Point(172, 391);
            this.cbLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(176, 32);
            this.cbLocation.TabIndex = 21;
            this.cbLocation.Text = "Choose Location";
            this.toolTip.SetToolTip(this.cbLocation, "Location for the movie");
            // 
            // cbRating
            // 
            this.cbRating.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbRating.FormattingEnabled = true;
            this.cbRating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbRating.Location = new System.Drawing.Point(172, 550);
            this.cbRating.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbRating.Name = "cbRating";
            this.cbRating.Size = new System.Drawing.Size(176, 32);
            this.cbRating.TabIndex = 22;
            this.cbRating.Text = "Choose Rating";
            this.toolTip.SetToolTip(this.cbRating, "Choose the rating btwwen 1 to 5");
            // 
            // btnLoadMoviesSeq
            // 
            this.btnLoadMoviesSeq.Location = new System.Drawing.Point(394, 657);
            this.btnLoadMoviesSeq.Name = "btnLoadMoviesSeq";
            this.btnLoadMoviesSeq.Size = new System.Drawing.Size(185, 94);
            this.btnLoadMoviesSeq.TabIndex = 23;
            this.btnLoadMoviesSeq.Text = "Load Movies From Sequential";
            this.toolTip.SetToolTip(this.btnLoadMoviesSeq, "Read from sequential file");
            this.btnLoadMoviesSeq.UseVisualStyleBackColor = true;
            this.btnLoadMoviesSeq.Click += new System.EventHandler(this.OnClickLoadFromSequentialFile);
            // 
            // btnSaveMovieSeq
            // 
            this.btnSaveMovieSeq.Location = new System.Drawing.Point(394, 569);
            this.btnSaveMovieSeq.Name = "btnSaveMovieSeq";
            this.btnSaveMovieSeq.Size = new System.Drawing.Size(185, 65);
            this.btnSaveMovieSeq.TabIndex = 24;
            this.btnSaveMovieSeq.Text = "Save Movies To Sequential";
            this.toolTip.SetToolTip(this.btnSaveMovieSeq, "Save movies to sequential file");
            this.btnSaveMovieSeq.UseVisualStyleBackColor = true;
            this.btnSaveMovieSeq.Click += new System.EventHandler(this.OnClickSaveToSequentialFile);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(599, 479);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(194, 65);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update Movie";
            this.toolTip.SetToolTip(this.btnUpdate, "Update movie");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.OnClickUpdateMovie);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(808, 479);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(185, 65);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete Movie";
            this.toolTip.SetToolTip(this.btnDelete, "Delete the movie");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.OnClickDeleteMovie);
            // 
            // btnFindMovie
            // 
            this.btnFindMovie.Location = new System.Drawing.Point(599, 693);
            this.btnFindMovie.Name = "btnFindMovie";
            this.btnFindMovie.Size = new System.Drawing.Size(92, 58);
            this.btnFindMovie.TabIndex = 27;
            this.btnFindMovie.Text = "Find In Seq By Name";
            this.toolTip.SetToolTip(this.btnFindMovie, "Click to find movie in sequential file");
            this.btnFindMovie.UseVisualStyleBackColor = true;
            this.btnFindMovie.Click += new System.EventHandler(this.OnClickFindMovie);
            // 
            // txtFindMovie
            // 
            this.txtFindMovie.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtFindMovie.Location = new System.Drawing.Point(599, 657);
            this.txtFindMovie.Name = "txtFindMovie";
            this.txtFindMovie.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtFindMovie.Size = new System.Drawing.Size(194, 31);
            this.txtFindMovie.TabIndex = 28;
            this.toolTip.SetToolTip(this.txtFindMovie, "Enter movie name or record number to find ");
            // 
            // btnSaveToBinary
            // 
            this.btnSaveToBinary.Location = new System.Drawing.Point(599, 569);
            this.btnSaveToBinary.Name = "btnSaveToBinary";
            this.btnSaveToBinary.Size = new System.Drawing.Size(194, 65);
            this.btnSaveToBinary.TabIndex = 29;
            this.btnSaveToBinary.Text = "Save Movies To Binary File";
            this.toolTip.SetToolTip(this.btnSaveToBinary, "Save movies to binary file");
            this.btnSaveToBinary.UseVisualStyleBackColor = true;
            this.btnSaveToBinary.Click += new System.EventHandler(this.OnClickSaveToBinary);
            // 
            // btnLoadMoviesToBinary
            // 
            this.btnLoadMoviesToBinary.Location = new System.Drawing.Point(808, 569);
            this.btnLoadMoviesToBinary.Name = "btnLoadMoviesToBinary";
            this.btnLoadMoviesToBinary.Size = new System.Drawing.Size(185, 65);
            this.btnLoadMoviesToBinary.TabIndex = 30;
            this.btnLoadMoviesToBinary.Text = "Load Movies From Binary File";
            this.toolTip.SetToolTip(this.btnLoadMoviesToBinary, "Read from binary file");
            this.btnLoadMoviesToBinary.UseVisualStyleBackColor = true;
            this.btnLoadMoviesToBinary.Click += new System.EventHandler(this.OnClickLoadFromBinary);
            // 
            // btnFinBinary
            // 
            this.btnFinBinary.Location = new System.Drawing.Point(697, 693);
            this.btnFinBinary.Name = "btnFinBinary";
            this.btnFinBinary.Size = new System.Drawing.Size(99, 58);
            this.btnFinBinary.TabIndex = 31;
            this.btnFinBinary.Text = "Find In Binary By Name";
            this.toolTip.SetToolTip(this.btnFinBinary, "Find movie in binary file");
            this.btnFinBinary.UseVisualStyleBackColor = true;
            this.btnFinBinary.Click += new System.EventHandler(this.OnClickFindMovieInBinary);
            // 
            // btnSearchByRecord
            // 
            this.btnSearchByRecord.Location = new System.Drawing.Point(808, 657);
            this.btnSearchByRecord.Name = "btnSearchByRecord";
            this.btnSearchByRecord.Size = new System.Drawing.Size(185, 94);
            this.btnSearchByRecord.TabIndex = 32;
            this.btnSearchByRecord.Text = "Search By Record";
            this.toolTip.SetToolTip(this.btnSearchByRecord, "Search by record number in random file");
            this.btnSearchByRecord.UseVisualStyleBackColor = true;
            this.btnSearchByRecord.Click += new System.EventHandler(this.OnClickSearchByRecord);
            // 
            // MovieReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 797);
            this.Controls.Add(this.btnSearchByRecord);
            this.Controls.Add(this.btnFinBinary);
            this.Controls.Add(this.btnLoadMoviesToBinary);
            this.Controls.Add(this.btnSaveToBinary);
            this.Controls.Add(this.txtFindMovie);
            this.Controls.Add(this.btnFindMovie);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSaveMovieSeq);
            this.Controls.Add(this.btnLoadMoviesSeq);
            this.Controls.Add(this.cbRating);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.lstMovies);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblIsbnNum);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtReleaseDate);
            this.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MovieReviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Review Form";
            this.Load += new System.EventHandler(this.MovieReviewForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtReleaseDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label lblIsbnNum;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.PictureBox picMovie;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox lstMovies;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.ComboBox cbRating;
        private System.Windows.Forms.Button btnLoadMoviesSeq;
        private System.Windows.Forms.Button btnSaveMovieSeq;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFindMovie;
        private System.Windows.Forms.TextBox txtFindMovie;
        private System.Windows.Forms.Button btnSaveToBinary;
        private System.Windows.Forms.Button btnLoadMoviesToBinary;
        private System.Windows.Forms.Button btnFinBinary;
        private System.Windows.Forms.Button btnSearchByRecord;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

