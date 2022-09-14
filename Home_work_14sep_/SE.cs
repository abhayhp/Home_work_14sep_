using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_14sep_
{
    public class SE
    {
        int sid, eid, year_s;
        string name_s, name_e, position_e, course_s;

        public void assignValues_s()
        {
            sid = 3;
            year_s = 2;
            name_s = "Abhay";
            course_s = "Computer Science";
        }

        public void assignValues_e()
        {
            eid = 101;
            name_e = "Abhay";
            position_e = "Analyst";
        }

        public string displayValues_s()
        {
            return $" sid: {sid} \n year: {year_s} \n name: {name_s} \n course: {course_s} \n";
        }

        public string displayValues_e()
        {
            return $" eid: {eid} \n name: {name_e} \n position: {position_e} \n";
        }


    }
}
