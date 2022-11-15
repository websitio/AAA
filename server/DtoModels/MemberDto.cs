namespace Server.DtoModels
{
    public class MemberDto
    {
        public int Id { get; set; }

        public string Username { get; set; }

   public ICollection<CostCategoryDto> Costs { get; set; }

    //   public ICollection<CostAmountDto> Categories {get; set;}
     
     
    }
}