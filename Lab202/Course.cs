using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    class Course
    {
        private string _Name;
        private string _CourseID;
        private string _Lecturer;
        private int _MaxStudents;
        private int _NumStudents;

        public Course()
        {
            _Name = " ";
            _CourseID = "000000";
            _Lecturer = "staff";
            _MaxStudents = 30;
            _NumStudents = 0;
        }

        public Course(string name, string courseid)
        {
            _Name = name;
            _CourseID = courseid;
            _Lecturer = "staff";
            MaxStudents = 30;
            NumStudents = 0;
        }

        public Course(string name, string courseid, string lecturer)
        {
            _Name = name;
            _CourseID = courseid;
            _Lecturer = lecturer;
            MaxStudents = 30;
            NumStudents = 0;
        } 

        public Course(string name, string courseid, string lecturer, int maxstudents)
        {
            _Name = name;
            _CourseID = courseid;
            _Lecturer = lecturer;
            MaxStudents = maxstudents;
            NumStudents = 0;
        }

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        public string CourseID
        {
            get
            {
                return _CourseID;
            }
            set
            {
                bool check = false;
                char x = ' ';
                char[] array = value.ToCharArray();

                for (int i = 0; i < value.Length; i++)
                {
                    x = array[i];

                    if (char.IsLower(x) || char.IsUpper(x))
                    {
                        check = true;
                    }

                }

                if (value.Length != 6 || check)
                {
                    Console.WriteLine(_CourseID + ": error try setting invalid CourseID!");
                }
                else
                {
                    _CourseID = value;
                }
            }
        }

        public string Lecturer
        {
            get
            {
                return _Lecturer;
            }
            set
            {
                _Lecturer = value;
            }
        }

        public int MaxStudents
        {
            get
            {
                return _MaxStudents;
            }
            set
            {
                if (value >= 0 && value <= 80 && value >= _NumStudents)
                {
                    _MaxStudents = value;
                }
                else
                {
                    Console.WriteLine(_CourseID + ": error try setting invalid Max No. Students!");
                  
                }
            }
        }

        public int NumStudents
        {
            get
            {
                return _NumStudents;
            }
            set
            {
                if (value < 0 || value > _MaxStudents)
                {
                    Console.WriteLine(_CourseID + ": error try setting invalid No. Students!");
                }
                else
                {
                    _NumStudents = value;
                }
            }
        }

        public override string ToString()
        {
            string a = "[Course: " + Name + " (" + CourseID + "), Lecturer=" + Lecturer + ", has " + NumStudents + " students, max=" + MaxStudents + "]";
            return a;
        }


    }
}
