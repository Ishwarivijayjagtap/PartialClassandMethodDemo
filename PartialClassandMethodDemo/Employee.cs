using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassandMethodDemo
{
    public enum Department { HR=101, Sales, Development, Testing, Admin };
    public enum Roles {Employee=1,Manager,ceo,HrManager  }
    internal class Employee
    {
        private int id;
        private String name;
        private Department dept;
        private Roles role;
        public Employee( int id,String name,Department dept,Roles role)

        {
            this.id = id;
            this.name = name;
            this.dept = dept;
            this.role = role;
        }
        public override string ToString()
        {
            return $"{id} {name} {dept} {role} ";
        }
    }
}
