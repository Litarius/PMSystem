using System.Data;

namespace PMSystem.Entities
{
    public class QueryClause
    {
        public string BooleanOperator { get; set; }

        public string FieldName { get; set; }

        public string DatabaseFieldName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(FieldName)) return "";

                return CustomFieldQuery ? "" : FieldName;
            }
        }

        public string ComparisonOperator { get; set; }

        public string FieldValue { get; set; }

        public SqlDbType DataType { get; set; }

        public bool CustomFieldQuery
        {
            get { return CustomFieldId.HasValue; }
        }

        public int? CustomFieldId { get; set; }

        public QueryClause(string booleanOperator, string fieldName, string comparisonOperator, string fieldValue, SqlDbType dataType, int? customFieldId = null)
        {
            BooleanOperator = booleanOperator;
            FieldName = fieldName;
            ComparisonOperator = comparisonOperator;
            FieldValue = fieldValue;
            DataType = dataType;
            CustomFieldId = customFieldId;
        }

        public QueryClause() { }
    }
}
