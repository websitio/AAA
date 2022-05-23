using Microsoft.AspNetCore.Mvc;



namespace server
{

    [Route("Putin_Is_A_Serial_Killer")]
    public class CostController : Controller
    {
       
          [HttpGet()]
          public JsonResult  GetAll(){
                return new JsonResult(new List<object>()
                {
                    new {Id=1,UserId=1,Amount=10},
                    new {Id=2,UserId=1,Amount=20},
                    new {Id=3,UserId=1,Amount=30}
                });

            }
       
       /* */
         [HttpGet("users")] 
         public JsonResult GetAllUsers()
        {
            return new JsonResult(new List<object>()
                {
                    new {Id=1,UserName="John"},
                    new {Id=2,UserName="Janet"}
         });

        }    //End of GetAllUsers








        /*
          [HttpGet()] 
          public JsonResult GetAllCosts()
          {
              return new JsonResult(new List<object>()
                  {
                      new {Id=1,UserId=1, Amount=4},
                      new {Id=2,UserId=1, Amount=3 },
                      new {Id=3,UserId=2, Amount=2 },
                      new {Id=4,UserId=2, Amount=1 },

                  });
                }   //End of GetAllCosts

         */


        [HttpGet("categories")]
        public JsonResult GetAllCategories()
        {
            return new JsonResult(new List<object>()
                {
                    new {Id=1,Name="Petty Cash"},
                    new {Id=2,UserName="Milk"}
         });

        }    //End of GetAllUsers



    }
}
