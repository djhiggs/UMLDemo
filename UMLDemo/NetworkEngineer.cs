using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UMLDemo
{ // This should be the most boring comment.
    public class NetworkEngineer : Profession, IHardwareFixer, IManager
    {
        public void FixHardware()
        {
            throw new NotImplementedException();
        }

        public override void GoToWork()
        {
            throw new NotImplementedException();
        }
    }
}