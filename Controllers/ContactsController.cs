using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContactsManagement.Models;

namespace ContactsManagement.Controllers
{
    public class ContactsController : Controller
    {
        private ContactsDbContext _dbContext;

        public ContactsController (ContactsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View(_dbContext.Contacts);
        }

        // /{controller}/{action}
        // GET /Contacts/Create
        [HttpGet] //here we GET that it means we get the contact from database
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost] //here we POST that it means we save the contact to database
        public async Task<IActionResult> Create(Contact contact)
        {
            if (ModelState.IsValid) //check if model state is valid
            { //if yes then we do the following
                _dbContext.Contacts.Add(contact); //we add the contact
                await _dbContext.SaveChangesAsync(); //we save the contact

                return RedirectToAction("Index"); //the we redirect to the contact list
            }

            return View(contact);

        }


        // GET /Contacts/Edit
        [HttpGet] //here we GET that it means we get the contact from database
        public IActionResult Edit(int id)
        {
            var contact = _dbContext.Contacts.FirstOrDefault(c => c.ContactId == id);

            if (contact == null)
                return NotFound();

            return View(contact);
        }

        [HttpPost] //here we POST that it means we save the contact to database
        public async Task<IActionResult> Edit(Contact contact)
        {
            if (ModelState.IsValid) //check if model state is valid
            { //if yes then we do the following
                _dbContext.Contacts.Update(contact); //we update the contact
                await _dbContext.SaveChangesAsync(); //we save the contact

                return RedirectToAction("Index"); //the we redirect to the contact list
            }

            return View(contact);
        }

        [HttpGet] 
        public IActionResult Delete(int id)
        {
            var contact = _dbContext.Contacts.FirstOrDefault(c => c.ContactId == id);

            if (contact == null)
                return NotFound();

            return View(contact);
        }

        [HttpPost] 
        public async Task<IActionResult> Destroy(int id)
        {
            var contact = _dbContext.Contacts.FirstOrDefault(c => c.ContactId == id);

            if (contact == null)
                return NotFound();

            _dbContext.Contacts.Remove(contact);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
