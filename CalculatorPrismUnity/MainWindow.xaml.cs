using Prism.Commands;
using System.Windows;

namespace CalculatorPrismUnity
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public new string Title = "MVVM Calculator";
        private string _calculatorText;
        public string CalculatorText
        {
            get => _calculatorText;
            set => SetProperty(ref _calculatorText, value);
        }

        private void SetProperty(ref string calculatorText, string value)
        {
            calculatorText = value;
        }
        public DelegateCommand<string> AddNumberCommand { get; set; }
        void RegisterCommands()
        {
            AddNumberCommand = new DelegateCommand<string>(AddNumber);
        }

        private void AddNumber(string obj)
        {
            CalculatorText += "5";
        }
    }
}
