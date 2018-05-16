using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadApp.ViewModels
{
    public class HomeScreenViewModel
    {
        #region Constructors
        public HomeScreenViewModel()
        {
            TaskList = new List<TaskViewModel>();
            TaskList.Add(new TaskViewModel());
            TaskList.Add(new TaskViewModel());

            MyProperty = new List<int>();
            MyProperty.Add(1);
            MyProperty.Add(2);
            MyProperty.Add(3);

            Test = new List<Class1>();
            
            Test.Add(new Class1());

            Test1 = 0;
        }
        #endregion


        #region Properties
        private List<TaskViewModel> taskList;

        public List<TaskViewModel> TaskList
        {
            get { return taskList; }
            set { taskList = value; }
        }

        private List<int> myVar;

        public List<int> MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        private List<Class1> test;

        public List<Class1> Test
        {
            get { return test; }
            set { test = value; }
        }

        private int test1;

        public int Test1
        {
            get { return test1; }
            set { test1 = value; }
        }


        #endregion


    }
}
