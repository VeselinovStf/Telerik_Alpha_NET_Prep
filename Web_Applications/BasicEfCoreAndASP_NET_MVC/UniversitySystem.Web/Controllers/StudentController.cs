using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using UniversiteySystem.Data;
using UniversitySystem.Models.Entities;
using UniversitySystem.StudentServices.Abstract;
using UniversitySystem.StudentServices.Exceptions;
using UniversitySystem.Web.ViewModels.Student;
using ValidatorGuard.CustomExceptions;

namespace UniversitySystem.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService studentService;
        private readonly ILogger<StudentController> logger;

        public StudentController(IStudentService studentService, ILogger<StudentController> logger)
        {
            this.studentService = studentService;
            this.logger = logger;
        }

        // GET: Student
        public async Task<IActionResult> Index()
        {
            var serviceCall = await this.studentService.All();

            var model = Mapper.Map<StudentListViewModel>(serviceCall);

            return View(model);
        }

        // GET: Student/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            try
            {
                var serviceCall = await this.studentService.DetailsAsync(id);

                var model = Mapper.Map<StudentDetailsViewModel>(serviceCall);

                return View(model);
            }
            catch (LessThenZeroValueException ex)
            {
                this.logger.LogError(ex.Message);
                return NotFound();
            }
            catch (ObjectNullException ex)
            {
                this.logger.LogError(ex.Message);
                return NotFound();
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex.Message);
                return NotFound();
            }
        }

        // GET: Student/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstMidName,LastName,EnrollmentDate,Id")] Student student)
        {
            if (ModelState.IsValid)
            {
                await this.studentService.Add(student.FirstMidName, student.LastName, student.EnrollmentDate);

                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Student/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var serviceCall = await this.studentService.FirstOrDefaultAsync(id);

            var movie = Mapper.Map<StudentViewModel>(serviceCall);

            return View(movie);
        }

        // POST: Student/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FirstMidName,LastName,EnrollmentDate,Id")] Student student)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await this.studentService.Update(student);
                    this.logger.LogInformation("Succesfull Edit");
                }
                catch (EntitiNotFoundException ex)
                {
                    this.logger.LogError(ex.Message);
                    return NotFound();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    this.logger.LogError(ex.Message);
                    return NotFound();
                }

                return RedirectToAction(nameof(Index));
            }

            return View(student);
        }

        // GET: Student/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var serviceCall = await this.studentService.FirstOrDefaultAsync(id);

            var movie = Mapper.Map<StudentViewModel>(serviceCall);

            return View(movie);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await this.studentService.Remove(id);

            return RedirectToAction(nameof(Index));
        }

       
    }
}
