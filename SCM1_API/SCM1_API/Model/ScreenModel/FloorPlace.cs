using SCM1_API.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SCM1_API.Model.ScreenModel.FloorPlace
{
    [DataContract]
    public class FloorPlaceRequest : ScmApiBaseParameter.Request
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

    public class FloorPlaceResponse : ScmApiBaseParameter.Response
    {
        public IEnumerable<MST_FLOOR_PLACE_DV> FloorPlaces { get; set; }
    }
}