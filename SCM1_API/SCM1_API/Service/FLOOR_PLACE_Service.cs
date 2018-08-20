using SCM1_API.Model;
using SCM1_API.Model.DataModel;
using SCM1_API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCM1_API.Service
{
    public class FLOOR_PLACE_Service
    {
        /// <summary>
        /// 事業所区分/区分名を全件取得する
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MST_FLOOR_PLACE_DV> FetchAllFloorPlace_Service()
        {
            return MST_FLOOR_PLACE_DV_Repository.FetchAllFloorPlace_Repository();
        }

        /// <summary>
        /// 事業所情報を登録する
        /// </summary>
        /// <param name="empId"></param>
        /// <param name="clientAreaDv"></param>
        public bool RegisterFloorPlace(int empId, string clientAreaDv, string clientAreaDvName, string userCd, string phoneNo, string address)
        {
            var param = new { EMP_NO = empId, FLOOR_PLACE_DV = clientAreaDv, FLOOR_PLACE_DV_NM = clientAreaDvName, USR_CD = userCd, TEL_NO = phoneNo, ADDRESS = address };
            return MST_FLOOR_PLACE_DV_Repository.RegistertFloorPlace(param) > 0 ? true : false;
        }

        /// <summary>
        /// 事業所情報を編集する
        /// </summary>
        /// <param name="empId"></param>
        /// <param name="clientAreaDv"></param>
        public bool ModifyFloorPlace(int empId, string clientAreaDv, string clientAreaDvName, string userCd, string phoneNo, string address)
        {
            var param = new { EMP_NO = empId, FLOOR_PLACE_DV = clientAreaDv, FLOOR_PLACE_DV_NM = clientAreaDvName, USR_CD = userCd, TEL_NO = phoneNo, ADDRESS = address };
            return MST_FLOOR_PLACE_DV_Repository.RegistertFloorPlace(param) > 0 ? true : false;
        }
    }
}