using System.Data;
using NPoco.SqlStoredProcedures.Annotation;

namespace NPoco.iSeriesTest.Poco
{
    [SPName("TEST_CUST.SP_CUSTOMER_SELECT")]
    public class SPCustomerSelect
    {
        [SPParam(Name = "KEY_FILTER", Direction = ParameterDirection.Input)]
        public int Key { get; set; }

        [SPParam(Name = "ERR_NO", Direction = ParameterDirection.Output)]
        public int ErrorNumber { get; set; }

        [SPParam(Name = "ERR_MSG", Direction = ParameterDirection.Output)]
        public string ErrorMessage { get; set; }
    }
}
