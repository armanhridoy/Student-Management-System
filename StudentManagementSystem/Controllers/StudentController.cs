using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Repository;
using StudentManagementSystem.ViewModel;

namespace StudentManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public  IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetAllStudent(CancellationToken cancellationToken)
        {
            return Json(await _studentRepository.GetAllAsync(cancellationToken));
        }
            

        [HttpGet]
        public async Task<IActionResult>CreateOrEdit(int Id, CancellationToken cancellationToken)
        {
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
