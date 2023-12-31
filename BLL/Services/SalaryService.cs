﻿using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public  class SalaryService
    {
        public static List<SalaryDTO> Get()
        {
            var data = DataAccessFactory.SalaryData().Read();
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Salary , SalaryDTO>();

            });
            var mapper = new Mapper (cfg);
            var mapped = mapper.Map<List<SalaryDTO>>(data);
            return mapped;

        }

        public static SalaryDTO Get(int id) 
        {
            var data = DataAccessFactory.SalaryData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Salary, SalaryDTO>();
            });

            var mapper = new Mapper (cfg);
            var mapped = mapper.Map<SalaryDTO>(data);
            return mapped;
        }


        public static bool Create(SalaryDTO salary)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<SalaryDTO , Salary>();
            });

            var mapper = new Mapper (config);
            var mapped = mapper.Map<Salary>(salary);
            var res = DataAccessFactory.SalaryData().Create(mapped);
            if (res) return true;
            return false;
        }

        public static bool Update(SalaryDTO salary)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<SalaryDTO, Salary>();
            });
            var mapper = new Mapper (config);
            var mapped = mapper.Map<Salary>(salary);
            var res = DataAccessFactory.SalaryData().Update(mapped);
            if (res) return true;
            return false;

        }


        public static bool Delete(int id)
        {
            return DataAccessFactory.SalaryData().Delete(id);
        }
    }
}
