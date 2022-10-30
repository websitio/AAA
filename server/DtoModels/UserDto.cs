namespace Server.DtoModels
{
    public class UserDto
    {
        public int Id {get; set;}
        public string Username { get; set; }
        public string Token { get; set; }


// public ICollection<CostAmountDto> Categories {get; set;}
   //     public ICollection<CostCategoryDto> Costs {get; set;}
        // add collection of costs
    }

}