using System;

namespace WandeKevin
{
    public class ResponseModel
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public ResponseModel(string Code, String Message)
        {
            this.Code = Code;
            this.Message = Message;
        }

        public override string ToString()
        {
            return "ResponseCode : " + Code + "\n ResponseMessage : " + Message;
        }
    }
}
