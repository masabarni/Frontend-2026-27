using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Szamologep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string szam1 = "";
        private string szam2 = "";
        private string muvelet = "";
        private string eredmeny = "";

        public MainWindow()
        {
            InitializeComponent();
        }


        public void NumberHandler(string displayText, string numberValue)
        {
                //Üres a kijelző - vagyis 0 van rajta
                if (displayText == "0")
                {
                    display.Text = numberValue;
                }
                else //Amikor már nem üres a kijelző
                {
                    display.Text = display.Text + numberValue;
                }

        }

        public  void PointHandler(string displayText, string pointValue)
        {
            if (displayText == "0")
            {
                display.Text = display.Text + pointValue;
            }
            else
            {
                if(!display.Text.Contains(pointValue))
                {
                    display.Text = display.Text +pointValue;
                }
            }
        }

        public void OperationHandler(string displayText, string operationValue)
        {
            szam2 = display.Text;

            int value1 = Convert.ToInt32(szam1);
            int value2 = Convert.ToInt32(szam2);
            double eredmeny = 0;

            switch(operationValue)
            {
                case "+":
                    eredmeny = value1 + value2;
                    break;

                case "-":
                    eredmeny = value1 - value2;
                    break;

                case "×":
                    eredmeny = value1 * value2;
                    break;

                case "÷":
                    eredmeny = (double)value1 / (double)value2;
                    break;

                case "⅟x":
                    eredmeny = 1.0 / value1;
                    break;

                case "x²":
                    eredmeny = value1 * value2;
                    break;

                    
            }

            this.eredmeny = eredmeny.ToString();

            display.Text = this.eredmeny;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Átalakitjuk Button tipussá
            Button btn = (Button)sender;
            string displayText = display.Text;

            switch (btn.Content.ToString())
            {
                case "0":
                    NumberHandler(displayText,"0");
                    break;

                case "1":
                    NumberHandler(displayText, "1");
                    break;

                case "2":
                    NumberHandler(displayText, "2");
                    break;

                case "3":
                    NumberHandler(displayText, "3");
                    break;

                case "4":
                    NumberHandler(displayText, "4");
                    break;

                case "5":
                    NumberHandler(displayText, "5");
                    break;

                case "6":
                    NumberHandler(displayText, "6");
                    break;

                case "7":
                    NumberHandler(displayText, "7");
                    break;

                case "8":
                    NumberHandler(displayText, "8");
                    break;

                case "9":
                    NumberHandler(displayText, "9");
                    break;

                case ",":
                    PointHandler(displayText,",");
                    break;
            }
        }

        private void Button_Click_Operation(object sender, RoutedEventArgs e)
        {
            //Átalakitjuk Button tipussá
            Button btn = (Button)sender;

            switch (btn.Content.ToString())
            {

                case "+":
                    szam1 = display.Text;
                    muvelet = "+";
                    display.Text = "0";
                    break;


                case "-":
                    szam1 = display.Text;
                    muvelet = "-";
                    display.Text = "0";
                    break;


                case "×":
                    szam1 = display.Text;
                    muvelet = "×";
                    display.Text = "0";
                    break;


                case "÷":
                    szam1 = display.Text;
                    muvelet = "÷";
                    display.Text = "0";
                    break;


                case "x²":
                    szam1 = display.Text;
                    muvelet = "x²";
                    OperationHandler(display.Text, this.muvelet);
                    break;


                case "C":
                    display.Text = "0";
                    break;


                case "⅟x":
                    szam1 = display.Text;
                    muvelet = "⅟x";
                    OperationHandler(display.Text, this.muvelet);
                    break;

                case "=":
                    OperationHandler(display.Text, this.muvelet);
                    break;
            }
        }
    }
}