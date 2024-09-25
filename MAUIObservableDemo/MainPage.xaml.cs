using System.Collections.ObjectModel;

namespace MAUIObservableDemo
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<string> observableList = new ObservableCollection<string>();

        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnLoadPanini_Clicked(object sender, EventArgs e)
        {
            observableList.Clear();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                observableList.Add($"Panino {random.Next(1, 10)}");
            }
            LstPanini.ItemsSource = observableList;
        }
    }

}
