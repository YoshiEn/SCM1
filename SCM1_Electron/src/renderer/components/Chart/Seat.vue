<template>
    <button type="button" class="seat" @click="onReserve" :disabled="isGuest || isAnotherReservedSeat">{{ displayEmpNm }}</button>
</template>

<script>
import { mapActions, mapState } from 'vuex'
import * as messages from '@/assets/messages'

export default {
  data: function () {
    return {
      empNo: JSON.parse(localStorage.getItem('authInfo')).EmpNo
    }
  },
  computed: {
    ...mapState('auth', {
      token: state => state.token,
      isGuest: state => state.isGuest
    }),
    ...mapState('getMaster', {
      loginEmpName: state => state.loginEmpName
    }),
    ...mapState('reserve', {
      isReserved: state => state.isReserved,
      displayEmpNm (state) {
        if (this.seat.SEAT_NO === state.reservedSeatNo) {
          return this.loginEmpName
        } else if (this.seat.EMP_NO === this.empNo) {
          return ''
        }
        return this.seat.DISPLAY_EMP_NM
      },
      isAnotherReservedSeat (state) {
        return !(this.seat.EMP_NO === this.empNo) && this.seat.DISPLAY_EMP_NM
      }
    })

  },
  props: ['seat'],
  methods: {
    ...mapActions({
      reserve: 'reserve/reserve',
      release: 'reserve/release',
      showError: 'modal/showError',
      showAlert: 'modal/showAlert',
      showAlertReg: 'modal/showAlertReg'
    }),
    onReserve: function (event) {
      // 座席未登録 & 該当座席の名前がない場合
      if (!this.displayEmpNm) {
        this.showAlertReg({
          message: messages.I_003,
          actionName: 'reserve/reserve',
          param: {
            Token: this.token,
            EmpNo: this.empNo,
            seatNo: event.target.id
          }
        })
        // 座席登録済 & 該当座席の名前が自分の場合
      } else if (this.displayEmpNm === this.loginEmpName && this.isReserved) {
        this.showAlert({
          message: messages.I_004,
          actionName: 'reserve/release',
          param: {
            Token: this.token,
            EmpNo: this.empNo
          }
        })
      }
    }
  }
}
</script>

<style scoped>
button:focus{
 outline:none;
}
button:disabled{
    background-color: #ffffff;
    color:#000000;
    cursor: default;
}
.seat {
    width: 24px;
    height: 60px;
    text-align: center;
    vertical-align: middle;
    text-decoration: none;
    padding: 3px 0;
    background-color: #FFFFFF;
    border: 2px solid #B8C8D6;
    border-radius: 10px;
    cursor: pointer;
    font-size: 16px;
    font-family: 'Century Gothic';
	z-index: 1;
    position: absolute;
	float: left;
    line-height: 1.1;
}
.seatY{
    position: absolute;
	width: 60px;
    height: 24px;
    padding: 0 0;
}
.searched{
    animation: changecolor 30s 1;
    -webkit-animation: changecolor 30s 1;
}
@keyframes changecolor {
    1% { background-color: #ff7777; }
    2% { background-color: #ffffff; }
    3% { background-color: #ff7777; }
    4% { background-color: #ffffff; }
    6% { background-color: #ff7777; }
    90% { background-color: #ff7777; }
    100% { background-color: #ffffff; }
}
</style>
