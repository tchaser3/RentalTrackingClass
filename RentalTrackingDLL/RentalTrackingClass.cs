/* Title:           Rental Tracking Class
 * Date:            1-23-20
 * Author:          Terry Holmes
 * 
 * Description:     This is used for rental tracking */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace RentalTrackingDLL
{
    public class RentalTrackingClass
    {
        //setting up the classes
        EventLogClass TheEventLogClass = new EventLogClass();

        RentalTrackingDataSet aRentalTrackingDataSet;
        RentalTrackingDataSetTableAdapters.rentaltrackingTableAdapter aRentalTrackingTableAdapter;

        InsertRentalTrackingTransactionEntryTableAdapters.QueriesTableAdapter aInsertRentalTrackingTransactionTableAdapter;

        CloseRentalTrackingTransactionEntryTableAdapters.QueriesTableAdapter aCloseRentalTransactionTableAdapter;

        FindRentalTrackingTransactionsByPONumberDataSet aFindRentalTrackingTransactionByPONumberDataSet;
        FindRentalTrackingTransactionsByPONumberDataSetTableAdapters.FindRentalTrackingTransactionByPONumberTableAdapter aFindRentalTrackingTransactionByPONumberTableAdapter;

        FindRentalTransactionsCloseDateDataSet aFindRentalTransactionsCloseDateDataSet;
        FindRentalTransactionsCloseDateDataSetTableAdapters.FindRentalTransactionsDateCloseTableAdapter aFindRentalTransactionsCloseDateTableAdapter;

        public FindRentalTransactionsCloseDateDataSet FindRentalTransactionCloseDate(DateTime datLimitingDate)
        {
            try
            {
                aFindRentalTransactionsCloseDateDataSet = new FindRentalTransactionsCloseDateDataSet();
                aFindRentalTransactionsCloseDateTableAdapter = new FindRentalTransactionsCloseDateDataSetTableAdapters.FindRentalTransactionsDateCloseTableAdapter();
                aFindRentalTransactionsCloseDateTableAdapter.Fill(aFindRentalTransactionsCloseDateDataSet.FindRentalTransactionsDateClose, datLimitingDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Rental Tracking Class // Find Rental Transaction Close Date " + Ex.Message);
            }

            return aFindRentalTransactionsCloseDateDataSet;
        }
        public FindRentalTrackingTransactionsByPONumberDataSet FindRentalTrackingTransactionByPONumber(int intPONumber)
        {
            try
            {
                aFindRentalTrackingTransactionByPONumberDataSet = new FindRentalTrackingTransactionsByPONumberDataSet();
                aFindRentalTrackingTransactionByPONumberTableAdapter = new FindRentalTrackingTransactionsByPONumberDataSetTableAdapters.FindRentalTrackingTransactionByPONumberTableAdapter();
                aFindRentalTrackingTransactionByPONumberTableAdapter.Fill(aFindRentalTrackingTransactionByPONumberDataSet.FindRentalTrackingTransactionByPONumber, intPONumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Rental Tracking Class // Find Rental Tracking Transaction By PO Number " + Ex.Message);
            }

            return aFindRentalTrackingTransactionByPONumberDataSet;
        }
        public bool CloseRentalTrackingTransaction(int intTransactionID, DateTime datReturnDate, int intTotalDays, decimal decTotalCost)
        {
            bool blnFatalError = false;

            try
            {
                aCloseRentalTransactionTableAdapter = new CloseRentalTrackingTransactionEntryTableAdapters.QueriesTableAdapter();
                aCloseRentalTransactionTableAdapter.CloseRentalTrackingTransaction(intTransactionID, datReturnDate, intTotalDays, decTotalCost);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Rental Tracking Class // Close Rental Tracking Transaction " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertRentalTrackingTransaction(DateTime datRequestingDate, int intPONumber, int intEmployeeID, int intVendorID, DateTime datPickupDate, DateTime datExpirationDate, int intRequestedDays, decimal decTotalCost)
        {
            bool blnFatalError = false;

            try
            {
                aInsertRentalTrackingTransactionTableAdapter = new InsertRentalTrackingTransactionEntryTableAdapters.QueriesTableAdapter();
                aInsertRentalTrackingTransactionTableAdapter.InsertRentalTrackingTransaction(datRequestingDate, intPONumber, intEmployeeID, intVendorID, datPickupDate, datExpirationDate, intRequestedDays, decTotalCost);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Rental Tracking Class // Insert Rental Tracking Transaction " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public RentalTrackingDataSet GetRentalTrackingInfo()
        {
            try
            {
                aRentalTrackingDataSet = new RentalTrackingDataSet();
                aRentalTrackingTableAdapter = new RentalTrackingDataSetTableAdapters.rentaltrackingTableAdapter();
                aRentalTrackingTableAdapter.Fill(aRentalTrackingDataSet.rentaltracking);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Rental Tracking Class // Get Rental Tracking Info " + Ex.Message);
            }

            return aRentalTrackingDataSet;
        }
        public void UpdateRentalTrackingDB(RentalTrackingDataSet aRentalTrackingDataSet)
        {
            try
            {
                aRentalTrackingTableAdapter = new RentalTrackingDataSetTableAdapters.rentaltrackingTableAdapter();
                aRentalTrackingTableAdapter.Update(aRentalTrackingDataSet.rentaltracking);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Rental Tracking Class // Update Rental Tracking DB " + Ex.Message);
            }
        }
    }
}
