namespace campo_minado {
    public partial class MainPage: ContentPage {
        public MainPage() 
            
            {
            InitializeComponent();
        }

        private void BTN_NovoJogo(object sender, EventArgs e) 
            
            {
            DisplayAlert("Novo Jogo", "Um novo jogo foi iniciado", "ok");
            return;
        }

        private void BTN_Salvos(object sender, EventArgs e) 
            
            {
            DisplayAlert("Jogos Salvos", "Mostrando jogos salvos", "ok");
            return;

        }
    }

}
