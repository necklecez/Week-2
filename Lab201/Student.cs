using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        private string _Name;
        private string _StudentID;
        private int _YearOfBirth;
        private bool _isActive;

        public Student()
        {
            _StudentID = "Unknown";
            _Name = "John Doe";
            _YearOfBirth = 1995;
            _isActive = false;

        }

        public Student(string name, string studentid)
        {
            _Name = name;
            _StudentID = studentid;
            _isActive = true;
            _YearOfBirth = 1995;
        }

        public Student(string name, string studentid, int yearofbirth)
        {
            _Name = name;
            _StudentID = studentid;
            _isActive = true;
            _YearOfBirth = yearofbirth;
        }

        public Student(string name, string studentid, int yearofbirth, bool isactive)
        {
            _Name = name;
            _StudentID = studentid;
            _isActive = true;
            _YearOfBirth = yearofbirth;
            _isActive = isactive;
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

        public string StudentID
        {
            get
            {
                return _StudentID;
            }
            set
            {
                _StudentID = value;
            }
        }

        public int YearOfBirth
        {
            get
            {
                return _YearOfBirth;
            }

            set
            {
                if (value <= 1950 || value >= 2000)
                {
                    Console.WriteLine("{0} : error try setting invalid year-of-birth value!", StudentID);
                }
                else
                {
                    _YearOfBirth = value;
                }
            }
        }

        public bool isActive
        {
            get
            {
                return _isActive;
            }
            set
            {
                if (value)
                {
                    _isActive = true;
                }
                else
                {
                    _isActive = false;
                }
            }
        }

        public int getAge()
        {
            return 2015 - YearOfBirth;
        }

        public override string ToString()
        {
            string display = "[Student: " + Name + " (" + StudentID + "), age=" + getAge() + ", ";
            if (isActive)
            {
                display += "is active student]";
            }
            else
            {
                display += "is NOT active student]";
            }
            
            return display;
            //commit
        }
    }
 } 
