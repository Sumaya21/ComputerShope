﻿using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Web.Http;

namespace ComputerShope.Controllers
{
    public class SalaryController : ApiController
    {
        [HttpGet]
        [Route("api/salary")]

        public HttpResponseMessage Salary()
        {
            try
            {
                var data = SalaryService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);


            }
            catch (Exception ex) 
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });

            }
        }

        [HttpGet]
        [Route("api/salary/{id}")]

        public HttpResponseMessage SelesReport(int id)
        {
            try
            {
                var data = SalaryService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/salary/add")]

        public HttpResponseMessage Add(SalaryDTO obj)
        {
            try
            {
                var res = SalaryService.Create(obj);
                if (res)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Message = "Inserted", Data = obj });

                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = "Not Inserted", Data = obj });
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message, });
            }

        }

        [HttpPost]
        [Route("api/salary/Update")]


        public HttpResponseMessage Update(SalaryDTO obj)
        {
            try
            {
                var res = SalaryService.Update(obj);
                if (res)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Message = "Update", Data = obj });

                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = "Not Update", Data = obj });
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError,  new { Message = ex.Message, });
            }

        }

        [HttpPost]
        [Route("api/salary/Delete/{id}")]

        public HttpResponseMessage Delete(int id) 
        {
            try
            {

                return Request.CreateResponse(HttpStatusCode.OK, SalaryService.Delete(id));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }
    }
    
 }

