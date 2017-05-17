using System.Collections.Generic;

namespace PMSystem.Entities
{
    public class Query
    {
        public Query()
        {
            Name = string.Empty;
            Clauses = new List<QueryClause>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsPublic { get; set; }
        
        public List<QueryClause> Clauses { get; set; }

    }
}
