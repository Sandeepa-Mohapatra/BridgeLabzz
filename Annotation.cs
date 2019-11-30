

namespace DesignPtternPrograms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    class Annotation
    {       
        [Required]
        public String Name { get; set; }
        [Obsolete("Use Multiply(List<int> number) method")]
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Multiply(List<int> number)
        {
            int mul = 1;
            foreach (int i in number)
            {
                mul = mul * i;
            }
            return mul;
        }
      
    }
}
