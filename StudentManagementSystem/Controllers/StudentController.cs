using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Repository;
using StudentManagementSystem.ViewModel;

namespace StudentManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ITeacherRepository _TeacherRepository;
        private readonly IEmployeeRepository _employeeRepository;

        public StudentController(IStudentRepository studentRepository, ITeacherRepository teacherRepository, IEmployeeRepository employeeRepository)
        {
            _studentRepository = studentRepository;
            _TeacherRepository = teacherRepository;
            _employeeRepository = employeeRepository;
        }

        public  IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetAllStudent()
        {
            return Json(await _studentRepository.GetAllAsync(x=>x.Teacher,x=>x.Employee));
        }
            

        [HttpGet]
        public async Task<IActionResult>CreateOrEdit(int Id, CancellationToken cancellationToken)
        {
            ViewData["TeacherId"] = _TeacherRepository.Dropdown();
            ViewData["EmployeeId"]=_employeeRepository.DropDown();

            if (Id == 0)
                return View(new StudentVm());
            else
            {
                var data = await _studentRepository.GetByIdAsync(Id, cancellationToken);
                return View(data);
            }
                
        }
        [HttpPost]
        public async Task<IActionResult>CreateOrEdit(int Id,StudentVm studentVm, CancellationToken cancellationToken)
        {
            if(Id== 0)
            {
                await _studentRepository.InsertAsync(studentVm, cancellationToken);
                return RedirectToAction("Index");
            }
            else
            {
                await _studentRepository.UpDateAsync(Id,studentVm, cancellationToken);
                return RedirectToAction("Index");
            }
        }
        [HttpDelete]
        public async Task<IActionResult>Delete(int Id,CancellationToken cancellationToken)
        {
            await _studentRepository.DeleteAsync(Id, cancellationToken);
            return RedirectToAction("Index");
        }
    }
}
