using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


namespace smcaptureLib.Globals
{
    public class ExpenseTypes
    {
        public string ExpenseType { get; set; }
        public int IsLpoExpense { get; set; }

    }
    

    public static class Configuration
    {
        public static class ExpenseTypes
        {
            public const string LpoExpense = "LPO Expense";
            public const string NonLpoExpense = "Other Expense";
        }
        

        public static class TimeSchedule
        {
            public const string DailyTimeSchedule = "Daily";
            public const string MonthlyTimeSchedule = "Monthly";
            public const string WeeklyTimeSchedule = "Weekly";
            public const string AnnuallyTimeSchedule = "Annually";
            public static IEnumerable<string> SupportedPayTypes()
            {
                var result = new List<string>
                {
                    DailyTimeSchedule,
                    MonthlyTimeSchedule,
                    WeeklyTimeSchedule,
                    AnnuallyTimeSchedule
                };
                return result;
            }

          
        }
        public enum ImageFileTypes
        {
            ProfilePicture,
        }
        public static class CommissionItem
        {
            public static string Member = "Members";
            public static string Housingmember = "Housing Member";
            public static string CashCollection = "Cash Collection";
            public static string Share = "Shares";
            public static string GroupMember = "Group Member";
            public static string HousingGroup = "Housing Group";
        }

        public static class CommissionVariables
        {
            public static string Registration = "Registration";
            public static string SpecialDeposits = "Special Deposits";
           
            
        }

        public static class TransactionStages
        {

            public static string ApprovedStageName = "Approved";

        }
        
        public static class ModuleNames
        {
            public static string LoanApplication = "Loan Application";
            public static string LoanApplicationPostEdit = "Loan Application Post Edit";
            public static string OverdraftApplication = "Overdraft Application";

            public static class GeneralJournal
            {
                public static string ModuleName = "General Journal";
                public static string JournalTransfersControl = "JournalTransfers";

            }

            public static List<string> GetLoanAccounts()
            {
                List<string> LoanApplicationModules = new List<string>();
                LoanApplicationModules.Add(LoanApplication);
                LoanApplicationModules.Add(LoanApplicationPostEdit);
                LoanApplicationModules.Add(OverdraftApplication);
                return LoanApplicationModules;
            }
        }
        public static class RateTypes
        {
            public static string FlatRateName = "Flat";
            public static string PerKG = "Per KG";
            public static List<string> SupportedPayTypes()
            {
                var result = new List<string> { FlatRateName, PerKG };
                return result;
            }

        }

        public static class SaccoAccounts
        {
            //public static string LoanAccount = "Loan Account";
            public static string LoanAccount = "Savings Account";
            public static string OvernightAccount = "Savings Account";
            public static string PaymentsAccount = "Payments Account";
            public static string FertilizerAccount = "Fertilizer Account";
            public static string SeedlingsAccount = "Seedlings Account";
            
          
        }

        public static class AdvanceTypes
        {
            public static string Advance = "Advance";
            public static string FarmInputs = "Farm Inputs";
        }

        public static class advanceproducts
        {
            public static string Fertilizer = "Fertilizer";
            public static string Payment = "Payment";
            public static string Seedlings = "Seedlings";
            public static string Retention = "Retention";
            public static string Plucking = "Tea Plucking";
        }
        public static class operationtype
        {
            public static string Fertilizer = "Fertilizer";
            public static string Advance = "Advance";
            public static string Seedlings = "Seedlings";
            public static string CashDeposit = "Cash Deposit";
            public static string Deductions = "Deductions";
            public static string Collections = "Collections";
            public static string Plucking = "Tea Plucking";
            public static string Retention = "Retention";
        }
        public static class MemberShipTypes
        {
            public static string SaccoMember = "FARMER";
            public static string HousingMember = "Transporter";
            public static string MedicalMember = "SUPPLIER";
            public static string EmployeeMember = "Employee";

            public static string GetMemberRegDefaultOPTypeNameMemModule(string memberShipType)
            {

                var memberAccountCreationOperationName = string.Empty;
                if (memberShipType.Equals(SaccoMember, StringComparison.OrdinalIgnoreCase))
                    memberAccountCreationOperationName = OperationTypes.CreatedOnSaccoMemberRegistration;
                else if (memberShipType.Equals(MedicalMember, StringComparison.OrdinalIgnoreCase))
                    memberAccountCreationOperationName = OperationTypes.CreatedOnMedicalSchemeMemberRegistration;
                else if (memberShipType.Equals(HousingMember, StringComparison.OrdinalIgnoreCase))
                    memberAccountCreationOperationName = OperationTypes.CreatedOnHousingMemberRegistration;
                else if (memberShipType.Equals(EmployeeMember, StringComparison.OrdinalIgnoreCase))
                    memberAccountCreationOperationName = OperationTypes.CreatedOnSaccoMemberRegistration;
                return memberAccountCreationOperationName;

            }

            public static string GetCanBeAddedInMemberModuleMemberShipTypeOPTypeName(string MemberShipType)
            {
                var memberAccountCreationOperationName = string.Empty;

                if (MemberShipType.Equals(SaccoMember, StringComparison.OrdinalIgnoreCase))
                    memberAccountCreationOperationName = OperationTypes.VisibleInMemberRegistrationModule;
                else if (MemberShipType.Equals(MedicalMember, StringComparison.OrdinalIgnoreCase))
                    memberAccountCreationOperationName = OperationTypes.VisibleInMemberRegistrationModule;
                else if (MemberShipType.Equals(HousingMember, StringComparison.OrdinalIgnoreCase))
                    memberAccountCreationOperationName = OperationTypes.VisibleInMemberRegistrationModule;

                //if the member ship sub type is group member then ignore setting the variable
                return memberAccountCreationOperationName;
            }

        }
        public static class OperationTypes
        {
            public static string AllowsDeposit = "Allows Deposit";
            public static string CanGuarantee = "Can Guarantee";
            public static string CreatedOnSaccoMemberRegistration = "Created On Sacco Member Registration";
            public static string CreatedOnMedicalSchemeMemberRegistration = "Created On Medical Scheme Member Registration";
            public static string CreatedOnHousingMemberRegistration = "Created On Housing Scheme Member Registration";
            public static string VisibleInMemberRegistrationModule = "Visible In Member Registration Module";
            public static string IsChargesAccount = "Is Charges Account";
            public static string IsSupplierAccount = "Is Supplier Account";

        }


        public static class TransactionTypeNames
        {
            public static string InsertTypeName = "Insert";
        }

        public static List<string> SupportedImageFileType(string fileExtension, ImageFileTypes imageFiles)
        {
            List<string> supportedFiles = new List<string>();
            supportedFiles.Add(".jpg");
            supportedFiles.Add(".png");
            return supportedFiles;
        }

        public static string UnconfiguredUrlRoute = "/Views/Home/NotFoundPage.aspx";
        public static string ParentNodeNameurl = "RootNode";
        public static string UnconfiguredUrlStyling = "";

        public static int ExecRetryCounts = 1;
        public static int ExecMinimumErrorSleepTimes = 1;

        public static int GetRetryCounts = 0;
        public static int GetMinimumErrorSleepTimes = 5;

        public static string AccessDeniedName = "Denied";
        public static string AccessGrantedName = "Granted";

        public static string SMSSubsystemEmailAdress = "lekina.memusi@gmail.com";
        public static string SMSSubsystemPassWord = "0750710030mylove";

        #region login specific configuration
        public static int maxLogInTimeMinutes = 20;

        public static string LoginSuccefullMessage = "Login Successfull";
        public static string LoginCodeRequiredMessage = "Code Required";
        public static string LoginFirstLoginMessage = "First Login Request";
        public static string LoginPasswordRenewed = "Password Renewed";
        public static string LogOutMessage = "UserLogOut";
        public static string LoginScreenLockedMessage = "Screen Locked";
        public static char AuthorizationEntitySplitter = '#';
        public static char CredentialsSplitter = ':';

        #endregion

       

    }
}