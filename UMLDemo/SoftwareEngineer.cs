using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UMLDemo
{
    public class SoftwareEngineer : Profession, IManager, IProgrammer
    {
        // here's my beautiful comment! DJH
        public override void GoToWork()
        {
            throw new NotImplementedException();
        }
    }
}