namespace SalarioMaui5834157
{
    public partial class MainPage : ContentPage
    {
        private List<Trabajador> trabajadores = new List<Trabajador>();
        private int currentId = 1;
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            TrabajadoresListView.ItemsSource = trabajadores;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
           
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            foreach (var trabajador in trabajadores)
            {
                trabajador.Sueldo *= 1.10m;
            }

            TrabajadoresListView.ItemsSource = null;
            TrabajadoresListView.ItemsSource = trabajadores;
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NombreEntry.Text) && decimal.TryParse(SueldoEntry.Text, out decimal sueldoDecimal))
            {
                var trabajador = new Trabajador
                {
                    Id = currentId++,
                    Nombre = NombreEntry.Text,
                    Sueldo = sueldoDecimal
                };

                trabajadores.Add(trabajador);
                TrabajadoresListView.ItemsSource = null;
                TrabajadoresListView.ItemsSource = trabajadores;

                NombreEntry.Text = string.Empty;
                SueldoEntry.Text = string.Empty;
            }
            else
            {
                DisplayAlert("Error", "Por favor, ingrese un nombre y un sueldo válidos.", "OK");
            }

        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            if (TrabajadoresListView.SelectedItem is Trabajador trabajador)
            {
                trabajadores.Remove(trabajador);
                TrabajadoresListView.ItemsSource = null;
                TrabajadoresListView.ItemsSource = trabajadores;
            }
            else
            {
                DisplayAlert("Error", "Por favor, seleccione un trabajador para eliminar.", "OK");
            }

        }
    }

}
