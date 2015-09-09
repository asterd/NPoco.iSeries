namespace NPoco.iSeriesTest.Poco
{
    [TableName("TEST_CUST.CUSTOMER")]
    [PrimaryKey("CUSTOMERID")]
    public class CustomerTable
    {
        [ResultColumn]
        public int CustomerId { get; set; }
        [Column("LASTNAME")]
        public string LastName { get; set; }
        [Column("FIRSTNAME")]
        public string FirstName { get; set; }
        [Column("PHONENUMBER")]
        public int PhoneNumber { get; set; }
    }
}
