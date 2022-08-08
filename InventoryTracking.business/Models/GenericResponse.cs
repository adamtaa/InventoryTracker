using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace InventoryTracking.business.Models
{
    [DataContract]
    public class GenericResponse
    {
        public GenericResponse()
        {
            this.Message = string.Empty;
        }

        [DataMember(Name = "errorCode")]
        public int ErrorCode { get; set; }

        [DataMember(Name = "message")]
        public string Message { get; set; }

        [DataMember(Name = "isSuccessful")]
        public bool IsSuccessful { get; set; }


    }

    public class GenericResponse<T> : GenericResponse
    {
        [DataMember(Name = "result")]
        public T Result { get; set; }
    }
}
