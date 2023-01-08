namespace API.Helpers
{
    public class LikesParams:PaginationParams
    {
       public int Userid { get; set; } 
       public string predicate { get; set; }
    }
}