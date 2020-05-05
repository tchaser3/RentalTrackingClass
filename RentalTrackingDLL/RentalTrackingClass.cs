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

        InsertIntoRentalTrackingItemsEntryTableAdapters.QueriesTableAdapter aInsertIntoRentalTrackingItemsTableAdapter;

        FindRentalTrackingItemsByRentalTrackingIDDataSet aFindRentalTrackingItemsByRentalTrackingIDDataSet;
        FindRentalTrackingItemsByRentalTrackingIDDataSetTableAdapters.FindRentalTrackingItemsByRentalTrackingIDTableAdapter aFindRentalTrackingItemsByRentalTrackingIDTableAdapter;

        FindRentalTrackingItemByAssignedProjectIDDataSet aFindRentalTrackingItemByAssignedProjectIDDataSet;
        FindRentalTrackingItemByAssignedProjectIDDataSetTableAdapters.FindRentalTrackingItemByAssignedProjectIDTableAdapter aFindRentalTrackingItemByAssignedProjectIDTableAdapter;

        RentalTrackingItemsDataSet aRentalTrackingItemsDataSet;
        RentalTrackingItemsDataSetTableAdapters.rentaltackingitemsTableAdapter aRentalTrackingItemsTableAdapter;

        RentalTrackingAgreementDataSet aRentalTrackingAgreementDataSet;
        RentalTrackingAgreementDataSetTableAdapters.rentaltrackingagreementTableAdapter aRentalTrackingAgreementTableAdapter;

        InsertRentalTrackingAgreementEntryTableAdapters.QueriesTableAdapter aInsertRentalTrackingAgreementTableAdapter;

        FindRentalTrackingAgreementByRentalTrackingIDDataSet aFindRentalTrackingAgreementByRentalTrackingIDDataSet;
        FindRentalTrackingAgreementByRentalTrackingIDDataSetTableAdapters.FindRentalTrackingAggreementByRentalTrackingIDTableAdapter aFindRentalTrackingAgreementByRentalTrackingIDTableAdapter;

        RentalTrackingDocumentationDataSet aRentalTrackingDocumentationDataSet;
        RentalTrackingDocumentationDataSetTableAdapters.rentaltrackingdocumentationTableAdapter aRentalTrackingDocumentationTableAdapter;

        InsertRentalTrackingDocumentationEntryTableAdapters.QueriesTableAdapter aInsertRentalTrackingDocumentationTableAdapter;

        FindRentalTrackingDocumentationByRentalTrackingIDDataSet aFindRentalTrackingDocumentationByRentalTrackingIDDataSet;
        FindRentalTrackingDocumentationByRentalTrackingIDDataSetTableAdapters.FindRentalTrackingDocumentationByRentalTackingIDTableAdapter aFindRentalTrackingDocumentationByRentalTrackingIDTableAdapter;

        FindRentalTrackingTransactionByRequestingDateMatchDataSet aFindRentalTrackingTransactionByRequestingDateMatchDataSet;
        FindRentalTrackingTransactionByRequestingDateMatchDataSetTableAdapters.FindRentalTrackingTransactionByRequestingDateMatchTableAdapter aFindRentalTrackingTransactionByRequestingDateMatchTableAdapter;

        FindRentalTransactionByTransactionIDDataSet aFindRentalTransactionByTransactionIDDataSet;
        FindRentalTransactionByTransactionIDDataSetTableAdapters.FindRentalTransactionByTransactionIDTableAdapter aFindRentalTransactionByTransactionIDTableAdapter;

        public FindRentalTransactionByTransactionIDDataSet FindRentalTransactionByTransactionID(int intTransactionID)
        {
            try
            {
                aFindRentalTransactionByTransactionIDDataSet = new FindRentalTransactionByTransactionIDDataSet();
                aFindRentalTransactionByTransactionIDTableAdapter = new FindRentalTransactionByTransactionIDDataSetTableAdapters.FindRentalTransactionByTransactionIDTableAdapter();
                aFindRentalTransactionByTransactionIDTableAdapter.Fill(aFindRentalTransactionByTransactionIDDataSet.FindRentalTransactionByTransactionID, intTransactionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Rental Tracking Class // Find Rental Transaction By Transaction ID " + Ex.Message);
            }

            return aFindRentalTransactionByTransactionIDDataSet;
        }
        public FindRentalTrackingTransactionByRequestingDateMatchDataSet FindRentalTrackingTransactionByRequestingDateMatch(DateTime datRequestingDate)
        {
            try
            {
                aFindRentalTrackingTransactionByRequestingDateMatchDataSet = new FindRentalTrackingTransactionByRequestingDateMatchDataSet();
                aFindRentalTrackingTransactionByRequestingDateMatchTableAdapter = new FindRentalTrackingTransactionByRequestingDateMatchDataSetTableAdapters.FindRentalTrackingTransactionByRequestingDateMatchTableAdapter();
                aFindRentalTrackingTransactionByRequestingDateMatchTableAdapter.Fill(aFindRentalTrackingTransactionByRequestingDateMatchDataSet.FindRentalTrackingTransactionByRequestingDateMatch, datRequestingDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Rental Tracking Class // Find Rental Tracking Transaction By Requesting Date " + Ex.Message);
            }

            return aFindRentalTrackingTransactionByRequestingDateMatchDataSet;
        }
        public FindRentalTrackingDocumentationByRentalTrackingIDDataSet FindRentalTrackingDocumentationByRentalTrackingID(int intRentalTrackingID)
        {
            try
            {
                aFindRentalTrackingDocumentationByRentalTrackingIDDataSet = new FindRentalTrackingDocumentationByRentalTrackingIDDataSet();
                aFindRentalTrackingDocumentationByRentalTrackingIDTableAdapter = new FindRentalTrackingDocumentationByRentalTrackingIDDataSetTableAdapters.FindRentalTrackingDocumentationByRentalTackingIDTableAdapter();
                aFindRentalTrackingDocumentationByRentalTrackingIDTableAdapter.Fill(aFindRentalTrackingDocumentationByRentalTrackingIDDataSet.FindRentalTrackingDocumentationByRentalTackingID, intRentalTrackingID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Rental Tracking Class // Find Rental Tracking Documentation By Rental Tracking ID " + Ex.Message);
            }

            return aFindRentalTrackingDocumentationByRentalTrackingIDDataSet;
        }
        public bool InsertRentalTrackingDocumentation(int intRentalTrackingID, int intEmployeeID, string strDocumentType, string strDocumentPath)
        {
            bool blnFatalError = false;

            try
            {
                aInsertRentalTrackingDocumentationTableAdapter = new InsertRentalTrackingDocumentationEntryTableAdapters.QueriesTableAdapter();
                aInsertRentalTrackingDocumentationTableAdapter.InsertRentalTrackingDocumentation(intRentalTrackingID, intEmployeeID, strDocumentType, strDocumentPath);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Rental Tracking Class // Insert Rental Tracking Documentation " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public RentalTrackingDocumentationDataSet GetRentalTrackingDocumentationInfo()
        {
            try
            {
                aRentalTrackingDocumentationDataSet = new RentalTrackingDocumentationDataSet();
                aRentalTrackingDocumentationTableAdapter = new RentalTrackingDocumentationDataSetTableAdapters.rentaltrackingdocumentationTableAdapter();
                aRentalTrackingDocumentationTableAdapter.Fill(aRentalTrackingDocumentationDataSet.rentaltrackingdocumentation);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Rental Tracking Class // Get Rental Tracking Documentation Info " + Ex.Message);
            }

            return aRentalTrackingDocumentationDataSet;
        }
        public void UpdateRentalTrackingDocumentationDB(RentalTrackingDocumentationDataSet aRentalTrackingDocumentationDataSet)
        {
            try
            {
                aRentalTrackingDocumentationTableAdapter = new RentalTrackingDocumentationDataSetTableAdapters.rentaltrackingdocumentationTableAdapter();
                aRentalTrackingDocumentationTableAdapter.Update(aRentalTrackingDocumentationDataSet.rentaltrackingdocumentation);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Rental Tracking Class // Update Rental Tracking Documentation DB " + Ex.Message);
            }
        }
        public FindRentalTrackingAgreementByRentalTrackingIDDataSet FindRentalTrackingAgreementByRentalTrackingID(int intRentalTrackingID)
        {
            try
            {
                aFindRentalTrackingAgreementByRentalTrackingIDDataSet = new FindRentalTrackingAgreementByRentalTrackingIDDataSet();
                aFindRentalTrackingAgreementByRentalTrackingIDTableAdapter = new FindRentalTrackingAgreementByRentalTrackingIDDataSetTableAdapters.FindRentalTrackingAggreementByRentalTrackingIDTableAdapter();
                aFindRentalTrackingAgreementByRentalTrackingIDTableAdapter.Fill(aFindRentalTrackingAgreementByRentalTrackingIDDataSet.FindRentalTrackingAggreementByRentalTrackingID, intRentalTrackingID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Rental Tracking Class // Find Rental Tracking Agreement By Rental Tracking ID " + Ex.Message);
            }

            return aFindRentalTrackingAgreementByRentalTrackingIDDataSet;
        }
        public bool InsertRentalTrackingAgreement(int intRentalTrackingID, int intEmployeeID, string strAgreementNumber, string strAgreementPath, string strAgreementNotes)
        {
            bool blnFatalError = false;

            try
            {
                aInsertRentalTrackingAgreementTableAdapter = new InsertRentalTrackingAgreementEntryTableAdapters.QueriesTableAdapter();
                aInsertRentalTrackingAgreementTableAdapter.InsertRentalTrackingAgreement(intRentalTrackingID, intEmployeeID, strAgreementNumber, strAgreementPath, strAgreementNotes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Rental Tracking Class // Insert Rental Tracking Agreement " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public RentalTrackingAgreementDataSet GetRentalTrackingAgreementInfo()
        {
            try
            {
                aRentalTrackingAgreementDataSet = new RentalTrackingAgreementDataSet();
                aRentalTrackingAgreementTableAdapter = new RentalTrackingAgreementDataSetTableAdapters.rentaltrackingagreementTableAdapter();
                aRentalTrackingAgreementTableAdapter.Fill(aRentalTrackingAgreementDataSet.rentaltrackingagreement);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Rental Tracking Class // Get Rental Tracking Agreement Info " + Ex.Message);
            }

            return aRentalTrackingAgreementDataSet;
        }
        public void UpdateRentalTrackingAgreementDB(RentalTrackingAgreementDataSet aRentalTrackingAgreementDataSet)
        {
            try
            {
                aRentalTrackingAgreementTableAdapter = new RentalTrackingAgreementDataSetTableAdapters.rentaltrackingagreementTableAdapter();
                aRentalTrackingAgreementTableAdapter.Update(aRentalTrackingAgreementDataSet.rentaltrackingagreement);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Rental Tracking Class // Get Rental Tracking Agreement Info " + Ex.Message);
            }
        }
        public  RentalTrackingItemsDataSet GetRentalTrackingItemsInfo()
        {
            try
            {
                aRentalTrackingItemsDataSet = new RentalTrackingItemsDataSet();
                aRentalTrackingItemsTableAdapter = new RentalTrackingItemsDataSetTableAdapters.rentaltackingitemsTableAdapter();
                aRentalTrackingItemsTableAdapter.Fill(aRentalTrackingItemsDataSet.rentaltackingitems);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Rental Tracking Class // Get Rental Tracking Items Info " + Ex.Message);
            }

            return aRentalTrackingItemsDataSet;
        }
        public void UpdateRentalTrackingItemsDB(RentalTrackingItemsDataSet aRentalTrackingItemsDataSet)
        {
            try
            {
                aRentalTrackingItemsTableAdapter = new RentalTrackingItemsDataSetTableAdapters.rentaltackingitemsTableAdapter();
                aRentalTrackingItemsTableAdapter.Update(aRentalTrackingItemsDataSet.rentaltackingitems);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Rental Tracking Class // Update Rental Tracking Items DB " + Ex.Message);
            }
        }
        public FindRentalTrackingItemByAssignedProjectIDDataSet FindRentalTrackingItemByAssignedProjectID(string strAssignedProjectID)
        {
            try
            {
                aFindRentalTrackingItemByAssignedProjectIDDataSet = new FindRentalTrackingItemByAssignedProjectIDDataSet();
                aFindRentalTrackingItemByAssignedProjectIDTableAdapter = new FindRentalTrackingItemByAssignedProjectIDDataSetTableAdapters.FindRentalTrackingItemByAssignedProjectIDTableAdapter();
                aFindRentalTrackingItemByAssignedProjectIDTableAdapter.Fill(aFindRentalTrackingItemByAssignedProjectIDDataSet.FindRentalTrackingItemByAssignedProjectID, strAssignedProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Rental Tracking Class // Find Rental Tracking Item By Assigned Project ID " + Ex.Message);
            }

            return aFindRentalTrackingItemByAssignedProjectIDDataSet;
        }
        public FindRentalTrackingItemsByRentalTrackingIDDataSet FindRentalTrackingItemsByRentalTrackingID(int intRentalTrackingID)
        {
            try
            {
                aFindRentalTrackingItemsByRentalTrackingIDDataSet = new FindRentalTrackingItemsByRentalTrackingIDDataSet();
                aFindRentalTrackingItemsByRentalTrackingIDTableAdapter = new FindRentalTrackingItemsByRentalTrackingIDDataSetTableAdapters.FindRentalTrackingItemsByRentalTrackingIDTableAdapter();
                aFindRentalTrackingItemsByRentalTrackingIDTableAdapter.Fill(aFindRentalTrackingItemsByRentalTrackingIDDataSet.FindRentalTrackingItemsByRentalTrackingID, intRentalTrackingID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Rental Tracking Class \\ Find Rental Tracking Items By Rental Tracking ID " + Ex.Message);
            }

            return aFindRentalTrackingItemsByRentalTrackingIDDataSet;
        }
        public bool InsertIntoRentalTrackingItems(int intRentalTrackingID, string strRentalPartNumber, string strRentalDescription, bool blnAccessoriesAttached, int intEmployeeID, string strItemNotes)
        {
            bool blnFatalError = false;

            try
            {
                aInsertIntoRentalTrackingItemsTableAdapter = new InsertIntoRentalTrackingItemsEntryTableAdapters.QueriesTableAdapter();
                aInsertIntoRentalTrackingItemsTableAdapter.InsertIntoRentalTrackingItems(intRentalTrackingID, strRentalPartNumber, strRentalDescription, blnAccessoriesAttached, intEmployeeID, strItemNotes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Rental Tracking Class // Insert Into Rental Tracking Items " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
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
        public FindRentalTrackingTransactionsByPONumberDataSet FindRentalTrackingTransactionByPONumber(string strPONumber)
        {
            try
            {
                aFindRentalTrackingTransactionByPONumberDataSet = new FindRentalTrackingTransactionsByPONumberDataSet();
                aFindRentalTrackingTransactionByPONumberTableAdapter = new FindRentalTrackingTransactionsByPONumberDataSetTableAdapters.FindRentalTrackingTransactionByPONumberTableAdapter();
                aFindRentalTrackingTransactionByPONumberTableAdapter.Fill(aFindRentalTrackingTransactionByPONumberDataSet.FindRentalTrackingTransactionByPONumber, strPONumber);
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
        public bool InsertRentalTrackingTransaction(DateTime datRequestingDate, string strPONumber, int intEmployeeID, int intVendorID, DateTime datPickupDate, DateTime datExpirationDate, int intRequestedDays, decimal decTotalCost, int intProjectID, decimal decProjectedCost)
        {
            bool blnFatalError = false;

            try
            {
                aInsertRentalTrackingTransactionTableAdapter = new InsertRentalTrackingTransactionEntryTableAdapters.QueriesTableAdapter();
                aInsertRentalTrackingTransactionTableAdapter.InsertRentalTrackingTransaction(datRequestingDate, strPONumber, intEmployeeID, intVendorID, datPickupDate, datExpirationDate, intRequestedDays, decTotalCost, intProjectID, decProjectedCost);
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
