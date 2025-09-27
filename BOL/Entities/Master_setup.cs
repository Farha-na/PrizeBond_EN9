using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BOL.Entities
{
    public class dg_ms_class
    {
        [Key]
        public Int32 c_id { get; set; }

        public Int16 sc_sd_id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string c_class_name { get; set; }

        public DateTime c_created_date { get; set; } = DateTime.Now;

        [Column(TypeName = "varchar(100)")]
        public string c_created_by { get; set; }
    }

    public class dg_ms_shift
    {
        [Key]
        public Int16 shi_id { get; set; }

        public Int16 sc_sd_id { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string shi_name { get; set; }

        public DateTime shi_created_date { get; set; } = DateTime.Now;

        [Column(TypeName = "varchar(100)")]
        public string shi_created_by { get; set; }
    }

    public class dg_ms_gender
    {
        [Key]
        public Int16 gen_id { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string gen_name { get; set; }

        public DateTime gen_created_date { get; set; } = DateTime.Now;

        [Column(TypeName = "varchar(100)")]
        public string gen_created_by { get; set; }
    }

    public class dg_ms_blood_group
    {
        [Key]
        public Int16 bg_id { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string bg_name { get; set; }

        public DateTime bg_created_date { get; set; } = DateTime.Now;

        [Column(TypeName = "varchar(100)")]
        public string bg_created_by { get; set; }
    }

    public class dg_ms_religion
    {
        [Key]
        public Int16 rel_id { get; set; }

        [Required]
        [Column(TypeName = "varchar(70)")]
        public string rel_name { get; set; }

        public DateTime rel_created_date { get; set; } = DateTime.Now;

        [Column(TypeName = "varchar(100)")]
        public string rel_created_by { get; set; }
    }

    public class dg_ms_board
    {
        [Key]
        public Int16 brd_id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string brd_name { get; set; }

        public DateTime brd_created_date { get; set; } = DateTime.Now;

        [Column(TypeName = "varchar(100)")]
        public string brd_created_by { get; set; }
    }

    public class dg_ms_stu_category
    {
        [Key]
        public Int16 sc_id { get; set; }

        public Int16 sc_sd_id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string sc_cate_name { get; set; }

        public DateTime sc_cate_created_date { get; set; } = DateTime.Now;

        [Column(TypeName = "varchar(100)")]
        public string sc_cate_created_by { get; set; }
    }

    public class dg_ms_section
    {
        [Key]
        public Int16 sec_id { get; set; }

        public Int16 sc_sd_id { get; set; }
        public Int16 sec_cl_id { get; set; }
        public Int16 sec_shi_id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string sec_name { get; set; }

        public DateTime sec_created_date { get; set; } = DateTime.Now;

        [Column(TypeName = "varchar(100)")]
        public string sec_created_by { get; set; }
    }

    public class dg_ms_compline_type
    {
        [Key]
        public Int16 cmt_id { get; set; }

        public Int16 sc_sd_id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string cmt_name { get; set; }

        public DateTime cmt_created_date { get; set; } = DateTime.Now;

        [Column(TypeName = "varchar(100)")]
        public string cmt_created_by { get; set; }
    }

    public class dg_ms_curriculum
    {
        [Key]
        public Int16 curr_id { get; set; }

        public Int16 curr_sd_id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string curr_name { get; set; }

        public DateTime curr_created_date { get; set; } = DateTime.Now;

        [Column(TypeName = "varchar(100)")]
        public string curr_created_by { get; set; }
    }

    public class dg_ms_session
    {
        [Key]
        public Int16 sess_id { get; set; }

        public Int16 sess_sd_id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string sess_name { get; set; }

        public DateTime sess_created_date { get; set; } = DateTime.Now;

        [Column(TypeName = "varchar(100)")]
        public string sess_created_by { get; set; }
    }
}