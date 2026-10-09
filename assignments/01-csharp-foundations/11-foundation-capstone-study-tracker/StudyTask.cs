using System;
using System.Collections.Generic;
using System.Text;

namespace _11_foundation_capstone_study_tracker
{

    class StudyTask
    {
        public string Name { get; }
        public string Subjeckt { get; }
        public bool IsDone { get; set; }
        public StudyTask(string name, string subjeckt)
        {

            if (string.IsNullOrWhiteSpace(name))
            {
             throw new ArgumentNullException("name");
            }
            if (string.IsNullOrWhiteSpace(subjeckt))
            {
                throw new ArgumentNullException("subjeckt");
            }

            Subjeckt = subjeckt;
            Name = name;
            IsDone = false;

        }


    }

}
