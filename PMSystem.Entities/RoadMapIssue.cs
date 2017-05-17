namespace PMSystem.Entities
{
    public class RoadMapIssue : Issue
    {
        public int MilestoneSortOrder { get; set; }

        public RoadMapIssue(Issue issue, int milestoneSortOrder)
        {
            //Mapper.CreateMap<Issue, RoadMapIssue>();
            //Mapper.Map(issue, this);
            MilestoneSortOrder = milestoneSortOrder;
        }
    }
}
