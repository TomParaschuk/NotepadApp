using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadApp.ViewModels
{
    public class TaskViewModel
    {
        #region Constructors
        public TaskViewModel()
        {
            Description = "N/A";
            Priority = 0;
            DurationDays = 0;
            DurationHours = 0;
            DurationMinutes = 0;
        }
        #endregion

        #region Properties
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private double priority;

        public double Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        private int durationDays;

        public int DurationDays
        {
            get { return durationDays; }
            set { durationDays = value; }
        }


        private int durationHours;

        public int DurationHours
        {
            get { return durationHours; }
            set { durationHours = value; }
        }

        private int durationMinutes;

        public int DurationMinutes
        {
            get { return durationMinutes; }
            set { durationMinutes = value; }
        }
        #endregion
    }
}
