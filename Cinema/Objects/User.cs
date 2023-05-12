using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class User
    {
        public string User_ID { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public int Balance { get; set; }
        public int Expense { get; set; }
        public int Point { get; set; }
        public bool isVip { get; set; }
        public User() { }
        ~User() { }
    }
}
