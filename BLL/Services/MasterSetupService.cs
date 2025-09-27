//using BLL.Interfaces;

//using BOL.Entities;
using DAL.Interfaces;

//using static BOL.DTOs.Master_setup_Dto;

namespace BLL.Services
{
    //public class MasterSetupService : IMasterSetupService
    //{
    //    private readonly IMasterSetupRepository _MSTP;

    //    public MasterSetupService(IMasterSetupRepository MSTP)
    //    {
    //        _MSTP = MSTP;
    //    }

    //    //    public async Task<dg_ms_class?> Add_Class(dg_ms_class Class)
    //    //    {
    //    //        var addedClass = await _MSTP.Add_Class(Class);
    //    //        return addedClass;
    //    //    }

    //    //    public async Task<IEnumerable<dg_ms_class>> GetAll_Claas()
    //    //    {
    //    //        return await _MSTP.GetAll_Claas();
    //    //    }

    //    //    public async Task<dg_ms_stu_category?> Add_Student_category(dg_ms_stu_category _Ms_Stu_Category)
    //    //    {
    //    //        var addstu_cate = await _MSTP.Add_Student_category(_Ms_Stu_Category);
    //    //        return addstu_cate;
    //    //    }

    //    //    public async Task<IEnumerable<dg_ms_stu_category>> GetMs_Stu_Categories()
    //    //    {
    //    //        return await _MSTP.GetMs_Stu_Categories();
    //    //    }

    //    //    public async Task<dg_ms_shift?> Add_Shift(dg_ms_shift _Ms_Shift)
    //    //    {
    //    //        var _Shift = await _MSTP.Add_Shift(_Ms_Shift);
    //    //        return _Shift;
    //    //    }

    //    //    public async Task<IEnumerable<dg_ms_shift>> Get_Ms_Shifts()
    //    //    {
    //    //        return await _MSTP.Get_Ms_Shifts();
    //    //    }

    //    //    public async Task<dg_ms_section?> Add_Section(dg_ms_section _Ms_Section)
    //    //    {
    //    //        var _Section = await _MSTP.Add_Section(_Ms_Section);
    //    //        return _Section;
    //    //    }

    //    //    //public async Task<dg_ms_school_details?> Add_new_school_details(dg_ms_school_details _Ms_School_Details)
    //    //    //{
    //    //    //    var _Section = await _MSTP.Add_new_school_details(_Ms_School_Details);
    //    //    //    return _Section;
    //    //    //}

    //    //    //public async Task<IEnumerable<dg_ms_school_details>> GetMs_School_Details()
    //    //    //{
    //    //    //    return await _MSTP.Get_Ms_School_Details();
    //    //    //}

    //    //    public async Task<dg_ms_religion?> Add_Religion(dg_ms_religion _Ms_Religion)
    //    //    {
    //    //        var _Religion = await _MSTP.Add_Religion(_Ms_Religion);
    //    //        return _Religion;
    //    //    }

    //    //    public async Task<IEnumerable<dg_ms_religion>> Get_Ms_Religions()
    //    //    {
    //    //        return await _MSTP.Get_Ms_Religions();
    //    //    }

    //    //    public async Task<IEnumerable<dg_ms_gender>> Get_Ms_Genders()
    //    //    {
    //    //        return await _MSTP.Get_Ms_Genders();
    //    //    }

    //    //    public async Task<dg_ms_blood_group?> Add_Blood_Group(dg_ms_blood_group _Ms_Blood_Group)
    //    //    {
    //    //        var _Blood_Group = await _MSTP.Add_Blood_Group(_Ms_Blood_Group);
    //    //        return _Blood_Group;
    //    //    }

    //    //    public async Task<IEnumerable<dg_ms_blood_group>> Get_Blood_Groups()
    //    //    {
    //    //        return await _MSTP.Get_Blood_Groups();
    //    //    }

    //    //    public async Task<dg_ms_board?> Add_Board(dg_ms_board _Ms_Board)
    //    //    {
    //    //        var _Board = await _MSTP.Add_Board(_Ms_Board);
    //    //        return _Board;
    //    //    }

    //    //    public async Task<IEnumerable<dg_ms_board>> Get_Ms_Boards()
    //    //    {
    //    //        return await _MSTP.Get_Ms_Boards();
    //    //    }

    //    //    public async Task<IEnumerable<SectionResultDto>> Get_Ms_Sections()
    //    //    {
    //    //        return await _MSTP.Get_Ms_Sections();
    //    //    }

    //    //    public async Task<dg_ms_curriculum?> Add_curriculum(dg_ms_curriculum _Ms_Curriculum)
    //    //    {
    //    //        var _Curriculum = await _MSTP.Add_curriculum(_Ms_Curriculum);
    //    //        return _Curriculum;
    //    //    }

    //    //    public async Task<IEnumerable<dg_ms_curriculum>> Get_Ms_Curriculum()
    //    //    {
    //    //        return await _MSTP.Get_Ms_Curriculum();
    //    //    }

    //    //    public async Task<dg_ms_compline_type?> Add_Compline_type(dg_ms_compline_type _Compline_Type)
    //    //    {
    //    //        var _Type = await _MSTP.Add_Compline_type(_Compline_Type);
    //    //        return _Type;
    //    //    }

    //    //    public async Task<IEnumerable<dg_ms_compline_type>> GetMs_Compline_Types()
    //    //    {
    //    //        return await _MSTP.GetMs_Compline_Types();
    //    //    }

    //    //    public async Task<dg_ms_session?> Add_Session(dg_ms_session _Ms_Session)
    //    //    {
    //    //        var _Session = await _MSTP.Add_Session(_Ms_Session);
    //    //        return _Session;
    //    //    }

    //    //    public async Task<IEnumerable<dg_ms_session>> Get_Ms_Sessions()
    //    //    {
    //    //        return await _MSTP.Get_Ms_Sessions();
    //    //    }
    //}
}