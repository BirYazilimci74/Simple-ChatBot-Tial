using ChatBot.API;

namespace ChatBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            APIOperations operations = new APIOperations(new HttpClient());

            if (rTbxPrompt.Text == string.Empty)
            {
                lblResponse.Text = "Please enter a prompt to Complate";
                return;
            }

            string response = await operations.GetResponseAsync(rTbxPrompt.Text);

            lblResponse.Text = response;
        }
    }
}
