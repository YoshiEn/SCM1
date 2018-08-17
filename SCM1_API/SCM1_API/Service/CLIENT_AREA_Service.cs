using SCM1_API.Model;
using SCM1_API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SCM1_API.Service
{
    public class CLIENT_AREA_Service
    {

        /// <summary>
        /// 事業所情報を登録する
        /// </summary>
        /// <param name="empId"></param>
        /// <param name="clientAreaDv"></param>
        public bool RegisterEmpLocation_Service(int empId, string clientAreaDv, string clientAreaDvName, string userCd, string phoneNo, string address)
        {
            var param = new { EMP_NO = empId, FLOOR_PLACE_DV = clientAreaDv, FLOOR_PLACE_DV_NM = clientAreaDvName, USR_CD = userCd, TEL_NO = phoneNo, ADDRESS = address  };
            return MST_FLOOR_PLACE_DV_Repository.RegistertClienntArea(param) > 0 ? true : false;
        }
    }
}