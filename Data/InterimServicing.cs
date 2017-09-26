
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace EncompassREST.Data
    {
        public class InterimServicing
{
public string mortgageAccount { get; set; }
public string borrowerFirstName { get; set; }
public string borrowerLastName { get; set; }
public string mailingStreetAddress { get; set; }
public string mailingCity { get; set; }
public string mailingState { get; set; }
public string mailingPostalCode { get; set; }
public string servicingStatus { get; set; }
public DateTime? lastStatementPrintedDate { get; set; }
public DateTime? paymentDueDatePrinted { get; set; }
public string printedByUserName { get; set; }
public string printedByUserId { get; set; }
public DateTime? nextPaymentStatementDueDate { get; set; }
public DateTime? nextPaymentPaymentDueDate { get; set; }
public DateTime? nextPaymentLatePaymentDate { get; set; }
public decimal? nextPaymentIndexCurrentValuePercent { get; set; }
public decimal? nextPaymentRequestedInterestRatePercent { get; set; }
public decimal? nextPaymentPrincipal { get; set; }
public decimal? nextPaymentInterest { get; set; }
public decimal? nextPaymentEscrowAmount { get; set; }
public decimal? nextPaymentPastDueAmount { get; set; }
public decimal? nextPaymentUnpaidLateFee { get; set; }
public decimal? nextPaymentMiscFee { get; set; }
public decimal? nextPaymentTotalAmountDue { get; set; }
public decimal? nextPaymentLateFee { get; set; }
public decimal? nextPaymentTotalAmountWithLateFee { get; set; }
public string lastPaymentGuid { get; set; }
public int? lastPaymentNumber { get; set; }
public DateTime? lastPaymentStatementDate { get; set; }
public DateTime? lastPaymentReceivedDate { get; set; }
public decimal? lastPaymentTotalAmountReceived { get; set; }
public decimal? lastPaymentPrincipal { get; set; }
public decimal? lastPaymentInterest { get; set; }
public decimal? lastPaymentEscrowAmount { get; set; }
public decimal? lastPaymentLateFee { get; set; }
public decimal? lastPaymentAdditionalPrincipal { get; set; }
public int? totalNumberOfPayment { get; set; }
public int? totalNumberOfLatePayment { get; set; }
public decimal? totalPrincipal { get; set; }
public decimal? totalPrincipalYearToDate { get; set; }
public decimal? totalInterest { get; set; }
public decimal? totalInterestYearToDate { get; set; }
public decimal? totalPAndI { get; set; }
public decimal? totalPAndIYearToDate { get; set; }
public decimal? totalEscrow { get; set; }
public decimal? totalEscrowYearToDate { get; set; }
public decimal? totalLateFee { get; set; }
public decimal? totalLateFeeYearToDate { get; set; }
public decimal? totalAdditionalPrincipal { get; set; }
public decimal? totalAdditionalPrincipalYearToDate { get; set; }
public decimal? totalAdditionalEscrow { get; set; }
public decimal? totalAdditionalEscrowYearToDate { get; set; }
public decimal? totalPaymentCollected { get; set; }
public decimal? totalPaymentCollectedYearToDate { get; set; }
public decimal? currentPrincipalBalance { get; set; }
public decimal? nextEscrowTotalTax { get; set; }
public DateTime? nextEscrowTotalTaxDueDate { get; set; }
public decimal? nextEscrowTotalHazardInsurance { get; set; }
public DateTime? nextEscrowTotalHazardInsuranceDueDate { get; set; }
public decimal? nextEscrowTotalMortgageInsurance { get; set; }
public DateTime? nextEscrowTotalMortgageInsuranceDueDate { get; set; }
public decimal? nextEscrowTotalFloodInsurance { get; set; }
public DateTime? nextEscrowTotalFloodInsuranceDueDate { get; set; }
public decimal? nextEscrowTotalPropertyTax { get; set; }
public DateTime? nextEscrowTotalPropertyTaxDueDate { get; set; }
public decimal? nextEscrowTotalOtherTax1 { get; set; }
public DateTime? nextEscrowTotalOtherTax1DueDate { get; set; }
public decimal? nextEscrowTotalOtherTax2 { get; set; }
public DateTime? nextEscrowTotalOtherTax2DueDate { get; set; }
public decimal? nextEscrowTotalOtherTax3 { get; set; }
public DateTime? nextEscrowTotalOtherTax3DueDate { get; set; }
public int? numberOfDisbursement { get; set; }
public decimal? totalTaxes { get; set; }
public decimal? totalHazardInsurance { get; set; }
public decimal? totalMortgageInsurance { get; set; }
public decimal? totalOtherTaxes { get; set; }
public decimal? totalAmountDisbursed { get; set; }
public decimal? escrowBalance { get; set; }
public decimal? nextPaymentPrincipalAndInterest { get; set; }
public decimal? lastPaymentPrincipalAndInterest { get; set; }
public decimal? lastPaymentMiscFee { get; set; }
public decimal? lastPaymentAdditionalEscrow { get; set; }
public decimal? totalMiscFee { get; set; }
public decimal? totalMiscFeeYearToDate { get; set; }
public decimal? floodInsurance { get; set; }
public decimal? cityInsurance { get; set; }
public decimal? unpaidPrincipal { get; set; }
public decimal? unpaidInterest { get; set; }
public decimal? unpaidEscrow { get; set; }
public decimal? unpaidMiscrFee { get; set; }
public decimal? unpaidLateFee { get; set; }
public DateTime? nextPaymentPaymentIndexDate { get; set; }
public decimal? nextPaymentBuydownSubsidyAmount { get; set; }
public decimal? lastPaymentBuydownSubsidyAmount { get; set; }
public decimal? totalBuydownSubsidyAmount { get; set; }
public decimal? totalBuydownSubsidyAmountYearToDate { get; set; }
public decimal? unpaidBuydownSubsidyAmount { get; set; }
public decimal? nextEscrowTotalUsdaMonthlyPremium { get; set; }
public DateTime? nextEscrowTotalUsdaMonthlyPremiumDueDate { get; set; }
public decimal? totalUsdaMonthlyPremium { get; set; }
public string servicerLoanNumber { get; set; }
public DateTime? servicingTransferDate { get; set; }
public string subServicer { get; set; }
public string subServicerLoanNumber { get; set; }
public decimal? nextPaymentEscrowTax { get; set; }
public decimal? nextPaymentEscrowHazardInsurance { get; set; }
public decimal? nextPaymentEscrowMortgageInsurance { get; set; }
public decimal? nextPaymentEscrowFloodInsurance { get; set; }
public decimal? nextPaymentEscrowCityPropertyTax { get; set; }
public decimal? nextPaymentEscrowOther1 { get; set; }
public decimal? nextPaymentEscrowOther2 { get; set; }
public decimal? nextPaymentEscrowOther3 { get; set; }
public decimal? nextPaymentEscrowUSDAMonthlyPremium { get; set; }
public decimal? lastPaymentEscrowTax { get; set; }
public decimal? lastPaymentEscrowHazardInsurance { get; set; }
public decimal? lastPaymentEscrowMortgageInsurance { get; set; }
public decimal? lastPaymentEscrowFloodInsurance { get; set; }
public decimal? lastPaymentEscrowCityPropertyTax { get; set; }
public decimal? lastPaymentEscrowOther1 { get; set; }
public decimal? lastPaymentEscrowOther2 { get; set; }
public decimal? lastPaymentEscrowOther3 { get; set; }
public decimal? lastPaymentEscrowUSDAMonthlyPremium { get; set; }
public decimal? unpaidEscrowTax { get; set; }
public decimal? unpaidEscrowMortgageInsurance { get; set; }
public decimal? unpaidEscrowHazardInsurance { get; set; }
public decimal? unpaidEscrowFloodInsurance { get; set; }
public decimal? unpaidEscrowCityPropertyTax { get; set; }
public decimal? unpaidEscrowOther1 { get; set; }
public decimal? unpaidEscrowOther2 { get; set; }
public decimal? unpaidEscrowOther3 { get; set; }
public decimal? unpaidEscrowUSDAMonthlyPremium { get; set; }
public decimal? purchasedPrincipal { get; set; }
public string borrHomePhoneNumber { get; set; }
public string borrWorkPhoneNumber { get; set; }
public string borrCellPhoneNumber { get; set; }
public string borrHomeEmail { get; set; }
public string calcTriggered { get; set; }
public string comments { get; set; }
public string id { get; set; }
public List<EscrowDisbursementTransaction> escrowDisbursementTransactions { get; set; }
public List<EscrowInterestTransaction> escrowInterestTransactions { get; set; }
public List<InterimServicingTransaction> interimServicingTransactions { get; set; }
public string loanSnapshotXml { get; set; }
public List<OtherTransaction> otherTransactions { get; set; }
public List<PaymentReversalTransaction> paymentReversalTransactions { get; set; }
public List<PaymentTransaction> paymentTransactions { get; set; }
public List<SchedulePaymentTransaction> schedulePaymentTransactions { get; set; }
public List<SchedulePaymentTransaction> scheduledPayments { get; set; }
public SchedulePaymentTransaction nextScheduledPayment { get; set; }
public SchedulePaymentTransaction lastScheduledPayment { get; set; }

    }
}