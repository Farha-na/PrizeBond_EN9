using BOL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.DTOs
{
    public class Master_setup_Dto
    {
        public class SectionResultDto
        {
            public int SectionId { get; set; }
            public string SectionName { get; set; }
            public int ClassId { get; set; }
            public string ClassName { get; set; }
            public string Createdby { get; set; }
            public int shift_id { get; set; }
            public string shi_name { get; set; }
            public DateTime created_date { get; set; }
        }
    }
}