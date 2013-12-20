using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        public const uint minStudentsID = 10000;
        public const uint maxStudentsID = 99999;

        private String fullName;
        private uint ID;
        private static uint IDIncrementer = 10000;

        public Student(string fullName)
        {
            this.FullName = fullName;
            this.UniqueID = IDIncrementer++;
        }

        public String FullName
        {
            get
            {
                return this.fullName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty.");
                }

                this.fullName = value;
            }
        }

        public uint UniqueID
        {
            get
            {
                return this.ID;
            }
            private set
            {
                if (value < minStudentsID || maxStudentsID < value)
                {
                    throw new ArgumentOutOfRangeException(String.Format("ID number should be in range of [{0}..{1}].",
                        minStudentsID, maxStudentsID));
                }

                this.ID = value;
            }
        }

        public override string ToString()
        {
            return FullName + " - " + UniqueID;
        }       
    }
}
