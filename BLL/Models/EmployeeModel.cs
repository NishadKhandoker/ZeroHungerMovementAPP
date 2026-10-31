using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Models
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; } = null!;

        public string ContactNo { get; set; } = null!;
    }
}
