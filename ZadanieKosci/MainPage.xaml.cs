namespace ZadanieKosci
{
    public partial class MainPage : ContentPage
    {
        static private int suma = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnRzucClicked(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] kosci = new int[6];
            kosci[0] = 0;
            string[] sourceZdjec = new string[6];
            sourceZdjec[0] = "";
            int sumaLosu = 0;

            for (int i = 1; i <= 5; i++)
            {
                kosci[i] = rnd.Next(1, 6);
                string zdj = "kosc" + kosci[i].ToString() + ".png";
                sourceZdjec[i] = zdj;
                sumaLosu += kosci[i];
            }
            ImgKosc1.Source = sourceZdjec[1];
            ImgKosc2.Source = sourceZdjec[2];
            ImgKosc3.Source = sourceZdjec[3];
            ImgKosc4.Source = sourceZdjec[4];
            ImgKosc5.Source = sourceZdjec[5];

            LblWynikLos.Text = $"Wynik tego losowania: {sumaLosu}";
            suma += sumaLosu;
            LblWynikGra.Text = $"Wynik całej gry: {suma}";
            
        }
        private void OnResetClicked(object sender, EventArgs e)
        {
            ImgKosc1.Source = "empty.png";
            ImgKosc2.Source = "empty.png";
            ImgKosc3.Source = "empty.png";
            ImgKosc4.Source = "empty.png";
            ImgKosc5.Source = "empty.png";
            suma = 0;
            LblWynikLos.Text = $"Wynik tego losowania: 0";
            LblWynikGra.Text = $"Wynik całej gry: 0";
        }
    }

}
