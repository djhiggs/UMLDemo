using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UMLDemo
{
    public class NetworkAdministrator : Profession, IHardwareFixer
    {
        public void FixHardware()
        {
            throw new NotImplementedException();
        }

        public override void GoToWork()
        {
            throw new NotImplementedException();
        }
        //I am commenting on network admin.....

        //this
        //is
        //how
        //we
        //do
        //it!!!
    }
}