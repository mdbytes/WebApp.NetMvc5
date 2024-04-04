using DataObjectLayer;
using LogicLayer;
using LogicLayerInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMVC5Template.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerManager customerManager;

        public CustomerController()
        {
            customerManager = new CustomerManager();
        }

        // GET: Customer
        public ActionResult Index()
        {
            List<CustomerVM> customers = customerManager.GetCustomers();
            return View(customers);
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            CustomerVM customerVM = customerManager.GetCustomerById(id);
            return View(customerVM);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            CustomerVM customer = new CustomerVM();
            return View(customer);
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(CustomerVM customerVM)
        {
            if(!ModelState.IsValid)
            {
                return View(customerVM);
            }

            try
            {
                // TODO: Add insert logic here
                customerManager.AddCustomer(customerVM);                    
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            CustomerVM customerVM = customerManager.GetCustomerById(id);
            return View(customerVM);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CustomerVM customerVM)
        {
            if (!ModelState.IsValid)
            {
                return View(customerVM);
            }

            try
            {
                // TODO: Add update logic here
                customerManager.UpdateCustomer(customerVM);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            CustomerVM customerVM = customerManager.GetCustomerById(id);
            return View(customerVM);
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, CustomerVM customerVM)
        {
            try
            {
                // TODO: Add delete logic here
                customerManager.DeleteCustomer(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
