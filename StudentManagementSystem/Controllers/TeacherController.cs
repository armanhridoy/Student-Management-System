using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Repository;
using StudentManagementSystem.ViewModel;

namespace StudentManagementSystem.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult>GetAllTeacher(CancellationToken cancellationToken)
        {
            return Json (await _teacherRepository.GetAllAsync(cancellationToken));
        }
        [HttpGet]
        public async Task<IActionResult>CreateOrEdit(int Id,CancellationToken cancellationToken)
        {
            if (Id == 0)
            {
                return View(new TeacherVm());
            }
            else
            {
                var data = await _teacherRepository.GetByIdAsync(Id,cancellationToken);
                return View(data);
            }
        }
        [HttpPost]
        public async Task<IActionResult>CreateOrEdit(int Id,TeacherVm teacherVm,CancellationToken cancellationToken)
        {
            if (Id == 0)
            {
                await _teacherRepository.InsertAsync(teacherVm,cancellationToken);
                return RedirectToAction("Index");
            }
            else
            {
                await _teacherRepository.UpDateAsync(Id, teacherVm, cancellationToken);
                return RedirectToAction("Index");
            }
        }
        public async Task<IActionResult>Delete(int Id,CancellationToken cancellationToken)
        {
            await _teacherRepository.DeleteAsync(Id,cancellationToken);
            return RedirectToAction("Index");
        }
    }
}
