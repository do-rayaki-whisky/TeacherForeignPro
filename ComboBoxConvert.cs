using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherForeignPro
{
    class ComboBoxConvert
    {
        public int ConvMonthToIndex(string _MonthName)
        {
            int IndexResult = 0;
            switch (_MonthName)
            {
                case "มกราคม":
                    IndexResult = 1;
                    break;
                case "กุมภาพันธ์":
                    IndexResult = 2;
                    break;
                case "มีนาคม":
                    IndexResult = 3;
                    break;
                case "เมษายน":
                    IndexResult = 4;
                    break;
                case "พฤษภาคม":
                    IndexResult = 5;
                    break;
                case "มิถุนายน":
                    IndexResult = 6;
                    break;
                case "กรกฎาคม":
                    IndexResult = 7;
                    break;
                case "สิงหาคม":
                    IndexResult = 8;
                    break;
                case "กันยายน":
                    IndexResult = 9;
                    break;
                case "ตุลาคม":
                    IndexResult = 10;
                    break;
                case "พฤศจิกายน":
                    IndexResult = 11;
                    break;
                case "ธันวาคม":
                    IndexResult = 12;
                    break;
                default:
                    IndexResult = 0;
                    break;
            }
            return IndexResult;
        }
        public int ConvTitleToIndex(string _TitleName)
        {
            int Result = 0;
            switch (_TitleName)
            {
                case "นาย":
                case "Mr.":
                    Result = 1;
                    break;
                case "นาง":
                case "Mrs.":
                    Result = 2;
                    break;
                case "นางสาว":
                case "Miss":
                    Result = 3;
                    break;
                default:
                    Result = 0;
                    break;
            }
            return Result;
        }
        public int ConvBloodToIndex(string _BloodName)
        {
            int Result = 0;
            switch (_BloodName.ToLower()){
                case "a":
                    Result = 1;
                    break;
                case "b":
                    Result = 2;
                    break;
                case "o":
                    Result = 3;
                    break;
                case "ab":
                    Result = 4;
                    break;
                case "rh+":
                    Result = 5;
                    break;
                case "rh-":
                    Result = 6;
                    break;
                default:
                    Result = 0;
                    break;
            }
            return Result;
        }
        public string ConvThMonthToEnMonth(string _MonthName)
        {
            string Result = string.Empty;
            switch (_MonthName)
            {
                case "มกราคม":
                    Result = "January";
                    break;
                case "กุมภาพันธ์":
                    Result = "February";
                    break;
                case "มีนาคม":
                    Result = "March";
                    break;
                case "เมษายน":
                    Result = "April";
                    break;
                case "พฤษภาคม":
                    Result = "May";
                    break;
                case "มิถุนายน":
                    Result = "June";
                    break;
                case "กรกฎาคม":
                    Result = "July";
                    break;
                case "สิงหาคม":
                    Result = "August";
                    break;
                case "กันยายน":
                    Result = "September";
                    break;
                case "ตุลาคม":
                    Result = "October";
                    break;
                case "พฤศจิกายน":
                    Result = "November";
                    break;
                case "ธันวาคม":
                    Result = "December";
                    break;
                default:
                    Result = string.Empty;
                    break;
            }
            return Result;
        }
        public string ConvThYearToEnYear(string _ThYear)
        {
            string Result = string.Empty;
            if (_ThYear == string.Empty)
            {
                return Result;
            }
            return Result = (Convert.ToInt16(_ThYear) - 543).ToString();
        }
    }
}
