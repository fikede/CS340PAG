using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using PAG340MiddleWare.Properties;

namespace PAG340MiddleWare
{
    public class Policy : Savable
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
        private bool hospitalized;
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
            hospitalized = false;
            dangerousActivities = "";
            startDate = new DateTime();
            endDate = new DateTime();
            representativeAgent = new Agent();
            payOffAmount = 0.0;
            premium = 0.0;
            beneficiary = new Beneficiary();
        }

        public Policy(string inPolicyNumber, PolicyHolder inHolder, double inFathersAgeAtDeath, double inMothersAgeAtDeath, double inCigsPerDay, double inSmokingHis, double inSystolicBldPressure,
                    double inGramsFatPerDay, bool inHeartDisease, bool inCancer, bool inHospitalized, string inDangerousActivities, DateTime inStartDate, DateTime inEndDate,
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
            hospitalized = inHospitalized;
            dangerousActivities = inDangerousActivities;
            startDate = inStartDate;
            endDate = inEndDate;
            representativeAgent = inRepresentativeAgent;
            payOffAmount = inPayOffAmount;
            premium = inPremium;
            beneficiary = inBeneficiary;
        }

        //This constructor takes in all the indicative date that will be used for the pricing of a new policy. 
        public Policy(DateTime DOB, double inFathersAgeAtDeath, double inMothersAgeAtDeath, double inCigsPerDay, double inSmokingHis, double inSystolicBldPressure,
                    double inGramsFatPerDay, bool inHeartDisease, bool inCancer, bool inHospitalized, string inDangerousActivities)
        {
            policyNumber = "";
            holder = new PolicyHolder();
            holder.BirthDate = DOB;
            fathersAgeAtDeath = inFathersAgeAtDeath;
            motherAgeAtDeath = inMothersAgeAtDeath;
            cigsPerDay = inCigsPerDay;
            smokingHis = inSmokingHis;
            systolicBldPressure = inSystolicBldPressure;
            gramsFatPerDay = inGramsFatPerDay;
            heartDisease = inHeartDisease;
            cancer = inCancer;
            hospitalized = inHospitalized;
            dangerousActivities = inDangerousActivities;
            startDate = new DateTime();
            endDate = new DateTime();
            representativeAgent = new Agent();
            payOffAmount = 0.0;
            premium = 0.0;
            beneficiary = new Beneficiary();
        }

        public override void saveToDataBase()
        {
            holder.saveToDataBase();
            String connectionString = PAG340MiddleWare.Properties.Settings.Default.SqlConnection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "addPolicyHolder";
            SqlCommand cmd = new SqlCommand(query);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@policyNumber", policyNumber);
            cmd.Parameters.AddWithValue("@holderID", holder.ID);
            cmd.Parameters.AddWithValue("@empID", representativeAgent.ID);
            cmd.Parameters.AddWithValue("@holderDOB", holder.BirthDate);
            if (fathersAgeAtDeath > 0) cmd.Parameters.AddWithValue("@fatherDeath", fathersAgeAtDeath);
            if (fathersAgeAtDeath > 0) cmd.Parameters.AddWithValue("@motherDeath", fathersAgeAtDeath);
            cmd.Parameters.AddWithValue("@cigsPerDay", cigsPerDay);
            cmd.Parameters.AddWithValue("@smokeHistory", smokingHis);
            cmd.Parameters.AddWithValue("@sysBP", systolicBldPressure);
            cmd.Parameters.AddWithValue("@aGramsFat", gramsFatPerDay);
            int booleanValue = (heartDisease) ? 1 : 0;
            cmd.Parameters.AddWithValue("@heartDisease", booleanValue);
            booleanValue = (cancer) ? 1 : 0;
            cmd.Parameters.AddWithValue("@cancer", booleanValue);
            booleanValue = (hospitalized) ? 1 : 0;
            cmd.Parameters.AddWithValue("@hospitalized", booleanValue);
            cmd.Parameters.AddWithValue("@dangerousActivities", dangerousActivities);
            cmd.Parameters.AddWithValue("@startDate", startDate);
            if(endDate.ToString() != "00010101") cmd.Parameters.AddWithValue("@endDate", endDate);
            cmd.Parameters.AddWithValue("@payoffAmount", payOffAmount);
            cmd.Parameters.AddWithValue("@monthlyPremium", premium);
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            beneficiary.saveToDataBase();
        }

        public double PricePolicy()
        {
            double price = 0.0;
            List<Matrix> designandyHat = getDesignandYhat();
            Matrix designMatrix = designandyHat.ElementAt(0);
            Matrix yHat = designandyHat.ElementAt(1);
            Matrix betaHat = getBetaHat(designMatrix, yHat);
            double predictedAgeAtDeath = predictAgeAtDeath(betaHat);
            double billableMonths = (predictedAgeAtDeath - getAge()) * 12;
            double grossRevenueGoal = getRevenueGoal(billableMonths/12);
            price = grossRevenueGoal / billableMonths;

            return price;
        }

        private double getRevenueGoal(double billableMonths)
        {
            double adjustedAmount = payOffAmount * 1.10; // Multiply by the profit goal which is 10 percent;
            double averageInflation = getAverageInflation();
            adjustedAmount *= Math.Pow(averageInflation + 1, billableMonths);
            return adjustedAmount;
        }

        private double getAverageInflation()
        {
            DateTime today = DateTime.Today;
            string year = "" + (today.Year - 1);
            int month = 12;
            int months = 5;
            double sum = 0;
            for(int i = 0; i < months; i++ )
            {
                double first = getInflationAmountat(month - i, year);
                double second = getInflationAmountat(month - i - 1, year);
                double diff = second - first;
                diff /= second;
                sum += diff;
            }
            double averageInflation = sum / months;
            return averageInflation;
        }

        private double getInflationAmountat(int month, string year)
        {
            String connectionString = PAG340MiddleWare.Properties.Settings.Default.SqlConnection;
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "getDollarValue";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@inputMonth", month);
            cmd.Parameters.AddWithValue("@inputYear", year);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            double inflation = Convert.ToDouble(reader.GetDecimal(0));
            conn.Close();

            return inflation;
        }

        private double predictAgeAtDeath(Matrix betaHat)
        {
            int rowNumber = 0;
            double predictedAgeAtDeath = 1 * betaHat.getNumberAt(rowNumber++, 0);
            predictedAgeAtDeath += fathersAgeAtDeath * betaHat.getNumberAt(rowNumber++, 0);
            predictedAgeAtDeath += motherAgeAtDeath * betaHat.getNumberAt(rowNumber++, 0);
            predictedAgeAtDeath += cigsPerDay * betaHat.getNumberAt(rowNumber++, 0);
            predictedAgeAtDeath += smokingHis * betaHat.getNumberAt(rowNumber++, 0);
            predictedAgeAtDeath += systolicBldPressure * betaHat.getNumberAt(rowNumber++, 0);
            predictedAgeAtDeath += gramsFatPerDay * betaHat.getNumberAt(rowNumber, 0);
            return predictedAgeAtDeath;
        }

        private Matrix getBetaHat(Matrix designMatrix, Matrix yHat)
        {
            Matrix designTransposed = designMatrix.transpose();
            Matrix DtD = designTransposed * designMatrix;
            Matrix DtyHat = designTransposed * yHat;
            Matrix DtDinverse = DtD.inverse();
            Matrix betaHat = DtDinverse * DtyHat;
            return betaHat;
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
            endDate = DateTime.Today;
            string connectionString = Settings.Default.SqlConnection;
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "endPolicy";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@policyNumber", policyNumber);
            cmd.Parameters.AddWithValue("@cancelDate", endDate);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<Payment> GetPaymentHistory()
        {
            List<Payment> paymentHistory = new List<Payment>();
            String connectionString = Settings.Default.SqlConnection;
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "getPayments";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@policyNumber", policyNumber);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Payment payment = new Payment();
                payment.getValuesWithReader(reader);
                paymentHistory.Add(payment);
            }
            conn.Close();
            return paymentHistory;
        }
        
        private List<Matrix> getDesignandYhat()
        {
            List<Matrix> designAndyHat = new List<Matrix>();
            List<Policy> policyList = getClaimedPolicies();
            int numberOfPolicies = policyList.Count;
            Matrix designMatrix = new Matrix(numberOfPolicies, 7);
            Matrix yHat = new Matrix(numberOfPolicies, 1);
            double age;

            int rowNumber = 0;
            foreach (Policy policy in policyList)
            {
                int columnNumber = 0;
                designMatrix.setNumberAt(rowNumber, columnNumber++, 1);
                designMatrix.setNumberAt(rowNumber, columnNumber++, policy.fathersAgeAtDeath);
                designMatrix.setNumberAt(rowNumber, columnNumber++, policy.motherAgeAtDeath);
                designMatrix.setNumberAt(rowNumber, columnNumber++, policy.cigsPerDay);
                designMatrix.setNumberAt(rowNumber, columnNumber++, policy.smokingHis);
                designMatrix.setNumberAt(rowNumber, columnNumber++, policy.systolicBldPressure);
                designMatrix.setNumberAt(rowNumber, columnNumber, policy.gramsFatPerDay);

                age = policy.getAgeAtDeath();
                yHat.setNumberAt(rowNumber, 0, age);
                rowNumber++;
            }

            designAndyHat.Add(designMatrix);
            designAndyHat.Add(yHat);

            return designAndyHat;
        }

        private double getAge()
        {
            DateTime now = DateTime.Today;
            TimeSpan age = now.Subtract(holder.BirthDate);
            return age.TotalDays/365;
        }

        private double getAgeAtDeath()
        {
            TimeSpan age = endDate.Subtract(holder.BirthDate);
            return age.TotalDays/365;
        }

        private List<Policy> getClaimedPolicies()
        {
            List<Policy> policies = new List<Policy>();
            String connectionString = PAG340MiddleWare.Properties.Settings.Default.SqlConnection;
            SqlConnection conn = new SqlConnection(connectionString);
            string query = "getClaimedPolicies";
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Policy policy = new Policy();
                policy.getPolicyInformationWithoutAgentName(reader);
                policies.Add(policy);
            }
            conn.Close();
            return policies;
        }

        private void getPolicyInformationWithoutAgentName(SqlDataReader reader)
        {
            int booleanValue;
            Decimal decimalValue;
            int columnNumber = reader.GetOrdinal("number");
            policyNumber = reader.GetString(columnNumber);

            columnNumber = reader.GetOrdinal("holder_ID");
            holder.ID = reader.GetString(columnNumber);

            columnNumber = reader.GetOrdinal("emp_ID");
            representativeAgent.ID = reader.GetString(columnNumber);

            columnNumber = reader.GetOrdinal("holder_DOB");
            holder.BirthDate = reader.GetDateTime(columnNumber);

            columnNumber = reader.GetOrdinal("fathers_age_at_death");
            if (!reader.IsDBNull(columnNumber))
            {
                decimalValue = reader.GetDecimal(columnNumber);
                fathersAgeAtDeath = Convert.ToDouble(decimalValue);
            }

            columnNumber = reader.GetOrdinal("mothers_age_at_death");
            if (!reader.IsDBNull(columnNumber))
            {
                decimalValue = reader.GetDecimal(columnNumber);
                motherAgeAtDeath = Convert.ToDouble(decimalValue);
            }

            columnNumber = reader.GetOrdinal("cigs_per_day");
            cigsPerDay = reader.GetInt32(columnNumber);

            columnNumber = reader.GetOrdinal("smoking_history");
            decimalValue = reader.GetDecimal(columnNumber);
            smokingHis = Convert.ToDouble(decimalValue);

            columnNumber = reader.GetOrdinal("systolic_blood_pressure");
            systolicBldPressure = reader.GetInt32(columnNumber);

            columnNumber = reader.GetOrdinal("average_grams_fat_per_day");
            gramsFatPerDay = reader.GetInt32(columnNumber);

            columnNumber = reader.GetOrdinal("heart_disease");
            booleanValue = reader.GetInt32(columnNumber);
            heartDisease = Convert.ToBoolean(booleanValue);

            columnNumber = reader.GetOrdinal("cancer");
            booleanValue = reader.GetInt32(columnNumber);
            cancer = Convert.ToBoolean(booleanValue);

            columnNumber = reader.GetOrdinal("hospitalized");
            booleanValue = reader.GetInt32(columnNumber);
            hospitalized = Convert.ToBoolean(booleanValue);

            columnNumber = reader.GetOrdinal("dangerous_activities");
            dangerousActivities = reader.GetString(columnNumber);

            columnNumber = reader.GetOrdinal("start_date");
            startDate = reader.GetDateTime(columnNumber);

            columnNumber = reader.GetOrdinal("end_date");
            if (!reader.IsDBNull(columnNumber)) endDate = reader.GetDateTime(columnNumber);

            columnNumber = reader.GetOrdinal("payoff_amount");
            decimalValue = reader.GetDecimal(columnNumber);
            payOffAmount = Convert.ToDouble(decimalValue);

            columnNumber = reader.GetOrdinal("monthly_premium");
            decimalValue = reader.GetDecimal(columnNumber);
            premium = Convert.ToDouble(decimalValue);

            columnNumber = reader.GetOrdinal("holder_first_name");
            holder.FirstName = reader.GetString(columnNumber);

            columnNumber = reader.GetOrdinal("holder_last_name");
            holder.LastName = reader.GetString(columnNumber);

            columnNumber = reader.GetOrdinal("street");
            holder.Street = reader.GetString(columnNumber);

            columnNumber = reader.GetOrdinal("city");
            holder.City = reader.GetString(columnNumber);

            columnNumber = reader.GetOrdinal("state");
            holder.State = reader.GetString(columnNumber);

            columnNumber = reader.GetOrdinal("zip");
            holder.ZIP = reader.GetString(columnNumber);
        }

        public void getPolicyInfoWithReader(SqlDataReader reader)
        {
            int columnNumber = reader.GetOrdinal("agent_first_name");
            representativeAgent.Firstname = reader.GetString(columnNumber);

            columnNumber = reader.GetOrdinal("agent_last_name");
            representativeAgent.Lastname = reader.GetString(columnNumber);

            getPolicyInformationWithoutAgentName(reader);
        }

        public string getNextId()
        {
            String connectionString = PAG340MiddleWare.Properties.Settings.Default.SqlConnection;
            SqlConnection conn = new SqlConnection(connectionString);
            String query = "EXECUTE returnPolicyNumber";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            String newNumber = "";

            if (reader.Read())
            {
                int columnNum = reader.GetOrdinal("ID");
                newNumber = reader.GetString(columnNum);
                newNumber = addOneToNumber(newNumber);
            }
            conn.Close();
            return newNumber;
        }

        private string addOneToNumber(string newNumber)
        {
            char[] charNewNumber = new char[newNumber.Length];
            bool notAddedOne = true;
            for (int i = newNumber.Length - 1; i >= 0; i--)
            {
                if (newNumber[i] == '9' && notAddedOne)
                {
                    charNewNumber[i] = '0';
                }
                else if(newNumber[i] == ' ' && notAddedOne)
                {
                    charNewNumber[i] = '1';
                }
                else if (notAddedOne)
                {
                    charNewNumber[i] = newNumber[i];
                    charNewNumber[i]++;
                    notAddedOne = false;
                }
                else
                {
                    charNewNumber[i] = newNumber[i];
                }
            }
            String outID = new String(charNewNumber);

            return outID;
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

        public bool Hospitalized
        {
            get { return hospitalized; }
            set { hospitalized = value; }
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
