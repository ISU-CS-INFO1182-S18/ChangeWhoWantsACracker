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

namespace PolyFaces {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            Person[] people = new Person[5];
            people[0] = new SuperHero("Jon", "Holmes");
            people[1] = new Villian() { FirstName = "Bill", LastName = "Gates" };
            people[2] = new Citizen() { FirstName = "Mike", LastName = "Wazowski" };
            people[3] = new MegaHero("Mega", "Mind");
            people[4] = new Villian();

            for (int i = 0; i < people.Length; i++) {
                Person p = people[i];
                string s = p.Sing();
                Type t = p.GetType();
                if (t == typeof(SuperHero)) s += " is Super";
                else if (t == typeof(Villian)) s += " is Misunderstood Person";
                lbCalls.Items.Add(s);
            }

            IPowered ip = new MegaHero("Bob","Smith");
            lbCalls.Items.Add(ip.CanFly());

            lbCalls.Items.Add(((MegaHero)ip).FirstName);

            SuperHero s1 = new SuperHero("Brian", "Renolds");
            Villian vil = new Villian() { FirstName = "Bob", LastName = "Ross" };


            lbCalls.Items.Add(s1.ToString());

            string s2 = (vil + s1) + vil;

            int a = 1 + 2;

            lbCalls.Items.Add(s2);
            lbCalls.Items.Add(s1.ToString());
        }
    }
}
