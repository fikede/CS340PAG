﻿/*
 * Author: Morgan Johnson
 * Program Purpose: This program is specifically designed for the "one-time" use of data import to the LIC DB
 * Current Status:  Added all data import files.
 *                  - Need to end policies with claims.
 *                  - Need to import US Dollar Inflation.
 */
using System;
using System.IO;
using System.Collections.Generic;

namespace LICDatabaseImport
{
    class Program
    {
        public static void Main()
        {

            // create classes for each of the file types.
            String filePath = LICDatabaseImport.Properties.Settings.Default.FilePath;
            List<string> policyNumbers = new List<string>();
            LifePolicy policy = new LifePolicy(policyNumbers);
            Beneficiary beneficiary = new Beneficiary();
            User users = new User();
            PaymentHistory payments = new PaymentHistory(policyNumbers);
            /*
            try
            {
                using (StreamReader stringReader = new StreamReader(filePath + "User.txt"))
                {
                    string line;
                    while ((line = stringReader.ReadLine()) != null)
                    {
                        users.parseInfo(line);
                        char c = line[475];
                    }
                }
            }
            catch (Exception e)
            {
                throw new FileNotFoundException("File Not Found", e);
            }
            try
            {
                using (StreamReader stringReader = new StreamReader(filePath + "LifePolicy.txt"))
                {
                    
                    string line;
                    while ((line = stringReader.ReadLine()) != null)
                    {
                        policy.parseInfo(line);
                    }
                }
            }
            catch (Exception e)
            {
                throw new FileNotFoundException("File Not Found", e);
            }


            try
            {
                using (StreamReader stringReader = new StreamReader(filePath + "Beneficiaries.txt"))
                {
                    string line;
                    while ((line = stringReader.ReadLine()) != null)
                    {
                        beneficiary.parseInfo(line);
                    }
                }
            }
            catch (Exception e)
            {
                throw new FileNotFoundException("File Not Found", e);
            }

            try
            {
                using (StreamReader stringReader = new StreamReader(filePath + "PaymentHistory0.txt"))
                {
                    string line;
                    while ((line = stringReader.ReadLine()) != null)
                    {
                        payments.parseInfo(line);
                    }
                }
            }
            catch (Exception e)
            {
                throw new FileNotFoundException("File Not Found", e);
            }
            
            try
            {
                using (StreamReader stringReader = new StreamReader(filePath + "PaymentHistory1.txt"))
                {
                    string line;
                    while ((line = stringReader.ReadLine()) != null)
                    {
                       payments.parseInfo(line);
                    }
                }
            }
            catch (Exception e)
            {
                throw new FileNotFoundException("File Not Found", e);
            }

            try
            {
                using (StreamReader stringReader = new StreamReader(filePath + "PaymentHistory2.txt"))
                {
                    string line;
                    while ((line = stringReader.ReadLine()) != null)
                    {
                        payments.parseInfo(line);
                    }
                }
            }
            catch (Exception e)
            {
                throw new FileNotFoundException("File Not Found", e);
            }

            try
            {
                using (StreamReader stringReader = new StreamReader(filePath + "PaymentHistory3.txt"))
                {
                    string line;
                    while ((line = stringReader.ReadLine()) != null)
                    {
                        payments.parseInfo(line);
                    }
                }
            }
            catch (Exception e)
            {
                throw new FileNotFoundException("File Not Found", e);
            }

            try
            {
                using (StreamReader stringReader = new StreamReader(filePath + "PaymentHistory4.txt"))
                {
                    string line;
                    while ((line = stringReader.ReadLine()) != null)
                    {
                        payments.parseInfo(line);
                    }
                }
            }
            catch (Exception e)
            {
                throw new FileNotFoundException("File Not Found", e);
            }

            try
            {
                using (StreamReader stringReader = new StreamReader(filePath + "PaymentHistory5.txt"))
                {
                    string line;
                    while ((line = stringReader.ReadLine()) != null)
                    {
                        payments.parseInfo(line);
                    }
                }
            }
            catch (Exception e)
            {
                throw new FileNotFoundException("File Not Found", e);
            }

            try
            {
                using (StreamReader stringReader = new StreamReader(filePath + "PaymentHistory6.txt"))
                {
                    string line;
                    while ((line = stringReader.ReadLine()) != null)
                    {
                        payments.parseInfo(line);
                    }
                }
            }
            catch (Exception e)
            {
                throw new FileNotFoundException("File Not Found", e);
            }


            // need to end policies with claims.
            payments.updateClaimedPolicies();
                        
            /*COMPLETED (Proof) run this in the DB
                select * from Policy
                WHERE end_date is not null
                ORDER BY  number
                select * from Payment
                where type = 'c'
                ORDER BY  policy_number
            */

            // need to upload US Dollar Inflation.
        }
    }
}