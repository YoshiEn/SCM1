using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using SCM1_API.Model.ScreenModel;

namespace SCM1_API.Model.ScreenModel.EmpLocationInfo
{

    [DataContract]
    public class EmpLocationRequest : ScmApiBaseParameter.Request
    {
        [DataMember]
        public string FLOOR_PLACE_DV { get; set; }
        [DataMember]
        public string FLOOR_PLACE_DV_NM { get; set; }
        [DataMember]
        public string USR_CD { get; set; }
        [DataMember]
        public string TEL_NO { get; set; }
        [DataMember]
        public string ADDRESS { get; set; }
    }

    public class EmpLocationResponse : ScmApiBaseParameter.Response
    {
        public IEnumerable<T_EMP_LOCATION> EmpLocation { get; set; }
    }

}