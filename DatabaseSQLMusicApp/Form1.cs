namespace DatabaseSQLMusicApp
{
    public partial class Form1 : Form
    {
        //One of the tricky parts of C# application or Windows Forms is called a Binding Source. So Binding Source is the ability to connect 
        //a list of items (such as albums to the control (grid control). I am going to define it here.
        /// <summary>
        /// Binding source is the class name that is allowed to connect these two BindingSource to albumBindingSource. 
        /// The Binding source will be renamed since you will have one for the album and another for the tracks
        /// </summary>
        
        BindingSource albumbBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Add the AlbumDAO class and initialise it with a new instance of the class. So, when you click the button it will
            //create a brand new list from scratch everytime we click it.
            AlbumDAO albumDAO = new AlbumDAO();

            //as soon as you have the list created you are going to fill it with some data.So let's create a new album.
            Album a1 = new Album
            {
                ID = 1,
                AlbumName = "My first Album",
                ArtistName = "Irtaza Chohan",
                Year = 2024,
                ImageUrl = "Nothing yet",
                Description = "Description will go here!"
            };
            //Lets create another item in the list.
            Album a2 = new Album
            {
                ID = 1,
                AlbumName = "My second Album",
                ArtistName = "Khadijah Chohan",
                Year = 1986,
                ImageUrl = "Nothing yet",
                Description = "Description will go here!"
            };
            //Now add the first song to the AlbumDAO. Now in AlbumDAO.cs you need to make the List PUBLIC otherwise the below will fail.
            albumDAO.albums.Add(a1);
            albumDAO.albums.Add(a2);

            //Now you want to associate this list with the control on the screen. See top of summary for notes.
            //Back to down here to make the Binding source work we are going to the click button action
            // connect the list to the grid view control - this should allow the grid source to show the new albums.

            albumbBindingSource.DataSource = albumDAO.albums;

            //Last bit is to tell the grid view the BindingSource is associated with it.

            dataGridView1.DataSource = albumbBindingSource;
        }
    }
}
