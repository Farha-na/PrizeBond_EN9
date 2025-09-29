using Microsoft.EntityFrameworkCore;
using BOL.Entities;

//using BOL.Entities;

namespace DAL.DataContext
{
    public class db_prizebond_DBContext_2 : DbContext
    {
        public db_prizebond_DBContext_2(DbContextOptions<db_prizebond_DBContext_2> options) : base(options)
        {
        }

        //    public DbSet<Student> Students { get; set; }
        //    public DbSet<dg_front_desk_inquiry> dg_front_desk_inquiry { get; set; }

        //public DbSet<dg_ms_class> dg_ms_class { get; set; }

        //    //public DbSet<dg_Complaint> dg_front_desk_complaint { get; set; }
        //    public DbSet<dg_ms_blood_group> dg_ms_blood_group { get; set; }

        //    public DbSet<dg_ms_board> dg_ms_board { get; set; }
        //    public DbSet<dg_ms_gender> dg_ms_gender { get; set; }
        //    public DbSet<dg_ms_religion> dg_ms_religion { get; set; }
        //    public DbSet<dg_ms_school_details> dg_ms_school_details { get; set; }
        //    public DbSet<dg_ms_section> dg_ms_section { get; set; }
        //    public DbSet<dg_ms_shift> dg_ms_shift { get; set; }
        //    public DbSet<dg_ms_stu_category> dg_ms_stu_category { get; set; }

        //    public DbSet<dg_Complaint> dg_front_desk_complaint { get; set; }
        //    public DbSet<Student_Admission> dg_student_admission { get; set; }

        //    public DbSet<dg_ms_compline_type> dg_ms_compline_type { get; set; }
        //    public DbSet<dg_ms_curriculum> dg_ms_curriculum { get; set; }
        //    public DbSet<dg_ms_session> dg_ms_session { get; set; }

        //    public DbSet<Student_Admission_Academic> dg_student_admission_acdy { get; set; }

        //    //
        //    protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    {
        //        base.OnModelCreating(modelBuilder);

        //        modelBuilder.Entity<dg_Complaint>()
        //            .HasNoKey()
        //            .ToTable("dg_front_desk_complaint"); // actual table or view name

        //        modelBuilder.Entity<Student_Admission>()
        //         .HasOne(s => s.School) // School admission has one school
        //         .WithMany(sch => sch.Student_adms_Data) // School has many Admission
        //         .HasForeignKey(s => s.sa_sd_id); // FK in dependent

        //        modelBuilder.Entity<Student_Admission>()
        //        .HasOne(s => s.stu_aca)
        //        .WithMany(sch => sch.Student_adms_Data)
        //        .HasForeignKey(s => s.sa_stu_sl);
        //    }
    }
}