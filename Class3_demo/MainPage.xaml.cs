namespace Class3_demo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Numbers(object sender, EventArgs e)
        {
            float FarenheitNumber = float.Parse(Farenheit.Text);
            float celsius = (FarenheitNumber - 32) * 5 / 9;
            celseusLabel.Text = $"This temperature in Celsius is {celsius:N1} degrees.";
        }
    }
}