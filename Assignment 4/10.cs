using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass4_Ques10
{
    internal class Program
    {

        [Flags]
        public enum FilePermissions
        {
            None = 0,
            Read = 1,
            Write = 2,
            Execute = 4
        }

        static void Main(string[] args)
        {
            FilePermissions user1Permissions = FilePermissions.Read | FilePermissions.Write;
            FilePermissions user2Permissions = FilePermissions.Execute;
            Console.WriteLine("User 1 Permissions: "+user1Permissions);
            Console.WriteLine("User 2 Permissions: "+user2Permissions);
            FilePermissions combinedPermissions = user1Permissions | user2Permissions;
            Console.WriteLine("Combined Permissions for User 1 and User 2: "+combinedPermissions);
        }
    }
}