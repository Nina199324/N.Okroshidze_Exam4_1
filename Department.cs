using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6
//6.2 შექმენით კლასი დეპარტამენტი რომელსაც ექნება დეპარტამენტის დასახელება და მაქსიმალური თანამშრომლის რაოდენობა (ველები).
{
    public class Department
    {
        public string departmentName;
        public int NumofMaxEmpl { get; set; }

        public string getDepartmentName()
        {
            return departmentName;
        }

        public int getEmpsMaxCount()
        {
            return NumofMaxEmpl;
        }

        public Department(string departName, int NumofMaxEmpl)
        {
            this.departmentName = departName;
            this.NumofMaxEmpl = NumofMaxEmpl;
        }
    }
}


