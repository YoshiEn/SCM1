using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCM1_API.Model
{
    public class MST_FLOOR_PLACE_DV : footerColumns
    {
        /// <summary>
        /// 事業所区分
        /// </summary>
        public string FLOOR_PLACE_DV
        {
            get; set;
        }

        /// <summary>
        /// 事業所区分名
        /// </summary>
        public string FLOOR_PLACE_DV_NM
        {
            get; set;
        }

        /// <summary>
        /// ユーザーコード
        /// </summary>
        public string USR_CD
        {
            get; set;
        }

        /// <summary>
        /// 電話番号
        /// </summary>
        public string TEL_NO
        {
            get; set;
        }

        /// <summary>
        /// 住所
        /// </summary>
        public string ADDRESS
        {
            get; set;
        }
    }
}