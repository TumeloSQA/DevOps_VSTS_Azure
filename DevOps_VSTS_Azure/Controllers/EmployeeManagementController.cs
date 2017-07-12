using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevOps_VSTS_Azure.Models;

namespace DevOps_VSTS_Azure.Controllers
{
	public class EmployeeManagementController : Controller
	{
		List<Employee> listEmployees = new List<Employee>();
		public ActionResult Index()
		{

			listEmployees.Add(new Employee()
			{
				ID = 1,
				Name = "Tumelo",
				Address = "37 Thulare Street",
				Age = 25

			});

			listEmployees.Add(new Employee()
			{
				ID = 2,
				Name = "Phuti",
				Address = "39 Thulare Street",
				Age = 30

			});

			listEmployees.Add(new Employee()
			{
				ID = 3,
				Name = "Kabelo",
				Address = "41 Thulare Street",
				Age = 35

			});

			return View(listEmployees);
		}



		//public ActionResult Details(int ID = null)
		//     {
		//Employee employee = listEmployees.Find(ID);
		//if (employee == null)
		//{
		//  return HttpNotFound();
		//}
		//return View(employee);
		//}

		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Create(FormCollection collection)
		{
			try
			{
				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		public ActionResult Edit(int id)
		{
			return View();
		}

		[HttpPost]
		public ActionResult Edit(int id, FormCollection collection, Employee employee)
		{
			if (ModelState.IsValid)
			{
				listEmployees.Add(employee);
				return RedirectToAction("Index");
			}

			return View(employee);
		}

		public ActionResult Delete(int id)
		{
			return View();
		}

		[HttpPost]
		public ActionResult Delete(int id, FormCollection collection)
		{
			try
			{
				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}
	}
}

 