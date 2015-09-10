using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NPoco.iSeriesGen;
using NPoco.iSeriesTest.Poco;
using NPoco.SqlStoredProcedures;

namespace NPoco.iSeriesTest
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            IDatabase db = new Database("as400");

            // Use NPoco Query
            List<CustomerTable> customers = db.Fetch<CustomerTable>();
            customers.ForEach(c => Console.WriteLine(c.FirstName + @" - " + c.LastName));

            var u = new CustomerTable
            {
                FirstName = "Giulia",
                LastName = "Carbonci",
                PhoneNumber = 555555
            };

            db.Insert(u);

            u.LastName = "Carboni";
            db.Update(u);

            // Use NPoco Stored Procedure Extension
            Console.WriteLine(@"START USING PROCEDURE EXTENSION");

            var ts = new SPCustomerSelect { Key = 2 };
            IEnumerable<CustomerTable> storedResult = db.QueryStoredProcedure<CustomerTable, SPCustomerSelect>(ts);
            storedResult.ToList().ForEach(c => Console.WriteLine(c.FirstName + @" - " + c.LastName));
            Console.WriteLine(ts.ErrorMessage);
            db.CloseSharedConnection();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            PocoGenerator.GeneratePoco(
                "PocoTest", "PRORCEDI", "TESPRO0F", false, "CCISI", "MERSY", "MERSY", "C:/");
            MessageBox.Show(@"Done!");
        }
    }
}
