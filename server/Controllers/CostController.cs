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

        }
    }
