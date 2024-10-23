namespace VetApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
               
        private void sWiek_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int wiek = (int)sWiek.Value;
            lWiek.Text = wiek.ToString();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string wlasciel = eWlasciel.Text;
            string gatunek = zwierze.SelectedItem.ToString();
            /*
            if (Pies.IsChecked)
            {
                gatunek = "Pies";
            }
            if (Kot.IsChecked)
            {
                gatunek = "Kot";
            }
            if (Swinka.IsChecked)
            {
                gatunek = "Świnka Morska";
            }
            */
            int wiek = (int)sWiek.Value;
            string cel = eCel.Text;
            string czas = tCzas.Time.ToString();


            string message = $"Imię i nazwisko właściciela: {wlasciel}, Gatunek: {gatunek}, Wiek: {wiek}, Cel wizyty: {cel}, Czas wizyty: {czas}";
            DisplayAlert("Informacje o wizycie", message, "OK");
        }

        private void zwierze_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            string wybraneZwierze = zwierze.SelectedItem.ToString();

            int maxValue = 0;
            switch (wybraneZwierze)
                {
                    case "Pies":
                        maxValue = 18;
                        break;
                    case "Kot":
                        maxValue = 20;
                        break;
                    case "Świnka morska":
                        maxValue = 9;
                        break;
            }
            sWiek.Maximum = maxValue;
        }
    }
    }


