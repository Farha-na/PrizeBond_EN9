using BOL.Entities;
using static BOL.DTOs.Master_setup_Dto;

namespace SMS_BLL.Interfaces
{
    public interface IMasterSetupService
    {
        public Task<dg_ms_class?> Add_Class(dg_ms_class Class);

        Task<IEnumerable<dg_ms_class>> GetAll_Claas();

        public Task<dg_ms_stu_category> Add_Student_category(dg_ms_stu_category _Ms_Stu_Category);

        Task<IEnumerable<dg_ms_stu_category>> GetMs_Stu_Categories();

        public Task<dg_ms_shift> Add_Shift(dg_ms_shift _Ms_Shift);

        Task<IEnumerable<dg_ms_shift>> Get_Ms_Shifts();

        public Task<dg_ms_section> Add_Section(dg_ms_section _Ms_Section);

        Task<IEnumerable<SectionResultDto>> Get_Ms_Sections();

        //public Task<dg_ms_school_details> Add_new_school_details(dg_ms_school_details _Ms_School_Details);

        //Task<IEnumerable<dg_ms_school_details>> Get_Ms_School_Details();

        public Task<dg_ms_religion> Add_Religion(dg_ms_religion _Ms_Religion);

        Task<IEnumerable<dg_ms_religion>> Get_Ms_Religions();

        Task<IEnumerable<dg_ms_gender>> Get_Ms_Genders();

        public Task<dg_ms_blood_group> Add_Blood_Group(dg_ms_blood_group _Ms_Blood_Group);

        Task<IEnumerable<dg_ms_blood_group>> Get_Blood_Groups();

        public Task<dg_ms_board> Add_Board(dg_ms_board _Ms_Board);

        Task<IEnumerable<dg_ms_board>> Get_Ms_Boards();

        public Task<dg_ms_compline_type> Add_Compline_type(dg_ms_compline_type _Compline_Type);

        Task<IEnumerable<dg_ms_compline_type>> GetMs_Compline_Types();

        public Task<dg_ms_curriculum> Add_curriculum(dg_ms_curriculum _Ms_Curriculum);

        Task<IEnumerable<dg_ms_curriculum>> Get_Ms_Curriculum();

        public Task<dg_ms_session> Add_Session(dg_ms_session _Ms_Session);

        Task<IEnumerable<dg_ms_session>> Get_Ms_Sessions();
    }
}