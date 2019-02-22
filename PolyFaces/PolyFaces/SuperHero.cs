using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyFaces {
    class SuperHero : Person, IPowered {
        private string _CapeColor;

        public SuperHero(string fName, string last) : base(fName, last) {
            //FirstName = fName;
            //LastName = last;
        }

        public string CapeColor {
            get { return _CapeColor; }
            set { _CapeColor = value; }
        }

        public override string Sing() {
            return "Yodela-he-hoo";
        }
        public override Person CopyMe() {
            return this;
        }
        public override string ToString() {
            return FirstName + "---" + LastName;
        }

        public bool CanFly() {
            return true;
        }

        public bool IsUsedForGood() {
            return true;
        }

        public static String operator +(SuperHero h, Villian v){
            h.FirstName = h.FirstName + " Dude";
            return  h.FirstName + " fights "  + v.FirstName;
            }

        public static String operator +( Villian v, SuperHero h) {
            return h + v;
        }
    }
}
