using ChuckNorrisAPI;

namespace ChuckNorrisAPI_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Joke j = await ChuckNorrisClient.GetRandomJoke();
            jokeGBx.Text = j.JokeText;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            IEnumerable<string> categories= await ChuckNorrisClient.GetCategories();

            jokeCategoriesCbBx.DataSource = categories;
        }
    }
}