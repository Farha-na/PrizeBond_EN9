using Microsoft.EntityFrameworkCore;

//using BOL.Entities;
using DAL.DataContext;
using DAL.Interfaces;

//using static BOL.DTOs.Master_setup_Dto;

namespace DAL.Repositories
{
    //public class MasterSetupRepository : IMasterSetupRepository
    //{
    //    private readonly dg_sms_DBContext _context;

    //    public MasterSetupRepository(dg_sms_DBContext sclContext)
    //    {
    //        _context = sclContext;
    //    }

    //    public async Task<dg_ms_class> Add_Class(dg_ms_class Class)
    //    {
    //        var exists = await _context.dg_ms_class
    //    .AnyAsync(c => c.c_class_name == Class.c_class_name);
    //        if (exists)
    //        {
    //            return null;
    //        }
    //        var newClass = new dg_ms_class
    //        {
    //            c_class_name = Class.c_class_name,
    //            c_created_date = DateTime.Now,
    //            c_created_by = Class.c_created_by,
    //        };

    //        _context.dg_ms_class.Add(newClass);
    //        await _context.SaveChangesAsync();

    //        return newClass;
    //    }

    //    public async Task<IEnumerable<dg_ms_class>> GetAll_Claas()
    //    {
    //        return await _context.dg_ms_class.ToListAsync();
    //    }

    //    public async Task<dg_ms_stu_category> Add_Student_category(dg_ms_stu_category _Ms_Stu_Category)
    //    {
    //        var exists = await _context.dg_ms_stu_category
    //    .AnyAsync(c => c.sc_cate_name == _Ms_Stu_Category.sc_cate_name);
    //        if (exists)
    //        {
    //            return null;
    //        }
    //        var newstu_cate = new dg_ms_stu_category
    //        {
    //            sc_cate_name = _Ms_Stu_Category.sc_cate_name,
    //            sc_cate_created_by = _Ms_Stu_Category.sc_cate_created_by,
    //            sc_cate_created_date = DateTime.Now,
    //            sc_sd_id = _Ms_Stu_Category.sc_sd_id
    //        };

    //        _context.dg_ms_stu_category.Add(_Ms_Stu_Category);
    //        await _context.SaveChangesAsync();

    //        return newstu_cate;
    //    }

    //    public async Task<IEnumerable<dg_ms_stu_category>> GetMs_Stu_Categories()
    //    {
    //        return await _context.dg_ms_stu_category.ToListAsync();
    //    }

    //    public async Task<dg_ms_shift> Add_Shift(dg_ms_shift _Ms_Shift)
    //    {
    //        var exists = await _context.dg_ms_shift
    //    .AnyAsync(c => c.shi_name == _Ms_Shift.shi_name);
    //        if (exists)
    //        {
    //            return null;
    //        }
    //        var ms_Shift = new dg_ms_shift
    //        {
    //            shi_name = _Ms_Shift.shi_name,
    //            shi_created_by = _Ms_Shift.shi_created_by,
    //            shi_created_date = DateTime.Now,
    //            sc_sd_id = _Ms_Shift.sc_sd_id
    //        };

    //        _context.dg_ms_shift.Add(_Ms_Shift);
    //        await _context.SaveChangesAsync();

    //        return ms_Shift;
    //    }

    //    public async Task<IEnumerable<dg_ms_shift>> Get_Ms_Shifts()
    //    {
    //        return await _context.dg_ms_shift.ToListAsync();
    //    }

    //    public async Task<dg_ms_section> Add_Section(dg_ms_section _Ms_Section)
    //    {
    //        var exists = await _context.dg_ms_section
    //    .AnyAsync(c => c.sec_name == _Ms_Section.sec_name);
    //        if (exists)
    //        {
    //            return null;
    //        }
    //        var _Section = new dg_ms_section
    //        {
    //            sec_name = _Ms_Section.sec_name,
    //            sec_cl_id = _Ms_Section.sec_cl_id,
    //            sec_created_date = DateTime.Now,
    //            sc_sd_id = _Ms_Section.sc_sd_id,
    //            sec_shi_id = _Ms_Section.sec_shi_id,
    //            sec_created_by = _Ms_Section.sec_created_by
    //        };

    //        _context.dg_ms_section.Add(_Ms_Section);
    //        await _context.SaveChangesAsync();

    //        return _Section;
    //    }

    //    public async Task<IEnumerable<SectionResultDto>> Get_Ms_Sections()
    //    {
    //        var result = await (
    //            from s in _context.dg_ms_section
    //            join c in _context.dg_ms_class
    //                on s.sec_cl_id equals c.c_id
    //            join sc in _context.dg_ms_shift
    //                on s.sec_shi_id equals sc.shi_id
    //            select new SectionResultDto
    //            {
    //                SectionId = s.sec_id,
    //                SectionName = s.sec_name,
    //                ClassId = c.c_id,
    //                ClassName = c.c_class_name,
    //                shi_name = sc.shi_name,
    //                Createdby = s.sec_created_by,
    //                created_date = s.sec_created_date,
    //                shift_id=sc.shi_id
    //            }
    //        ).ToListAsync();

    //        return result;
    //    }

    //    //public async Task<dg_ms_school_details> Add_new_school_details(dg_ms_school_details _Ms_School_Details)
    //    //{
    //    //    var exists = await _context.dg_ms_school_details
    //    //.AnyAsync(c => c.sd_scl_name_bang == _Ms_School_Details.sd_scl_name_bang);
    //    //    if (exists)
    //    //    {
    //    //        return null;
    //    //    }
    //    //    var _School_Details = new dg_ms_school_details
    //    //    {
    //    //        sd_scl_name_bang = _Ms_School_Details.sd_scl_adrs_bang,
    //    //        sd_scl_name_eng = _Ms_School_Details.sd_scl_name_eng,
    //    //        sd_scl_adrs_bang = _Ms_School_Details.sd_scl_adrs_bang,
    //    //        sd_scl_adrs_eng = _Ms_School_Details.sd_scl_adrs_eng,
    //    //        sd_scl_created_by = _Ms_School_Details.sd_scl_created_by,
    //    //        sd_scl_created_date=DateTime.Now

    //    //    };

    //    //    _context.dg_ms_school_details.Add(_Ms_School_Details);
    //    //    await _context.SaveChangesAsync();

    //    //    return _School_Details;
    //    //}

    //    //public async Task<IEnumerable<dg_ms_school_details>> Get_Ms_School_Details()
    //    //{
    //    //    return await _context.dg_ms_school_details.ToListAsync();
    //    //}

    //    public async Task<dg_ms_religion> Add_Religion(dg_ms_religion _Ms_Religion)
    //    {
    //        var exists = await _context.dg_ms_religion
    //    .AnyAsync(c => c.rel_name == _Ms_Religion.rel_name);
    //        if (exists)
    //        {
    //            return null;
    //        }
    //        var _Religion = new dg_ms_religion
    //        {
    //            rel_name = _Ms_Religion.rel_name,
    //            rel_created_by = _Ms_Religion.rel_created_by,
    //            rel_created_date = DateTime.Now,
    //        };

    //        _context.dg_ms_religion.Add(_Ms_Religion);
    //        await _context.SaveChangesAsync();

    //        return _Religion;
    //    }

    //    public async Task<IEnumerable<dg_ms_religion>> Get_Ms_Religions()
    //    {
    //        return await _context.dg_ms_religion.ToListAsync();
    //    }

    //    public async Task<IEnumerable<dg_ms_gender>> Get_Ms_Genders()
    //    {
    //        return await _context.dg_ms_gender.ToListAsync();
    //    }

    //    public async Task<dg_ms_board> Add_Board(dg_ms_board _Ms_Board)
    //    {
    //        var exists = await _context.dg_ms_board
    //    .AnyAsync(c => c.brd_name == _Ms_Board.brd_name);
    //        if (exists)
    //        {
    //            return null;
    //        }
    //        var _Board = new dg_ms_board
    //        {
    //            brd_name = _Ms_Board.brd_name,
    //            brd_created_by = _Ms_Board.brd_created_by,
    //            brd_created_date = DateTime.Now,
    //        };

    //        _context.dg_ms_board.Add(_Ms_Board);
    //        await _context.SaveChangesAsync();

    //        return _Board;
    //    }

    //    public async Task<IEnumerable<dg_ms_board>> Get_Ms_Boards()
    //    {
    //        return await _context.dg_ms_board.ToListAsync();
    //    }

    //    public async Task<dg_ms_blood_group> Add_Blood_Group(dg_ms_blood_group _Ms_Blood_Group)
    //    {
    //        var exists = await _context.dg_ms_blood_group
    //    .AnyAsync(c => c.bg_name == _Ms_Blood_Group.bg_name);
    //        if (exists)
    //        {
    //            return null;
    //        }
    //        var _Blood_Group = new dg_ms_blood_group
    //        {
    //            bg_name = _Ms_Blood_Group.bg_name,
    //            bg_created_by = _Ms_Blood_Group.bg_created_by,
    //            bg_created_date = DateTime.Now,
    //        };

    //        _context.dg_ms_blood_group.Add(_Ms_Blood_Group);
    //        await _context.SaveChangesAsync();

    //        return _Blood_Group;
    //    }

    //    public async Task<IEnumerable<dg_ms_blood_group>> Get_Blood_Groups()
    //    {
    //        return await _context.dg_ms_blood_group.ToListAsync();
    //    }

    //    public async Task<dg_ms_session> Add_Session(dg_ms_session _Ms_Session)
    //    {
    //        var exists = await _context.dg_ms_session
    //    .AnyAsync(c => c.sess_name == _Ms_Session.sess_name);
    //        if (exists)
    //        {
    //            return null;
    //        }
    //        var _Session = new dg_ms_session
    //        {
    //            sess_name = _Ms_Session.sess_name,
    //            sess_created_by = _Ms_Session.sess_created_by,
    //            sess_sd_id = _Ms_Session.sess_sd_id,
    //            sess_created_date = DateTime.Now,
    //        };

    //        _context.dg_ms_session.Add(_Ms_Session);
    //        await _context.SaveChangesAsync();

    //        return _Ms_Session;
    //    }

    //    public async Task<IEnumerable<dg_ms_session>> Get_Ms_Sessions()
    //    {
    //        return await _context.dg_ms_session.ToListAsync();
    //    }

    //    public async Task<dg_ms_compline_type> Add_Compline_type(dg_ms_compline_type _Compline_Type)
    //    {
    //        var exists = await _context.dg_ms_compline_type
    //    .AnyAsync(c => c.cmt_name == _Compline_Type.cmt_name);
    //        if (exists)
    //        {
    //            return null;
    //        }
    //        var _Type = new dg_ms_compline_type
    //        {
    //            cmt_name = _Compline_Type.cmt_name,
    //            cmt_created_by = _Compline_Type.cmt_created_by,
    //            cmt_created_date = DateTime.Now,
    //            sc_sd_id = _Compline_Type.sc_sd_id
    //        };

    //        _context.dg_ms_compline_type.Add(_Compline_Type);
    //        await _context.SaveChangesAsync();

    //        return _Type;
    //    }

    //    public async Task<IEnumerable<dg_ms_compline_type>> GetMs_Compline_Types()
    //    {
    //        return await _context.dg_ms_compline_type.ToListAsync();
    //    }

    //    public async Task<dg_ms_curriculum> Add_curriculum(dg_ms_curriculum _Ms_Curriculum)
    //    {
    //        var exists = await _context.dg_ms_curriculum
    //    .AnyAsync(c => c.curr_name == _Ms_Curriculum.curr_name);
    //        if (exists)
    //        {
    //            return null;
    //        }
    //        var _Curriculum = new dg_ms_curriculum
    //        {
    //            curr_name = _Ms_Curriculum.curr_name,
    //            curr_created_by = _Ms_Curriculum.curr_created_by,
    //            curr_created_date = DateTime.Now,
    //            curr_sd_id = _Ms_Curriculum.curr_sd_id
    //        };

    //        _context.dg_ms_curriculum.Add(_Ms_Curriculum);
    //        await _context.SaveChangesAsync();

    //        return _Curriculum;
    //    }

    //    public async Task<IEnumerable<dg_ms_curriculum>> Get_Ms_Curriculum()
    //    {
    //        return await _context.dg_ms_curriculum.ToListAsync();
    //    }
    //}
}