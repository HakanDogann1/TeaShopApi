﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopApi.CommonLayer
{
    public class ErrorDto
    {
        public List<string> Errors { get; set; }
        public bool IsShow { get; set; }
        public ErrorDto()
        {
            Errors = new List<string>();
        }

        public ErrorDto(string error,bool isShow)
        {
            Errors.Add(error);
            IsShow = isShow;
        }

        public ErrorDto(List<string> errors,bool isShow)
        {
            Errors = errors;
            IsShow = isShow;
        }

    }
}
