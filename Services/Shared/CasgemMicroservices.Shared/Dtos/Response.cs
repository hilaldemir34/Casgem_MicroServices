﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservices.Shared.Dtos
{
    public class Response<T>
    {
        public T Data { get; set; }
        public int StatusCode { get; set; }
        public bool IsSuccessfull { get; set; }
        public List<string> Errors{ get; set; }
        public static Response<T> Success(T data,int StatusCode)
        {
            return new Response<T> { Data = data, StatusCode = StatusCode, IsSuccessfull = true };   
        }
        public static Response<T> Success(int StatusCode)
        {
            return new Response<T>
            {
                Data = default(T),
                StatusCode = StatusCode,
                IsSuccessfull = true
            };
        }
        public static Response<T> Fail(List<string>errors,int statusCode)
        {
            return new Response<T>
            {
                Errors = errors,
                StatusCode = statusCode,
                IsSuccessfull = false
            };
        }
        public static  Response<T> Fail(string error,int statusCode)
        {
            return new Response<T>
            {
                Errors = new List<string>() { error },
                IsSuccessfull = false,
                StatusCode = statusCode

            };
        }

    }
}
