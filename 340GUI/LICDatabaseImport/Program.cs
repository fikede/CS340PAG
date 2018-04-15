/*
 * Author: Morgan Johnson
 * Program Purpose: This program is specifically designed for the "one-time" use of data import to the LIC DB
 * Current Status:  Encounter Issue with pushing Payments to SQL Policy Numbers dont exist. Seeking Guidance.
 */
using System;
using System.IO;

namespace LICDatabaseImport
{
    class Program
    {
        public static void Main()
        {

            // create classes for each of the file types.
            LifePolicy policy = new LifePolicy();
            Beneficiary beneficiary = new Beneficiary();
            PaymentHistory payments = new PaymentHistory();
            User users = new User();
            //            baseClass[] baseClasses = new baseClass[6];
            //            string[] filePaths = new string[10];

            //            int i = 0;
            //            string s = "";

            //            baseClasses[i].parseInfo(s);

            /*
             * Would like : need: to create a single method for reading each text file
             * line by line.
             */

            /*
             * We needed to create filepath for every text file that we import.
             */

            try
            {
                using (StreamReader stringReader = new StreamReader("User.txt"))
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
                using (StreamReader stringReader = new StreamReader("LifePolicy.txt"))
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
                using (StreamReader stringReader = new StreamReader("Beneficiaries.txt"))
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
                using (StreamReader stringReader = new StreamReader("PaymentHistory0.txt"))
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
                using (StreamReader stringReader = new StreamReader("PaymentHistory1.txt"))
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
                using (StreamReader stringReader = new StreamReader("PaymentHistory2.txt"))
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
                using (StreamReader stringReader = new StreamReader("PaymentHistory3.txt"))
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
                using (StreamReader stringReader = new StreamReader("PaymentHistory4.txt"))
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
                using (StreamReader stringReader = new StreamReader("PaymentHistory5.txt"))
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
                using (StreamReader stringReader = new StreamReader("PaymentHistory6.txt"))
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
        }
    }
}