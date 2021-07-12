using System;
using System.Collections.Generic;
using System.Linq;
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

namespace interfejs_pizzy
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double cena = 0;
        string pizza = "";
        string wielkosc = "";
        string poziom_ostrosci = "";
        string dodatki = "";
        string dostawa = "";

        void podsumowanie_change()
        {
            if(cena > 30)
            {
                dostawa = "GRATIS";
            }
            else
            {
                dostawa = "5";
                cena += 5;
            }
            podusmowanie.Content = "Pizza: " + pizza + "\nWielkość: " + wielkosc + "\nDodatki: " + dodatki + "\nCena: " + cena + "\nDostawa: " + dostawa;
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void checked_add_ser(object sender, RoutedEventArgs e)
        {            
            if(wielkosc == "Mała")
            {
                cena += 3;
                dodatki = dodatki + "ser ";
            }
            else if(wielkosc == "Średnia")
            {
                cena += 4;
                dodatki = dodatki + "ser ";
            }
            else if (wielkosc == "Duża")
            {
                cena += 5;
                dodatki = dodatki + "ser ";
            }
            else
            {
                MessageBox.Show("Wybierz wielkość pizzy zanim dodasz dodatek");
            }
            podsumowanie_change();
        }

        private void unchecked_add_ser(object sender, RoutedEventArgs e)
        {
            string[] tmp = dodatki.Split();
            dodatki = "";
            cena -= 3;
            for(int i=0; i < tmp.Length - 1; i++)
            {
                if (tmp[i] == "ser") tmp[i] = "";
                dodatki = dodatki + tmp[i] + " ";
            }
            podsumowanie_change();
        }

        private void checked_add_bekon(object sender, RoutedEventArgs e)
        {
            if (wielkosc == "Mała")
            {
                cena += 3;
                dodatki = dodatki + "bekon ";
            }
            else if (wielkosc == "Średnia")
            {
                cena += 4;
                dodatki = dodatki + "bekon ";
            }
            else if (wielkosc == "Duża")
            {
                cena += 5;
                dodatki = dodatki + "bekon ";
            }
            else
            {
                MessageBox.Show("Wybierz wielkość pizzy zanim dodasz dodatek");
            }
            podsumowanie_change();
        }

        private void unchecked_add_bekon(object sender, RoutedEventArgs e)
        {
            string[] tmp = dodatki.Split();
            dodatki = "";
            cena -= 3;
            for (int i = 0; i < tmp.Length - 1; i++)
            {
                if (tmp[i] == "bekon") tmp[i] = "";
                dodatki = dodatki + tmp[i] + " ";
            }
            podsumowanie_change();
        }

        private void checked_add_pieczarki(object sender, RoutedEventArgs e)
        {
            if (wielkosc == "Mała")
            {
                cena += 3;
                dodatki = dodatki + "pieczarki ";
            }
            else if (wielkosc == "Średnia")
            {
                cena += 4;
                dodatki = dodatki + "pieczarki ";
            }
            else if (wielkosc == "Duża")
            {
                cena += 5;
                dodatki = dodatki + "pieczarki ";
            }
            else
            {
                MessageBox.Show("Wybierz wielkość pizzy zanim dodasz dodatek");
            }
            podsumowanie_change();
        }

        private void unchecked_add_pieczarki(object sender, RoutedEventArgs e)
        {
            string[] tmp = dodatki.Split();
            dodatki = "";
            cena -= 3;
            for (int i = 0; i < tmp.Length - 1; i++)
            {
                if (tmp[i] == "pieczarki") tmp[i] = "";
                dodatki = dodatki + tmp[i] + " ";
            }
            podsumowanie_change();
        }

        private void checked_add_papryka(object sender, RoutedEventArgs e)
        {
            if (wielkosc == "Mała")
            {
                cena += 3;
                dodatki = dodatki + "papryka ";
            }
            else if (wielkosc == "Średnia")
            {
                cena += 4;
                dodatki = dodatki + "papryka ";
            }
            else if (wielkosc == "Duża")
            {
                cena += 5;
                dodatki = dodatki + "papryka ";
            }
            else
            {
                MessageBox.Show("Wybierz wielkość pizzy zanim dodasz dodatek");
            }
            podsumowanie_change();
        }

        private void unchecked_add_papryka(object sender, RoutedEventArgs e)
        {
            string[] tmp = dodatki.Split();
            dodatki = "";
            cena -= 3;
            for (int i = 0; i < tmp.Length - 1; i++)
            {
                if (tmp[i] == "papryka") tmp[i] = "";
                dodatki = dodatki + tmp[i] + " ";
            }
            podsumowanie_change();
        }

        private void checked_add_salami(object sender, RoutedEventArgs e)
        {
            if (wielkosc == "Mała")
            {
                cena += 3;
                dodatki = dodatki + "salami ";
            }
            else if (wielkosc == "Średnia")
            {
                cena += 4;
                dodatki = dodatki + "salami ";
            }
            else if (wielkosc == "Duża")
            {
                cena += 5;
                dodatki = dodatki + "salami ";
            }
            else
            {
                MessageBox.Show("Wybierz wielkość pizzy zanim dodasz dodatek");
            }
            podsumowanie_change();
        }

        private void unchecked_add_salami(object sender, RoutedEventArgs e)
        {
            string[] tmp = dodatki.Split();
            dodatki = "";
            cena -= 3;
            for (int i = 0; i < tmp.Length - 1; i++)
            {
                if (tmp[i] == "salami") tmp[i] = "";
                dodatki = dodatki + tmp[i] + " ";
            }
            podsumowanie_change();
        }

        private void checked_add_szynka(object sender, RoutedEventArgs e)
        {
            if (wielkosc == "Mała")
            {
                cena += 3;
                dodatki = dodatki + "szynka ";
            }
            else if (wielkosc == "Średnia")
            {
                cena += 4;
                dodatki = dodatki + "szynka ";
            }
            else if (wielkosc == "Duża")
            {
                cena += 5;
                dodatki = dodatki + "szynka ";
            }
            else
            {
                MessageBox.Show("Wybierz wielkość pizzy zanim dodasz dodatek");
            }
            podsumowanie_change();
        }

        private void unchecked_add_szynka(object sender, RoutedEventArgs e)
        {
            string[] tmp = dodatki.Split();
            dodatki = "";
            cena -= 3;
            for (int i = 0; i < tmp.Length - 1; i++)
            {
                if (tmp[i] == "szynka") tmp[i] = "";
                dodatki = dodatki + tmp[i] + " ";
            }
            podsumowanie_change();
        }

        private void checked_add_paprykaJalapeno(object sender, RoutedEventArgs e)
        {
            if (wielkosc == "Mała")
            {
                cena += 3;
                dodatki = dodatki + "paprykaJalapeno ";
            }
            else if (wielkosc == "Średnia")
            {
                cena += 4;
                dodatki = dodatki + "paprykaJalapeno ";
            }
            else if (wielkosc == "Duża")
            {
                cena += 5;
                dodatki = dodatki + "paprykaJalapeno ";
            }
            else
            {
                MessageBox.Show("Wybierz wielkość pizzy zanim dodasz dodatek");
            }
            podsumowanie_change();
        }

        private void unchecked_add_paprykaJalapeno(object sender, RoutedEventArgs e)
        {
            string[] tmp = dodatki.Split();
            dodatki = "";
            cena -= 3;
            for (int i = 0; i < tmp.Length - 1; i++)
            {
                if (tmp[i] == "paprykaJalapeno") tmp[i] = "";
                dodatki = dodatki + tmp[i] + " ";
            }
            podsumowanie_change();
        }

        private void checked_pizza_margerita(object sender, RoutedEventArgs e)
        {
            pizza = "Margerita";
            podsumowanie_change();
        }

        private void checked_pizza_meksykanska(object sender, RoutedEventArgs e)
        {
            pizza = "Meksykanska";
            podsumowanie_change();
        }

        private void checked_pizza_pepperoni(object sender, RoutedEventArgs e)
        {
            pizza = "Pepperoni";
            podsumowanie_change();
        }

        private void checked_pizza_capriciosa(object sender, RoutedEventArgs e)
        {
            pizza = "Capriciosa";
            podsumowanie_change();
        }

        private void checked_pizza_americano(object sender, RoutedEventArgs e)
        {
            pizza = "Americano";
            podsumowanie_change();
        }

        private void checked_size_small(object sender, RoutedEventArgs e)
        {
            wielkosc = "Mała";
            cena += 20;
            podsumowanie_change();
        }

        private void checked_size_medium(object sender, RoutedEventArgs e)
        {
            wielkosc = "Średnia";
            cena += 35;
            podsumowanie_change();
        }

        private void checked_size_large(object sender, RoutedEventArgs e)
        {
            wielkosc = "Duża";
            cena += 50;
            podsumowanie_change();
        }

        private void unchecked_size_small(object sender, RoutedEventArgs e)
        {
            cena -= 25;
            podsumowanie_change();
        }

        private void unchecked_size_medium(object sender, RoutedEventArgs e)
        {
            cena -= 35;
            podsumowanie_change();
        }

        private void unchecked_size_large(object sender, RoutedEventArgs e)
        {
            cena -= 50;
            podsumowanie_change();
        }

        private void hot_changed(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int value = (int)ostrosc.Value;
            switch (value)
            {
                case 1:
                    poziom_ostrosci = "Łagodna";
                    break;
                case 2:
                    poziom_ostrosci = "Lekko pikantna";
                    break;
                case 3:
                    poziom_ostrosci = "Pikantna";
                    break;
                case 4:
                    poziom_ostrosci = "Diabelsko pikantna";
                    break;
                case 5:
                    poziom_ostrosci = "Zapiecze dwa razy";
                    break;
            }
            l1.Content = poziom_ostrosci;
            //podsumowanie_change();
        }

        private void uwagi_gotfocus(object sender, RoutedEventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.Text = string.Empty;
            t.GotFocus -= uwagi_gotfocus;
        }

        private void zamow_click(object sender, RoutedEventArgs e)
        {
            if (pizza == "")
            {
                MessageBox.Show("Wybierz pizze zanim złożysz zamówienie");
            }
            else
            {
                if (wielkosc == "")
                {
                    MessageBox.Show("Wybierz wielkość pizzy zanim złożysz zamówienie");
                }
                else
                {
                    string uwg = uwagi.Text;
                    if (uwg == "Uwagi do zamówienia:") uwg = "Brak";
                    string wiadomosc = "Zamawiasz: " + pizza + " " + wielkosc + " " + poziom_ostrosci + '\n' + "Dodatki: " + dodatki + '\n' + "cena: " + cena + " (dostawa: " + dostawa + ')' + '\n' + "uwagi do zamówienia : " + uwg;
                    MessageBox.Show(wiadomosc);                    
                }
            }
        }
    }
}
