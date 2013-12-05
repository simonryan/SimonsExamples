using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc2Fundamentals.EmployeeService;

namespace Mvc2Fundamentals.Controllers
{
    public class AsyncExampleController : AsyncController
    {
        // Async Example

        public void IndexAsync()
        {
            var client = new EmployeeServiceClient();

            client.GetAllCompleted += (sender, args) =>
                {
                    // can add to this parameters collection to get stuff into the 
                    // indexcompleted action
                    AsyncManager.Parameters["employees"] = args.Result;
                    
                    AsyncManager.OutstandingOperations.Decrement();
                };

            AsyncManager.OutstandingOperations.Increment();

            client.GetAllAsync();
            
        }

        public ActionResult IndexCompleted(object employees)
        {

            return View(employees);
        }

    }
}
