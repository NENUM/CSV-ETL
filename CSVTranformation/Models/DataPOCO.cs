using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ChoETL;
using CsvHelper.Configuration.Attributes;

namespace CSVTranformation.Models
{
    
    internal class DataPOCO
    {
        [JsonProperty("Record ID")]
        [Name("Record ID")]
        public string RecordID { get; set; }

        [JsonProperty("Created Date")]
        [Name("Created Date")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty("Record Lock")]
        [Name("Record Lock")]
        public string RecordLock { get; set; }

        public string Branch { get; set; }

        [JsonProperty("Business Id")]
        [Name("Business Id")]
        public string BusinessId { get; set; }

        [JsonProperty("First Name")]
        [Name("First Name")]
        public string FirstName { get; set; }

        [JsonProperty("Last Name")]
        [Name("Last Name")]
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Salutations { get; set; }

        [JsonProperty("Customer External ID")]
        [Name("Customer External ID")]
        public string CustomerExternalID { get; set; }

        [JsonProperty("Full Name")]
        [Name("Full Name")]
        public string FullName { get; set; }

        [JsonProperty("ID Card No.")]
        [Name("ID Card No.")]
        public string IDCardNo { get; set; }

        [JsonProperty("Customer Address")]
        [Name("Customer Address")]
        public string CustomerAddress { get; set; }

        [JsonProperty("Customer District")]
        [Name("Customer District")]
        public string CustomerDistrict { get; set; }

        [JsonProperty("Customer Region")]
        [Name("Customer Region")]
        public string CustomerRegion { get; set; }

        [JsonProperty("Home Phone")]
        [Name("Home Phone")]
        public string HomePhone { get; set; }

        [JsonProperty("Office Phone")]
        [Name("Office Phone")]
        public string OfficePhone { get; set; }

        [JsonProperty("Fax No.")]
        [Name("Fax No.")]
        public string FaxNo { get; set; }

        [JsonProperty("License Under")]
        [Name("License Under")]
        public string LicenseUnder { get; set; }

        [JsonProperty("Customer Source of Business")]
        [Name("Customer Source of Business")]
        public string CustomerSourceofBusiness { get; set; }

        [JsonProperty("Company Name - lookup")]
        public string CompanyNamelookup { get; set; }

        [JsonProperty("Company Name")]
        public string CompanyName { get; set; }

        [JsonProperty("Company Registration Number")]
        public string CompanyRegistrationNumber { get; set; }

        [JsonProperty("Company External ID")]
        public string CompanyExternalID { get; set; }

        [JsonProperty("Company Address")]
        public string CompanyAddress { get; set; }

        [JsonProperty("Company District")]
        public string CompanyDistrict { get; set; }

        [JsonProperty("Company Region")]
        public string CompanyRegion { get; set; }

        [JsonProperty("Main Work Phone")]
        public string MainWorkPhone { get; set; }

        [JsonProperty("Company Email")]
        public string CompanyEmail { get; set; }

        [JsonProperty("Company Source of Business")]
        public string CompanySourceofBusiness { get; set; }

        [JsonProperty("Order Date")]
        public string OrderDate { get; set; }

        [JsonProperty("Franchise Code")]
        public string FranchiseCode { get; set; }

        [JsonProperty("Stock No")]
        public string StockNo { get; set; }

        [JsonProperty("Vehicle Code")]
        public string VehicleCode { get; set; }
        public string Variant { get; set; }
        public string Colour { get; set; }

        [JsonProperty("Trim Label")]
        public string TrimLabel { get; set; }

        [JsonProperty("Vehicle Remarks")]
        public string VehicleRemarks { get; set; }

        [JsonProperty("Vehicle Price")]
        public string VehiclePrice { get; set; }

        [JsonProperty("Number of Vehicles")]
        public string NumberofVehicles { get; set; }

        [JsonProperty("Vehicle Discount")]
        public string VehicleDiscount { get; set; }

        [JsonProperty("License Plate")]
        public string LicensePlate { get; set; }

        [JsonProperty("Dealer Option Code 01")]
        public string DealerOptionCode01 { get; set; }

        [JsonProperty("Dealer Option Code 02")]
        public string DealerOptionCode02 { get; set; }

        [JsonProperty("Dealer Option Code 03")]
        public string DealerOptionCode03 { get; set; }

        [JsonProperty("Dealer Option Code 04")]
        public string DealerOptionCode04 { get; set; }

        [JsonProperty("Dealer Option Code 05")]
        public string DealerOptionCode05 { get; set; }

        [JsonProperty("Dealer Option Code 06")]
        public string DealerOptionCode06 { get; set; }

        [JsonProperty("Dealer Option Code 07")]
        public string DealerOptionCode07 { get; set; }

        [JsonProperty("Dealer Option Code 08")]
        public string DealerOptionCode08 { get; set; }

        [JsonProperty("Dealer Option Code 09")]
        public string DealerOptionCode09 { get; set; }

        [JsonProperty("Dealer Option Code 10")]
        public string DealerOptionCode10 { get; set; }

        [JsonProperty("Dealer Option Code 11")]
        public string DealerOptionCode11 { get; set; }

        [JsonProperty("Dealer Option Code 12")]
        public string DealerOptionCode12 { get; set; }

        [JsonProperty("Dealer Option Code 13")]
        public string DealerOptionCode13 { get; set; }

        [JsonProperty("Dealer Option Code 14")]
        public string DealerOptionCode14 { get; set; }

        [JsonProperty("Dealer Option Code 15")]
        public string DealerOptionCode15 { get; set; }

        [JsonProperty("Dealer Option Price 01")]
        public string DealerOptionPrice01 { get; set; }

        [JsonProperty("Dealer Option Price 02")]
        public string DealerOptionPrice02 { get; set; }

        [JsonProperty("Dealer Option Price 03")]
        public string DealerOptionPrice03 { get; set; }

        [JsonProperty("Dealer Option Price 04")]
        public string DealerOptionPrice04 { get; set; }

        [JsonProperty("Dealer Option Price 05")]
        public string DealerOptionPrice05 { get; set; }

        [JsonProperty("Dealer Option Price 06")]
        public string DealerOptionPrice06 { get; set; }

        [JsonProperty("Dealer Option Price 07")]
        public string DealerOptionPrice07 { get; set; }

        [JsonProperty("Dealer Option Price 08")]
        public string DealerOptionPrice08 { get; set; }

        [JsonProperty("Dealer Option Price 09")]
        public string DealerOptionPrice09 { get; set; }

        [JsonProperty("Dealer Option Price 10")]
        public string DealerOptionPrice10 { get; set; }

        [JsonProperty("Dealer Option Price 11")]
        public string DealerOptionPrice11 { get; set; }

        [JsonProperty("Dealer Option Price 12")]
        public string DealerOptionPrice12 { get; set; }

        [JsonProperty("Dealer Option Price 13")]
        public string DealerOptionPrice13 { get; set; }

        [JsonProperty("Dealer Option Price 14")]
        public string DealerOptionPrice14 { get; set; }

        [JsonProperty("Dealer Option Price 15")]
        public string DealerOptionPrice15 { get; set; }

        [JsonProperty("Ent Option Code 01")]
        public string EntOptionCode01 { get; set; }

        [JsonProperty("Ent Option Code 02")]
        public string EntOptionCode02 { get; set; }

        [JsonProperty("Ent Option Code 03")]
        public string EntOptionCode03 { get; set; }

        [JsonProperty("Ent Option Price 01")]
        public string EntOptionPrice01 { get; set; }

        [JsonProperty("Ent Option Price 02")]
        public string EntOptionPrice02 { get; set; }

        [JsonProperty("Ent Option Price 03")]
        public string EntOptionPrice03 { get; set; }

        [JsonProperty("Extended Warranty Code 01")]
        public string ExtendedWarrantyCode01 { get; set; }

        [JsonProperty("Extended Warranty Code 02")]
        public string ExtendedWarrantyCode02 { get; set; }

        [JsonProperty("Extended Warranty Price 01")]
        public string ExtendedWarrantyPrice01 { get; set; }

        [JsonProperty("Extended Warranty Price 02")]
        public string ExtendedWarrantyPrice02 { get; set; }

        [JsonProperty("Service Gift Code 01")]
        public string ServiceGiftCode01 { get; set; }

        [JsonProperty("Service Gift Code 02")]
        public string ServiceGiftCode02 { get; set; }

        [JsonProperty("Service Gift Code 03")]
        public string ServiceGiftCode03 { get; set; }

        [JsonProperty("Service Gift Price 01")]
        public string ServiceGiftPrice01 { get; set; }

        [JsonProperty("Service Gift Price 02")]
        public string ServiceGiftPrice02 { get; set; }

        [JsonProperty("Service Gift Price 03")]
        public string ServiceGiftPrice03 { get; set; }

        [JsonProperty("Vehicle Usage")]
        public string VehicleUsage { get; set; }

        [JsonProperty("First Registration Tax")]
        public string FirstRegistrationTax { get; set; }

        [JsonProperty("License Fee")]
        public string LicenseFee { get; set; }

        [JsonProperty("Registration Fee")]
        public string RegistrationFee { get; set; }
        public string TAVAF { get; set; }

        [JsonProperty("Tax Fees Code 01")]
        public string TaxFeesCode01 { get; set; }

        [JsonProperty("Tax Fees Code 02")]
        public string TaxFeesCode02 { get; set; }

        [JsonProperty("Tax Fees Code 03")]
        public string TaxFeesCode03 { get; set; }

        [JsonProperty("Tax Fees Code 04")]
        public string TaxFeesCode04 { get; set; }

        [JsonProperty("Tax Fees Code 05")]
        public string TaxFeesCode05 { get; set; }

        [JsonProperty("Tax Fees Price 01")]
        public string TaxFeesPrice01 { get; set; }

        [JsonProperty("Tax Fees Price 02")]
        public string TaxFeesPrice02 { get; set; }

        [JsonProperty("Tax Fees Price 03")]
        public string TaxFeesPrice03 { get; set; }

        [JsonProperty("Tax Fees Price 04")]
        public string TaxFeesPrice04 { get; set; }

        [JsonProperty("Tax Fees Price 05")]
        public string TaxFeesPrice05 { get; set; }

        [JsonProperty("Total Vehicle Price")]
        public string TotalVehiclePrice { get; set; }

        [JsonProperty("Insurance Flag")]
        public string InsuranceFlag { get; set; }

        [JsonProperty("Vehicle Insurance")]
        public string VehicleInsurance { get; set; }

        [JsonProperty("Insurance By Buyer")]
        public string InsuranceByBuyer { get; set; }

        [JsonProperty("Insurance Plan")]
        public string InsurancePlan { get; set; }

        [JsonProperty("Insurance Company")]
        public string InsuranceCompany { get; set; }

        [JsonProperty("China Coverage Required")]
        public string ChinaCoverageRequired { get; set; }

        [JsonProperty("Insured Amount")]
        public string InsuredAmount { get; set; }

        [JsonProperty("Insurance Premium")]
        public string InsurancePremium { get; set; }

        [JsonProperty("No Claims Discount")]
        public string NoClaimsDiscount { get; set; }
        public string Loading { get; set; }

        [JsonProperty("Loading Pct 1")]
        public string LoadingPct1 { get; set; }

        [JsonProperty("Loading Pct 2")]
        public string LoadingPct2 { get; set; }

        [JsonProperty("Loading Pct 3")]
        public string LoadingPct3 { get; set; }

        [JsonProperty("Opt Out Car Lover Cover")]
        public string OptOutCarLoverCover { get; set; }

        [JsonProperty("Car Lover Amount")]
        public string CarLoverAmount { get; set; }

        [JsonProperty("Opt Out Personal Account Insurance")]
        public string OptOutPersonalAccountInsurance { get; set; }

        [JsonProperty("Personal Account Amount")]
        public string PersonalAccountAmount { get; set; }

        [JsonProperty("Other Insurance Remarks")]
        public string OtherInsuranceRemarks { get; set; }

        [JsonProperty("Trade In?")]
        public string TradeIn { get; set; }

        [JsonProperty("Trade In Make")]
        public string TradeInMake { get; set; }

        [JsonProperty("Trade In Model")]
        public string TradeInModel { get; set; }

        [JsonProperty("Trade In Variant")]
        public string TradeInVariant { get; set; }

        [JsonProperty("Trade In Year")]
        public string TradeInYear { get; set; }

        [JsonProperty("Trade In Colour")]
        public string TradeInColour { get; set; }

        [JsonProperty("Trade In Licence No")]
        public string TradeInLicenceNo { get; set; }

        [JsonProperty("Trade In Chassis No")]
        public string TradeInChassisNo { get; set; }

        [JsonProperty("Trade In Engine No")]
        public string TradeInEngineNo { get; set; }

        [JsonProperty("Trade In Licence Expiry")]
        public string TradeInLicenceExpiry { get; set; }

        [JsonProperty("Trade In Finance Redemption")]
        public string TradeInFinanceRedemption { get; set; }

        [JsonProperty("Trade In Redemption Company")]
        public string TradeInRedemptionCompany { get; set; }

        [JsonProperty("Less Trade In Value")]
        public string LessTradeInValue { get; set; }

        [JsonProperty("Finance Flag")]
        public string FinanceFlag { get; set; }

        [JsonProperty("Outside Finance Company")]
        public string OutsideFinanceCompany { get; set; }

        [JsonProperty("Finance Company")]
        public string FinanceCompany { get; set; }

        [JsonProperty("Program No.")]
        public string ProgramNo { get; set; }

        [JsonProperty("Hire/ Leasing Amount")]
        public string HireLeasingAmount { get; set; }

        [JsonProperty("Interest Rate")]
        public string InterestRate { get; set; }

        [JsonProperty("Finance Tenure (months)")]
        public string FinanceTenuremonths { get; set; }

        [JsonProperty("Monthly Installment")]
        public string MonthlyInstallment { get; set; }

        [JsonProperty("Finance Downpayment")]
        public string FinanceDownpayment { get; set; }

        [JsonProperty("Finance Initial Payment Count")]
        public string FinanceInitialPaymentCount { get; set; }

        [JsonProperty("Finance Initial Payment Amount")]
        public string FinanceInitialPaymentAmount { get; set; }

        [JsonProperty("Finance Initial Payment Total")]
        public string FinanceInitialPaymentTotal { get; set; }

        [JsonProperty("Payment of Finance")]
        public string PaymentofFinance { get; set; }

        [JsonProperty("Deposit Amount 1")]
        public string DepositAmount1 { get; set; }

        [JsonProperty("Deposit Receipt 1")]
        public string DepositReceipt1 { get; set; }

        [JsonProperty("Deposit Amount 2")]
        public string DepositAmount2 { get; set; }

        [JsonProperty("Deposit Receipt 2")]
        public string DepositReceipt2 { get; set; }

        [JsonProperty("Deposit Amount 3")]
        public string DepositAmount3 { get; set; }

        [JsonProperty("Deposit Receipt 3")]
        public string DepositReceipt3 { get; set; }

        [JsonProperty("Deposit Amount 4")]
        public string DepositAmount4 { get; set; }

        [JsonProperty("Deposit Receipt 4")]
        public string DepositReceipt4 { get; set; }

        [JsonProperty("Deposit Amount 5")]
        public string DepositAmount5 { get; set; }

        [JsonProperty("Deposit Receipt 5")]
        public string DepositReceipt5 { get; set; }

        [JsonProperty("Add Redemption Amount")]
        public string AddRedemptionAmount { get; set; }

        [JsonProperty("Total Price")]
        public string TotalPrice { get; set; }

        [JsonProperty("Finance Balance Payable on Delivery")]
        public string FinanceBalancePayableonDelivery { get; set; }

        [JsonProperty("I do not agree")]
        public string Idonotagree { get; set; }

        [JsonProperty("Autoline Salesperson ID")]
        public string AutolineSalespersonID { get; set; }

        [JsonProperty("Opportunity Owner Email")]
        public string OpportunityOwnerEmail { get; set; }


    }

}
