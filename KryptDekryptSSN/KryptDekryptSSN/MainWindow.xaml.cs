using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace KryptDekryptSSN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


       
        

        private int PValueLength = 3;
        private int QValueLength = 3;
        private string PlainText;
        private BigInteger P;
        private BigInteger Q;
        private BigInteger E;
        private BigInteger D;
        private BigInteger N;
        private BackgroundWorker worker;
        
       
        
      

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //återställl värdet på progressbar
            ProgressBar.Value = 0;

            //Visa att programmet arbetar 
            ProgressBar.IsIndeterminate = true;

            //Visa att programmet jobbar status_label
            Status_Label.Content = "Genererar Nycklar";

            //Hämta angivna längd p/q värden från Sliders. 
            this.PValueLength = (int)PSlider.Value;
            this.QValueLength = (int)QSlider.Value;



            //Hämta texten som ska krypteras från textrutan. 
            PlainText = PlainTextBox.Text;


             //en backgrund arbetare för att lösa lite matte  =) 
             worker = new BackgroundWorker();

            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true; 
          
            
            //kallar på worker_DoWork metoden. för att få den att jobba, sen sätter vad som ska hända när workern är färdig.
            worker.DoWork += worker_DoWork;

            worker.RunWorkerCompleted += worker_RunWorkerCompleted;

            worker.ProgressChanged += worker_ProgressChanged;

            worker.RunWorkerAsync();

            //stäng av kryptera knappen
            Btn_Crypt.IsEnabled = false;

          

        }



       private void worker_DoWork(object sender, DoWorkEventArgs e)
        {

           //Generera nycklar och primtal i backgrunden 
            Generate_Primes_Keys();



        }



        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            //Visa status vad programmet gör Status_label
            Status_Label.Content = "Krypterar";

            //Kryptera och Dekryptera meddelandet efter arbetaren har genererat D,E,N. 
            Crypt_Decrypt();

            //visa att programmet är färdig.
            ProgressBar.Value = 100;
            //Visa att programmet har slutat arbeta 
            ProgressBar.IsIndeterminate = false;

            //återställ kryptera knappen.
            Btn_Crypt.IsEnabled = true;

            //Visa värdet på N 
            N_ValueTextBox.Content = N;

            //visa värdet på E
            E_ValueTextBox.Content = E;

            //Visa värdet på D
            D_ValueTextBox.Content = D;

            //Visa värdet på Φ(N) 
            Phin_ValueTextBox.Content = GenerateKeys.Phin;

            //Visa värdet på P 
            P_ValueTextBox.Content = P;

            //Visa värdet på Q
            Q_ValueTextBox.Content = Q;


            //Visa status vad programmet gör Status_label
            Status_Label.Content = "Redo";

        }


        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            ProgressBar.Value = e.ProgressPercentage;


        }



        private void Generate_Primes_Keys()
        {
           
            

            //Skapa en generator object för att generera Primtalen
            PrimeNumberGenerator PrimeGenerator = new PrimeNumberGenerator();

            //Skapa en lista och ge generatorn de önskade längderna på P och Q
            List<BigInteger> PandQ = PrimeGenerator.GeneratePrimes(PValueLength, QValueLength);

            //Hämta de genererade p och q värden från generatorn och spara dem i int variabler. 
            BigInteger p = PandQ.ElementAt(0);
            BigInteger q = PandQ.ElementAt(1);

            //Lagra p och q för senare användning
            this.P = p;
            this.Q = q;

            //Skapa en E,D och N generator. 
            GenerateKeys PublicPrivteKeyGenerator = new GenerateKeys(p, q);

            //generera värden och lagra dem i variabler för senare användning.
            PublicPrivteKeyGenerator.GeneratePublicPrivatePair();

           this.E = PublicPrivteKeyGenerator.getPublicKeyE;

           this.D = PublicPrivteKeyGenerator.getPrivateKeyD;

           this.N = PublicPrivteKeyGenerator.getN;

           

        }


        private void Crypt_Decrypt()
        {

           

            //skpa en krypterings objekt
            CryptMsg RSAEnrypt = new CryptMsg();

            //Kalla på krypterings algoritmen och ge den klartext, E och N. 
            List<BigInteger> Krypterat = RSAEnrypt.Crypt(PlainText, E, N);

            //Bygg upp en text av det som är krypterat.
            string krypteratt = "";

            foreach (int i in Krypterat)
            {
                krypteratt += i;

            }


            //Visa den krypterade texten.
            CryptedTextBox.Text = krypteratt;


            DecryptMsg rsadec = new DecryptMsg();


            String Dekrypterat = rsadec.DeCrypt(Krypterat, D, N);

            //Visa texten efter dekryptering 
            DeCryptedTextBox.Text = Dekrypterat;




        }

        private void Btn_Abort_Click(object sender, RoutedEventArgs e)
        {

            //Döda arbetaren och återställ värden
            worker.CancelAsync();
            ProgressBar.IsIndeterminate = false;
            ProgressBar.Value = 0;
            CryptedTextBox.Text = "Krypterad text";
            DeCryptedTextBox.Text = "Dekrypterad text";
            N_ValueTextBox.Content = "N/A";
            E_ValueTextBox.Content = "N/A";
            D_ValueTextBox.Content = "N/A";
            Phin_ValueTextBox.Content = "N/A";
            P_ValueTextBox.Content = "N/A";
            Q_ValueTextBox.Content = "N/A";
            Status_Label.Content = "Redo";
            Btn_Crypt.IsEnabled = true;

            

        }

        private void Om_Click(object sender, RoutedEventArgs e)
        {
            OmWindow window = new OmWindow();
            window.ShowDialog();
        }




    }
}

