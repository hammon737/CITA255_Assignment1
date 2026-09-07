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
            float fahrenheitNumber = float.Parse(fahrenheit.Text);
            float celsius = (fahrenheitNumber - 32) * 5 / 9;
            celsiusLabel.Text = $"This temperature in Celsius is {celsius:N1} degrees.";
        }
    }
}