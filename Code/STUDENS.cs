using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCodeleynard.Code
{
    
        public class Student<T>
        {
            public T FirstName { get; set; }
            public T LastName { get; set; }
            public T Mark { get; set; }
        }
    
}
