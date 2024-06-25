using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class RegularExpression
    {
        private string patternEmail;
        private string patternPhone;
        private string patternBirthday;
        private string patternBsn;
        public Regex regexEmail { get; set; }
        public Regex regexPhone { get; set; }
        public Regex regexBirthday { get; set; }
        public Regex regexBsn { get; set; }

        public RegularExpression()
        {
            patternEmail = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-z]+$";
            patternPhone = @"^\+\d{1,}$";
            patternBirthday = @"^(0[1-9]|[12][0-9]|3[01])-(0[1-9]|1[0-2])-((19[4-9]\d|200[0-8]))$";
            patternBsn = @"^\d{4}\.\d{2}\.\d{3}$";
            regexEmail = new Regex(patternEmail);
            regexPhone = new Regex(patternPhone);
            regexBirthday = new Regex(patternBirthday);
            regexBsn = new Regex(patternBsn);
        }
    }
}
