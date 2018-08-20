using SCM1_API.Model;
using SCM1_API.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCM1_API.Repository
{
    public class MST_FLOOR_PLACE_DV_Repository
    {
        private const string SQL_FILE_NM = "MST_FLOOR_PLACE_DV";


        /// <summary>
        /// 事業所区分/区分名全件取得
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<MST_FLOOR_PLACE_DV> FetchAllFloorPlace_Repository()
        {
            return DataAccess.DataAccess.SELECT_Model<MST_FLOOR_PLACE_DV>(SQL_FILE_NM, "FetchAllFloorPlace");
        }

        /// <summary>
        /// 事業所情報を登録する
        /// </summary>
        /// <param name="sqlId"></param>
        /// <param name="dbModel"></param>
        /// <returns></returns>
        public static int RegistertFloorPlace(dynamic dbModel)
        {
            return DataAccess.DataAccess.ExecuteSQL(SQL_FILE_NM, "InsertFloorPlace", dbModel, Model.constants.DBAccessType.Insert);
        }

        /// <summary>
        /// 事業所情報を編集する
        /// </summary>
        /// <param name="sqlId"></param>
        /// <param name="dbModel"></param>
        /// <returns></returns>
        public static int ModifyFloorPlace(dynamic dbModel)
        {
            return DataAccess.DataAccess.ExecuteSQL(SQL_FILE_NM, "ModifyFloorPlace", dbModel, Model.constants.DBAccessType.Insert);
        }
    }
}