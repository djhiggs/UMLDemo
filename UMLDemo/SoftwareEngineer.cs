using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UMLDemo
{
    public class SoftwareEngineer : Profession, IManager, IProgrammer
    {
        public override void GoToWork()
        {
            throw new NotImplementedException();
        }
    }
}