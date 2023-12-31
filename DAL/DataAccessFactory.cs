﻿using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class DataAccessFactory
    {
        public static IRepos<Moderator , int ,bool > ModeratorData()
        {
            return new ModeratorRepo();
        }

        public static IRepos<Salary , int ,bool> SalaryData() 
        {
            return new SalaryRepo();
        }

        public static IRepos<AttendanceReport, int, bool> AttendanceReportData()
        {
            return new AttendanceReportRepo();
        }

       public static IAuth<bool> AuthData()
        {
            return new ModeratorRepo();
        }

        public static IRepos<Token, string, Token> TokenData()
        {
            return new TokenRepo();
        }

        public static IChange ChangePassData()
        {
            return new ModeratorRepo();
        }

    }
}
