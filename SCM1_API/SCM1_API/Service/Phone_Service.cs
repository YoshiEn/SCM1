﻿using SCM1_API.Model;
using SCM1_API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCM1_API.Service
{
    public class Phone_Service
    {
        /// <summary>
        /// 内線情報を取得する
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MST_EXTENSION_LINE> FetchPhoneInfo_Service(string postedAreaDv = "0")
        {
            //                ↓はxml内に記述されたSQLの「#」で括られた部分
            var param = new { FLOOR_PLACE_DV = postedAreaDv };
            return MST_EXTENSION_LINE_Repository.FetchPhoneInfo_Repository(param);
        }
    }
}