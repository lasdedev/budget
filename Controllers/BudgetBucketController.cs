using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace budget.Controllers
{
    [Route("api/[controller]")]
    public class BudgetBucketController : Controller
    {

        [HttpPost()]
        [Route("add")]
        public int AddBudgetBucket(string budgetBucketName)
        {
            return 5;
        }
    }

    public class BudgetBucketModel
    {
        public int? BudgetBucketId {get; set;}
        public int? BudgetBucketName {get; set;}
    }
}
