﻿using SCM1_API.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SCM1_API.Model.ScreenModel.seat;
using SCM1_API.Model.constants;

namespace SCM1_API.PresentationService
{
    public class SEAT_PresentationService
    {
        private SEAT_Service seat_Service;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SEAT_PresentationService()
        {
            seat_Service = new SEAT_Service();
        }

        /// <summary>
        /// 座席情報を取得する
        /// </summary>
        /// <returns></returns>
        public SeatResponse FetchSeatInfo(SeatRequest req)
        {
            var returnModel = new SeatResponse();

            //座席情報の取得
            returnModel.SeatInfo = seat_Service.FetchSeatInfo_Service(req.ClientAreaDv);

            //処理ステータスと取得結果を返す
            returnModel.ProcessStatus = returnModel.SeatInfo.Count() != 0 ? STATUS.OK : STATUS.NG;
            //NGの場合はメッセージを設定
            if (returnModel.ProcessStatus == STATUS.NG) returnModel.ResponseMessage = MESSAGE.MSG_FETCH_SEAT_NG;
            return returnModel;
        }

        /// <summary>
        /// 座席情報と登録済み社員情報を取得する
        /// </summary>
        /// <returns></returns>
        public SeatWithEmpResponse FetchSeatWithEmpInfo(SeatRequest req)
        {
            var returnModel = new SeatWithEmpResponse();

            //座席情報の取得
            returnModel.SeatWithEmpInfo = seat_Service.FetchSeatWithEmpInfo_Service(req.ClientAreaDv);

            //処理ステータスと取得結果を返す
            returnModel.ProcessStatus = returnModel.SeatWithEmpInfo.Count() != 0 ? STATUS.OK : STATUS.NG;
            //NGの場合はメッセージを設定
            if (returnModel.ProcessStatus == STATUS.NG) returnModel.ResponseMessage = MESSAGE.MSG_FETCH_SEAT_NG;
            return returnModel;
        }

        /// <summary>
        /// 座席情報と常駐先情報と登録済み社員情報を取得する
        /// </summary>
        /// <returns></returns>
        public ClientAreaSeatResponse FetchClienntAreaSeat(SeatRequest req)
        {
            var returnModel = new ClientAreaSeatResponse();

            //座席情報の取得
            returnModel.ClientAreaSeat = seat_Service.FetchClientAreaSeat_Service(req.ClientAreaDv);

            //処理ステータスと取得結果を返す
            returnModel.ProcessStatus = returnModel.ClientAreaSeat.Count() != 0 ? STATUS.OK : STATUS.NG;
            //NGの場合はメッセージを設定
            if (returnModel.ProcessStatus == STATUS.NG) returnModel.ResponseMessage = MESSAGE.MSG_FETCH_SEAT_NG;
            return returnModel;
        }
    }
}