using System;
using System.Collections.Generic;

namespace StudentApi.Models
{
    public partial class StudentDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public int? Marks { get; set; }
    }
}
