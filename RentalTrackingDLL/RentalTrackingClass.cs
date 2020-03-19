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

        FindRentalTransactionByProjectIDDataSet aFindRentalTransactionByProjectIDDataSet;
        FindRentalTransactionByProjectIDDataSetTableAdapters.FindRentalTransasctionByProjectIDTableAdapter aFindRentalTransactionByProjectIDTableAdapter;

        RentalTrackingUpdatesDataSet aRentalTrackingUpdatesDataSet;
        RentalTrackingUpdatesDataSetTableAdapters.rentaltrackingupdatesTableAdapter aRentalTrackingUpdatesTableAdapter;

        InsertRentalTrackingUpdateEntryTableAdapters.QueriesTableAdapter aInsertRentalTrackingUpdateTableAdapter;

        FindRentalTrackingUpdateByRentalTrackingIDDataSet aFindRentalTrackingUpdateByRentalTrackingIDDataSet;
        FindRentalTrackingUpdateByRentalTrackingIDDataSetTableAdapters.FindRentalTrackingUpdateByRentalTrackingIDTableAdapter aFindRentalTrackingUpdateByRentalTrackingIDTableAdapter;

        public FindRentalTrackingUpdateByRentalTrackingIDDataSet FindRentalTrackingUpdateByRentalTrackingID(int intRentalTrackingID)
        {
            try
            {
                aFindRentalTrackingUpdateByRentalTrackingIDDataSet = new FindRentalTrackingUpdateByRentalTrackingIDDataSet();
                aFindRentalTrackingUpdateByRentalTrackingIDTableAdapter = new FindRentalTrackingUpdateByRentalTrackingIDDataSetTableAdapters.FindRentalTrackingUpdateByRentalTrackingIDTableAdapter();
                aFindRentalTrackingUpdateByRentalTrackingIDTableAdapter.Fill(aFindRentalTrackingUpdateByRentalTrackingIDDataSet.FindRentalTrackingUpdateByRentalTrackingID, intRentalTrackingID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Rental Tracking Class // Find Rental Tracking Update By Rental Tracking ID " + Ex.Message);
            }

            return aFindRentalTrackingUpdateByRentalTrackingIDDataSet;
        }
        public bool InsertRentalTrackingUpdate(int intRentalTrackingID, DateTime datTransactionDate, int intEmployeeID, string strUpdateNotes)
        {
            bool blnFatalError = false;

            try
            {
                aInsertRentalTrackingUpdateTableAdapter = new InsertRentalTrackingUpdateEntryTableAdapters.QueriesTableAdapter();
                aInsertRentalTrackingUpdateTableAdapter.InsertRentalTrackingUpdate(intRentalTrackingID, datTransactionDate, intEmployeeID, strUpdateNotes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Rental Tracking Class // Insert Rental Tracking Update " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public RentalTrackingUpdatesDataSet GetRentalTrackingUpdatesInfo()
        {
            try
            {
                aRentalTrackingUpdatesDataSet = new RentalTrackingUpdatesDataSet();
                aRentalTrackingUpdatesTableAdapter = new RentalTrackingUpdatesDataSetTableAdapters.rentaltrackingupdatesTableAdapter();
                aRentalTrackingUpdatesTableAdapter.Fill(aRentalTrackingUpdatesDataSet.rentaltrackingupdates);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Rental Tracking Class // Get Rental Tracking Updates Info " + Ex.Message);
            }

            return aRentalTrackingUpdatesDataSet;
        }
        public void UpdateRentalTrackingUpdateDB(RentalTrackingUpdatesDataSet aRentalTrackingUpdatesDataSet)
        {
            try
            {
                aRentalTrackingUpdatesTableAdapter = new RentalTrackingUpdatesDataSetTableAdapters.rentaltrackingupdatesTableAdapter();
                aRentalTrackingUpdatesTableAdapter.Update(aRentalTrackingUpdatesDataSet.rentaltrackingupdates);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Rental Tracking Class // Update Rental Tracking Updates DB " + Ex.Message);
            }
        }
        public FindRentalTransactionByProjectIDDataSet FindRentalTransactionByProjectID(int intProjectID)
        {
            try
            {
                aFindRentalTransactionByProjectIDDataSet = new FindRentalTransactionByProjectIDDataSet();
                aFindRentalTransactionByProjectIDTableAdapter = new FindRentalTransactionByProjectIDDataSetTableAdapters.FindRentalTransasctionByProjectIDTableAdapter();
                aFindRentalTransactionByProjectIDTableAdapter.Fill(aFindRentalTransactionByProjectIDDataSet.FindRentalTransasctionByProjectID, intProjectID);

            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Rental Tracking Class // Find Rental Tracking By Project ID " + Ex.Message);
            }

            return aFindRentalTransactionByProjectIDDataSet;
        }
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
        public bool InsertRentalTrackingTransaction(DateTime datRequestingDate, int intPONumber, int intEmployeeID, int intVendorID, DateTime datPickupDate, DateTime datExpirationDate, int intRequestedDays, decimal decTotalCost, int intProjectID, decimal decProjectedCost)
        {
            bool blnFatalError = false;

            try
            {
                aInsertRentalTrackingTransactionTableAdapter = new InsertRentalTrackingTransactionEntryTableAdapters.QueriesTableAdapter();
                aInsertRentalTrackingTransactionTableAdapter.InsertRentalTrackingTransaction(datRequestingDate, intPONumber, intEmployeeID, intVendorID, datPickupDate, datExpirationDate, intRequestedDays, decTotalCost, intProjectID, decProjectedCost);
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
