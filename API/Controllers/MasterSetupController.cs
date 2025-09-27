using Microsoft.AspNetCore.Mvc;

//using BLL.Interfaces;
//using BOL.Entities;

namespace API.Controllers
{
    //[Route("api/[controller]/[action]")]

    //[ApiController]
    //public class MasterSetupController : ControllerBase
    //{
    //    private readonly IMasterSetupService _masterSetupService;

    //    public MasterSetupController(IMasterSetupService masterSetupService)
    //    {
    //        _masterSetupService = masterSetupService;
    //    }

    //    [HttpPost]
    //    public async Task<IActionResult> Add_Class(dg_ms_class Class)
    //    {
    //        var _Class = await _masterSetupService.Add_Class(Class);

    //        if (_Class == null) // duplicate case
    //        {
    //            return Conflict(new
    //            {
    //                status = 400,
    //                message = "Class already exists!"
    //            });
    //        }

    //        return Ok(new
    //        {
    //            status = 200,
    //            message = "Class saved successfully!",
    //            data = _Class
    //        });
    //    }

    //    [HttpGet]
    //    public async Task<IActionResult> GetAll_Claas()
    //    {
    //        var Allclass = await _masterSetupService.GetAll_Claas();
    //        return Ok(Allclass);
    //    }

    //    [HttpPost]
    //    public async Task<IActionResult> Add_Student_category(dg_ms_stu_category _Ms_Stu_Category)
    //    {
    //        var _Stu_Category = await _masterSetupService.Add_Student_category(_Ms_Stu_Category);

    //        if (_Stu_Category == null) // duplicate case
    //        {
    //            return Conflict(new
    //            {
    //                status = 400,
    //                message = "Student category already exists!"
    //            });
    //        }

    //        return Ok(new
    //        {
    //            status = 200,
    //            message = "Student category successfully!",
    //            data = _Stu_Category
    //        });
    //    }

    //    [HttpGet]
    //    public async Task<IActionResult> GetMs_Stu_Categories()
    //    {
    //        var _Stu_Categories = await _masterSetupService.GetMs_Stu_Categories();
    //        return Ok(_Stu_Categories);
    //    }

    //    [HttpPost]
    //    public async Task<IActionResult> Add_Shift(dg_ms_shift _Ms_Shift)
    //    {
    //        var _Shifts = await _masterSetupService.Add_Shift(_Ms_Shift);

    //        if (_Shifts == null) // duplicate case
    //        {
    //            return Conflict(new
    //            {
    //                status = 400,
    //                message = "Shift already exists!"
    //            });
    //        }

    //        return Ok(new
    //        {
    //            status = 200,
    //            message = "Shift Save successfully!",
    //            data = _Shifts
    //        });
    //    }

    //    [HttpGet]
    //    public async Task<IActionResult> Get_Ms_Shifts()
    //    {
    //        var _Shifts = await _masterSetupService.Get_Ms_Shifts();
    //        return Ok(_Shifts);
    //    }

    //    [HttpPost]
    //    public async Task<IActionResult> Add_Section(dg_ms_section _Ms_Section)
    //    {
    //        var _Section = await _masterSetupService.Add_Section(_Ms_Section);

    //        if (_Section == null) // duplicate case
    //        {
    //            return Conflict(new
    //            {
    //                status = 400,
    //                message = "Section already exists!"
    //            });
    //        }

    //        return Ok(new
    //        {
    //            status = 200,
    //            message = "Section Save successfully!",
    //            data = _Section
    //        });
    //    }

    //    [HttpGet]
    //    public async Task<IActionResult> Get_Ms_Sections()
    //    {
    //        var _Sections = await _masterSetupService.Get_Ms_Sections();
    //        return Ok(_Sections);
    //    }

    //    [HttpPost]
    //    public async Task<IActionResult> Add_Religion(dg_ms_religion _Ms_Religion)
    //    {
    //        var _Religion = await _masterSetupService.Add_Religion(_Ms_Religion);

    //        if (_Religion == null) // duplicate case
    //        {
    //            return Conflict(new
    //            {
    //                status = 400,
    //                message = "Religion already exists!"
    //            });
    //        }

    //        return Ok(new
    //        {
    //            status = 200,
    //            message = "Religion Save successfully!",
    //            data = _Religion
    //        });
    //    }

    //    [HttpGet]
    //    public async Task<IActionResult> Get_Ms_Religions()
    //    {
    //        var _Religions = await _masterSetupService.Get_Ms_Religions();
    //        return Ok(_Religions);
    //    }

    //    [HttpGet]
    //    public async Task<IActionResult> Get_Ms_Genders()
    //    {
    //        var _Genders = await _masterSetupService.Get_Ms_Genders();
    //        return Ok(_Genders);
    //    }

    //    [HttpPost]
    //    public async Task<IActionResult> Add_Board(dg_ms_board _Ms_Board)
    //    {
    //        var _Board = await _masterSetupService.Add_Board(_Ms_Board);

    //        if (_Board == null) // duplicate case
    //        {
    //            return Conflict(new
    //            {
    //                status = 400,
    //                message = "Board already exists!"
    //            });
    //        }

    //        return Ok(new
    //        {
    //            status = 200,
    //            message = "Board Save successfully!",
    //            data = _Board
    //        });
    //    }

    //    [HttpGet]
    //    public async Task<IActionResult> Get_Ms_Boards()
    //    {
    //        var _Board = await _masterSetupService.Get_Ms_Boards();
    //        return Ok(_Board);
    //    }

    //    [HttpPost]
    //    public async Task<IActionResult> Add_Blood_Group(dg_ms_blood_group _Ms_Blood_Group)
    //    {
    //        var _Blood_Group = await _masterSetupService.Add_Blood_Group(_Ms_Blood_Group);

    //        if (_Blood_Group == null) // duplicate case
    //        {
    //            return Conflict(new
    //            {
    //                status = 400,
    //                message = "Blood Group already exists!"
    //            });
    //        }

    //        return Ok(new
    //        {
    //            status = 200,
    //            message = "Blood GroupSave successfully!",
    //            data = _Blood_Group
    //        });
    //    }

    //    [HttpGet]
    //    public async Task<IActionResult> GetMs_Blood_Groups()
    //    {
    //        var _Blood_Groups = await _masterSetupService.Get_Blood_Groups();
    //        return Ok(_Blood_Groups);
    //    }

    //    [HttpPost]
    //    public async Task<IActionResult> Add_Session(dg_ms_session _Ms_Session)
    //    {
    //        var _Session = await _masterSetupService.Add_Session(_Ms_Session);

    //        if (_Session == null) // duplicate case
    //        {
    //            return Conflict(new
    //            {
    //                status = 400,
    //                message = "Session already exists!"
    //            });
    //        }

    //        return Ok(new
    //        {
    //            status = 200,
    //            message = "Session Save successfully!",
    //            data = _Session
    //        });
    //    }

    //    [HttpGet]
    //    public async Task<IActionResult> Get_Ms_Sessions()
    //    {
    //        var _Sessions = await _masterSetupService.Get_Ms_Sessions();
    //        return Ok(_Sessions);
    //    }

    //    [HttpPost]
    //    public async Task<IActionResult> Add_Compline_type(dg_ms_compline_type _Compline_Type)
    //    {
    //        var _Type = await _masterSetupService.Add_Compline_type(_Compline_Type);

    //        if (_Type == null) // duplicate case
    //        {
    //            return Conflict(new
    //            {
    //                status = 400,
    //                message = "Compline Type already exists!"
    //            });
    //        }

    //        return Ok(new
    //        {
    //            status = 200,
    //            message = "Compline Type Save successfully!",
    //            data = _Type
    //        });
    //    }

    //    [HttpGet]
    //    public async Task<IActionResult> GetMs_Compline_Types()
    //    {
    //        var _Types = await _masterSetupService.GetMs_Compline_Types();
    //        return Ok(_Types);
    //    }

    //    [HttpPost]
    //    public async Task<IActionResult> Add_curriculum(dg_ms_curriculum _Ms_Curriculum)
    //    {
    //        var _Curriculum = await _masterSetupService.Add_curriculum(_Ms_Curriculum);

    //        if (_Curriculum == null) // duplicate case
    //        {
    //            return Conflict(new
    //            {
    //                status = 400,
    //                message = "Curriculum  already exists!"
    //            });
    //        }

    //        return Ok(new
    //        {
    //            status = 200,
    //            message = "Curriculum  Save successfully!",
    //            data = _Curriculum
    //        });
    //    }

    //    [HttpGet]
    //    public async Task<IActionResult> Get_Ms_Curriculum()
    //    {
    //        var _Curricula = await _masterSetupService.Get_Ms_Curriculum();
    //        return Ok(_Curricula);
    //    }
    //}
}