using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Repository;
using StudentManagementSystem.ViewModel;

namespace StudentManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<IActionResult> index()
        {
            return View();
        }
        public async Task<IActionResult>GetAllEmployee(CancellationToken cancellationToken)
        {
            return Json (await _employeeRepository.GetAllAsync(cancellationToken));
        }
        [HttpGet]
        public async Task<IActionResult>CreateOrEdit(int id,CancellationToken cancellationToken) { 
            if (id == 0)
            {
                return View(new EmployeeVm());
            }
            else
            {
                var data = await _employeeRepository.GetByIdAsync(id,cancellationToken);
                return View(data);
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrEdit(int id,EmployeeVm employeeVm,CancellationToken cancellationToken)
        {
            if (id == 0)
            {
                await _employeeRepository.InsertAsync(employeeVm, cancellationToken);
                return RedirectToAction("Index");
            }
            else
            {
                await _employeeRepository.UpDateAsync(id,employeeVm, cancellationToken);
                return RedirectToAction("Index");
            }
        }
        [HttpDelete]
        public async Task<IActionResult>Delete(int Id,CancellationToken cancellationToken)
        {
            await _employeeRepository.DeleteAsync(Id,cancellationToken);
            return RedirectToAction("Index");
        }
    }
}
