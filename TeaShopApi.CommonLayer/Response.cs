using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopApi.CommonLayer.Enums;

namespace TeaShopApi.CommonLayer
{
    public class Response<T>
    {
        public T Data { get; set; }
        public bool IsSuccess { get; set; }
        public ErrorDto ErrorDto { get; set; }
        public ResponseType ResponseType { get; set; }

        public static Response<T> Success(T data, ResponseType responseType)
        {
            return new Response<T> { Data = data, ResponseType = responseType, IsSuccess = true };
        }

        public static Response<T> Success(ResponseType responseType)
        {
            return new Response<T> { ResponseType = responseType, IsSuccess = true };
        }

        public static Response<T> Fail(ErrorDto errorDto,ResponseType responseType)
        {
            return new Response<T> { ErrorDto = errorDto, ResponseType = responseType };
        }

        public static Response<T> Fail(string error,ResponseType responseType)
        {
            var errorDto = new ErrorDto(error, true);
            return new Response<T> { ErrorDto=errorDto, ResponseType = responseType };
        }
    }
}
