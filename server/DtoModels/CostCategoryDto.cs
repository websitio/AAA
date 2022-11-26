namespace Server.DtoModels
{
    public class CostCategoryDto
    {
       public int Id { get; set; }
        public string Name { get; set; }
       public string Description { get; set; }
    }
}       //Thought occurs, should'nt this have the current users Id 
        // so said user can choose from thier categories