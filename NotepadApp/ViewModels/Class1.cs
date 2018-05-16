using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadApp.ViewModels
{
    public class Class1
    {
        public Class1()
        {
            myVar = new List<int>();
            myVar.Add(1);
            myVar.Add(2);
            myVar.Add(3);
        }
        private List<int> myVar;

        public List<int> MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

    }
}
