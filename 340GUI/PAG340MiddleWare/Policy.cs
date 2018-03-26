using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAG340MiddleWare
{
    class Policy : Savable
    {
        private string policyNumber;
        private PolicyHolder holder;
        private double fathersAgeAtDeath;
        private double motherAgeAtDeath;
        private double cigsPerDay;
        private double smokingHis;
        private double systolicBldPressure;
        private double gramsFatPerDay;
        private bool heartDisease;
        private bool cancer;
        private string dangerousActivities;
        private DateTime startDate;
        private DateTime endDate;
        private Agent representativeAgent;
        private double payOffAmount;
        private double premium;
        private Beneficiary beneficiary;

        public Policy()
        {
            policyNumber = "";
            holder = new PolicyHolder();
            fathersAgeAtDeath = 0.0;
            motherAgeAtDeath = 0.0;
            cigsPerDay = 0.0;
            smokingHis = 0.0;
            systolicBldPressure = 0.0;
            gramsFatPerDay = 0.0;
            heartDisease = false;
            cancer = false;
            dangerousActivities = "";
            startDate = new DateTime();
            endDate = new DateTime();
            representativeAgent = new Agent();
            payOffAmount = 0.0;
            premium = 0.0;
            beneficiary = new Beneficiary();
        }

        public Policy(string inPolicyNumber, PolicyHolder inHolder, double inFathersAgeAtDeath, double inMothersAgeAtDeath, double inCigsPerDay, double inSmokingHis, double inSystolicBldPressure,
                    double inGramsFatPerDay, bool inHeartDisease, bool inCancer, string inDangerousActivities, DateTime inStartDate, DateTime inEndDate,
                    Agent inRepresentativeAgent, double inPayOffAmount, double inPremium, Beneficiary inBeneficiary)
        {
            policyNumber = inPolicyNumber;
            holder = inHolder;
            fathersAgeAtDeath = inFathersAgeAtDeath;
            motherAgeAtDeath = inMothersAgeAtDeath;
            cigsPerDay = inCigsPerDay;
            smokingHis = inSmokingHis;
            systolicBldPressure = inSystolicBldPressure;
            gramsFatPerDay = inGramsFatPerDay;
            heartDisease = inHeartDisease;
            cancer = inCancer;
            dangerousActivities = inDangerousActivities;
            startDate = inStartDate;
            endDate = inEndDate;
            representativeAgent = inRepresentativeAgent;
            payOffAmount = inPayOffAmount;
            premium = inPremium;
            beneficiary = inBeneficiary;
        }

        public override void saveToDataBase()
        {

        }

        public double PricePolicy()
        {
            double price = 0.0;

            return price;
        }

        public void AddPolicyInfo(string phFirstName, string phLastName, string street, string city, string state, string zIP, string benefFirstName, string benefLastName)
        {
            holder.AddPolicyInfo(phFirstName, phLastName, street, city, state, zIP);
            beneficiary.AddPolicyInfo(benefFirstName, benefLastName);
        }

        public double CalculateProfitMade()
        {
            double profit = 0.0;

            return profit;
        }

        public void CancelPolicy()
        {

        }

        public List<Payment> GetPaymentHistory()
        {
            List<Payment> paymentHistory = new List<Payment>();

            return paymentHistory;
        }

        private double getAge()
        {
            double age = 0.0;

            return age;
        }

        public string PolicyNumber
        {
            get { return policyNumber; }
            set { policyNumber = value; }
        }

        public PolicyHolder Holder
        {
            get { return holder; }
            set { holder = value; }
        }

        public double FathersAgeAtDeath
        {
            get { return fathersAgeAtDeath; }
            set { fathersAgeAtDeath = value; }
        }

        public double MothersAgeAtDeath
        {
            get { return motherAgeAtDeath; }
            set { motherAgeAtDeath = value; }
        }

        public double CigsPerDay
        {
            get { return cigsPerDay; }
            set { cigsPerDay = value; }
        }

        public double SmokingHis
        {
            get { return smokingHis; }
            set { smokingHis = value; }
        }

        public double SystolicBldPressure
        {
            get { return systolicBldPressure; }
            set { systolicBldPressure = value; }
        }

        public double GramsFatPerDay
        {
            get { return gramsFatPerDay; }
            set { gramsFatPerDay = value; }
        }

        public bool HeartDisease
        {
            get { return heartDisease; }
            set { heartDisease = value; }
        }

        public bool Cancer
        {
            get { return cancer; }
            set { cancer = value; }
        }

        public string DangerousActivities
        {
            get { return dangerousActivities; }
            set { dangerousActivities = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public Agent RepresentativeAgent
        {
            get { return representativeAgent; }
            set { representativeAgent = value; }
        }

        public double PayOffAmount
        {
            get { return payOffAmount; }
            set { payOffAmount = value; }
        }

        public double Premium
        {
            get { return premium; }
            set { premium = value; }
        }

        public Beneficiary Beneficiary
        {
            get { return beneficiary; }
            set { beneficiary = value; }
        }
    }
}
