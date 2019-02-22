using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyFaces {
    class Citizen:Person {
        //public abstract string Yell();
        public override Person CopyMe() {
            Person vc = new Citizen();
            vc.FirstName = this.FirstName;
            vc.LastName = this.LastName;
            vc.Personality = Personalities.Chatty;
            vc.MiddleName = this.MiddleName;
            vc.DateOfBirth = this.DateOfBirth;
            return vc;
        }
    }
}
