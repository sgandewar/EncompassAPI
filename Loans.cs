﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EncompassREST.Data;
using EncompassREST.Exceptions;
using EncompassREST.HelperClasses;
using Newtonsoft.Json;
using System.Diagnostics;

namespace EncompassREST
{
    public class Loans
    {
        private const string _apiPath = "encompass/v1/loans";
        private readonly List<string> _supportedEntities = new List<string> {
            "AdditionalRequests",
            "AdditionalStateDisclosure",
            "AffiliatedBusinessArrangement",
            "AntiSteeringLoanOption",
            "Application",
            "Asset",
            "AUSTrackingLog",
            "ATRQMBorrower",
            "ATRQMCommon",
            "Borrower",
            "CoBorrower",
            "Buydown",
            "ClosingCost",
            "ClosingDisclosure1",
            "ClosingDisclosure2",
            "ClosingDisclosure3",
            "ClosingDisclosure4",
            "ClosingDisclosure5",
            "ClosingDocument",
            "ClosingEntity",
            "CommitmentTerms",
            "ComplianceTestLog",
            "Contact",
            "ConstructionManagement",
            "ConversationLog",
            "Correspondent",
            "CrmLog",
            "CustomField",
            "DataTracLog",
            "DisclosureForm",
            "DisclosureNotices",
            "DisclosureTracking2015Log",
            "DisclosureTrackingLog",
            "DocumentLog",
            "DownloadLog",
            "DownPayment",
            "EdmDocument",
            "EdmLog",
            "ElliLOCompensation",
            "EmailTriggerLog",
            "EmDocumentInvestor",
            "EmDocumentLender",
            "EmDocument",
            "Employment",
            "EnergyEfficientMortgageItem",
            "EnergyEfficientMortgage",
            "EscrowDisbursementTransaction",
            "EscrowInterestTransaction",
            "FannieMae",
            "Fee",
            "FeeVariance",
            "FeeVarianceOther",
            "FhaVaLoan",
            "Form",
            "FreddieMac",
            "Funding",
            "Gfe2010Fee",
            "Gfe2010FwbcFwsc",
            "Gfe2010GfeCharge",
            "Gfe2010",
            "Gfe2010Page",
            "Gfe2010Section",
            "Gfe2010WholePoc",
            "GfeFee",
            "GfeLien",
            "Gfe",
            "GfePayment",
            "GfePayoff",
            "HelocRepaymentDrawPeriod",
            "Hmda",
            "HomeCounselingProvider",
            "HtmlEmailLog",
            "Hud1EsDate",
            "Hud1EsDueDate",
            "Hud1EsItemize",
            "Hud1Es",
            "Hud1EsPayTo",
            "Hud1EsSetup",
            "HudLoanData",
            "Income",
            "InterimServicing",
            "InterimServicingTransaction",
            "Liability",
            "Loan",
            "LoanAssociate",
            "LoanEstimate1",
            "LoanEstimate2",
            "LoanEstimate3",
            "LoanProductData",
            "LoanProgram",
            "LoanSubmissionFee",
            "LoanSubmission",
            "LockCancellationLog",
            "LockConfirmLog",
            "LockDenialLog",
            "LockRequestBorrower",
            "LockRequestLog",
            "LOCompensation",
            "LogAlert",
            "LogComment",
            "LogEntryLog",
            "LogRecord",
            "LogSnapshotField",
            "Mcaw",
            "MilestoneFreeRoleLog",
            "MilestoneLog",
            "MilestoneTaskContact",
            "MilestoneTaskLog",
            "MilestoneTemplateLog",
            "MilitaryService",
            "Miscellaneous",
            "NetTangibleBenefit",
            "NewYorkFee",
            "NewYorkPrimaryLender",
            "OtherTransaction",
            "PaymentReversalTransaction",
            "PaymentTransaction",
            "PostClosingConditionLog",
            "PreliminaryConditionLog",
            "PrepaymentPenalty",
            "Prequalification",
            "PrequalificationScenario",
            "PreviousVaLoan",
            "PriceAdjustment",
            "PrintForm",
            "PrintLog",
            "PrivacyPolicy",
            "ProfitManagementItem",
            "ProfitManagement",
            "Property",
            "PurchaseAdvicePayout",
            "PurchaseCredit",
            "RateLock",
            "RegistrationLog",
            "RegulationZInterestRatePeriod",
            "RegulationZ",
            "RegulationZPayment",
            "ReoProperty",
            "Residence",
            "RespaHudDetail",
            "SchedulePaymentTransaction",
            "SecondaryFinancingProvider",
            "Section32",
            "SelectedHomeCounselingProvider",
            "SelfEmployedIncome",
            "ServiceProviderContact",
            "ServicingDisclosure",
            "SettlementServiceCharge",
            "ShippingContact",
            "Shipping",
            "StateDisclosure",
            "StateLicense",
            "StatementCreditDenial",
            "StatusOnlineEvent",
            "StatusOnlineLog",
            "Tax4506",
            "TPO",
            "TQLComplianceAlert",
            "TQLDocument",
            "TQLFraudAlert",
            "TQL",
            "TQLReportInformation",
            "TrustAccountItem",
            "TrustAccount",
            "Tsum",
            "UCDDetail",
            "Uldd",
            "UnderwriterSummary",
            "UnderwritingConditionLog",
            "UsdaHouseholdIncome",
            "Usda",
            "VaLoanData",
            "VerificationLog",
            "LoanActionLog",
            "FieldLockData",
            "FundingFee"
        };

        #region Private Properties
        private AccessToken AccessToken => Session.AccessToken;

        private HttpClient Client => Session.RESTClient;
        #endregion

        #region Public Properties
        public Session Session { get; }
        #endregion

        public Loans(Session session)
        {
            Session = session;
        }

        public Task<Loan> GetLoanAsync(string guid) => GetLoanAsync(guid, null);

        public async Task<Loan> GetLoanAsync(string guid, IEnumerable<string> entities)
        {
            //TaskCompletionSource<Loan> tcs = new TaskCompletionSource<Loan>();
            var rp = new RequestParameters();
            if (entities!= null)
            {
                if (entities.Count() > 0)
                {
                    //var eList = await GetSupportedEntitiesAsync();
                    var exList = entities.Except(_supportedEntities);
                    if (exList.Count() > 0)
                        throw new InvalidEntitiesException(exList);
                    rp.Add("entities", string.Join(",", entities));
                }
            }
            var message = new HttpRequestMessage(HttpMethod.Get, $"{_apiPath}/{guid}{rp}");
            Stopwatch s = new Stopwatch();
            s.Start();
            var response = await Client.SendAsync(message);
                //await client.GetAsync(API_PATH + "/" + GUID + rp.ToString());
            if (response.StatusCode == HttpStatusCode.OK)
            {
                s.Stop();
                Console.WriteLine("Inside GetLoanAsync Completed method & Time elapsed is " + s.Elapsed.ToString());
                var l = new Loan(Session); 
                await l.PopulateLoan(await response.Content.ReadAsStringAsync(), Session);
                return l;
                //tcs.TrySetResult(l);
            }
            else if (response.StatusCode == HttpStatusCode.NotFound)
            {
                throw new FileNotFoundException("guid Not found", guid);
                //tcs.TrySetException(new FileNotFoundException("GUID Not Found", GUID));
            }
            else
            {
                throw new RESTException(nameof(GetLoanAsync), response);
                //tcs.TrySetException(new RESTException("GetLoanAsync", response));
            }
            //return tcs.Task;
        }

        public void PostLoanAsync(Loan loan) => PostLoanAsync(loan.JsonValue);

        public async void PostLoanAsync(string loanData)
        {
            var message = new HttpRequestMessage(HttpMethod.Post, _apiPath)
            {
                Content = new StringContent(loanData, Encoding.UTF8, "application/json")
            };
            Stopwatch s = new Stopwatch();
            s.Start();
            var response = await Session.RESTClient.SendAsync(message);
                //await _Session.RESTClient.PostAsync(API_PATH, new StringContent(LoanData, Encoding.UTF8, "application/json"));
            if (response.StatusCode == HttpStatusCode.Created)
            {
                s.Stop();
                Console.WriteLine("Inside Create Loan completed and Time taken is " + s.Elapsed.ToString());
                //var guid = response.Headers.Location.ToString().Split('/').Last();
                //return await GetLoanAsync(guid);
            }
            else
            {
                throw new RESTException(nameof(PostLoanAsync), response);
            }
        }

        public Task<Loan> PatchLoanAsync(Loan loan) => PatchLoanAsync(loan.JsonValue, loan.encompassId);

        public async Task<Loan> PatchLoanAsync(string loanData, string guid)
        {
            var message = new HttpRequestMessage(new HttpMethod("PATCH"), $"{_apiPath}/{guid}")
            {
                Content = new StringContent(loanData, Encoding.UTF8, "application/json")
            };
            var response = await Session.RESTClient.SendAsync(message);
                //await _Session.RESTClient.PatchAsync(API_PATH + "/" + GUID, new StringContent(LoanData, Encoding.UTF8, "application/json"));
            if (response.IsSuccessStatusCode)
            {
                return await GetLoanAsync(guid);
            }
            else if (response.StatusCode == HttpStatusCode.Conflict) //409
            {
                throw new LoanLockedException(nameof(PatchLoanAsync), response);
            }
            else
            {
                throw new RESTException(nameof(PatchLoanAsync), response);
            }
        }

        public async Task<Loan> DeleteLoanAsync(string guid)
        {
            if (guid == "")
                throw new InvalidOperationException("Missing guid");

            var message = new HttpRequestMessage(HttpMethod.Delete, $"{_apiPath}/{guid}");

            var response = await Client.SendAsync(message);
                //await client.DeleteAsync(API_PATH + "/" + GUID);
            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                Loan tloan = null;
                try
                {
                    tloan = await GetLoanAsync(guid);
                }
                catch (FileNotFoundException)
                {
                    
                }
                return tloan;
            }
            else
            {
                throw new RESTException(nameof(DeleteLoanAsync), response);
            }
        }

        public async Task<IEnumerable<string>> GetSupportedEntitiesAsync()
        {
            var message = new HttpRequestMessage(HttpMethod.Get, $"{_apiPath}/supportedEntities");
            var response = await Client.SendAsync(message);
                //await client.GetAsync(API_PATH + "/supportedEntities");
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                var c = content.Replace(((char)65279).ToString(), "");
                var data  = JsonConvert.DeserializeObject<IEnumerable<string>>(c);
                return data;
            }
            else
            {
                throw new RESTException(nameof(GetSupportedEntitiesAsync), response);
            }
        }
    }
}
