using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectManagement
{
    public class Member
    {
       public int num_members = 10;
    }
    public class Software
    {
        public static void Main()
        {
            Member objMember = new Member();
            Console.WriteLine("Number of member of this project is : " + objMember.num_members);
        }
    }
}
