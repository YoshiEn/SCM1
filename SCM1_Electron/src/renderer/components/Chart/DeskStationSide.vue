<template>
  <div>
    <div class="row01 floatL child">
      <div class="desk_square">
        <div class="naisen naisen_onsquare">2001</div>
      </div>
      <div class="floatL">
        <div class="desk_rec01">
          <div class="naisen_l">
            <div class="naisen naisen_oneigyo">2123</div>
            <div class="naisen naisen_oneigyo">2021</div>
            <div class="naisen naisen_oneigyo">2124</div>
            <div class="naisen naisen_oneigyo">2032</div>
            <div class="naisen naisen_oneigyo">2125</div>
            <div class="naisen naisen_oneigyo">2033</div>
            <div class="naisen naisen_oneigyo">2131</div>
            <div class="naisen naisen_oneigyo">2034</div>
            <div class="naisen naisen_oneigyo">2132</div>
            <div class="naisen naisen_oneigyo">2035</div>
            <div class="naisen naisen_oneigyolast">2133</div>
          </div>
        </div>
      </div>
    </div>
    <div class="rack01 floatL"></div>
    <div class="row02 floatL child">
      <div class="desk_square">
        <div class="naisen naisen_onsquare">2022</div>
      </div>
      <div class="desk_rec02">
          <div class="naisen naisen_l2">2002</div>
      </div>
      <div class="rack02 floatL"></div>
    </div>
    <div class="row02 floatL child">
      <div class="desk_square">
        <div class="naisen naisen_onsquare">2015</div>
      </div>
      <div class="desk_rec02">
        <div class="naisen_l">
          <div class="naisen naisen_l3">2003</div>
          <div class="naisen naisen_l3">2004</div>
          <div class="naisen naisen_l3 naisen_hashi">2011</div>
          <div class="naisen naisen_l3 naisen_taka">2031</div>
        </div>
      </div>
      <div class="rack02 floatL"></div>
    </div>
    <div class="row02 floatL child">
      <div class="desk_square">
        <div class="naisen naisen_onsquare">2014</div>
      </div>
      <div class="desk_rec02">
        <div class="naisen_l">
          <div class="naisen naisen_l4">2005</div>
          <div class="naisen naisen_l4">2023</div>
        </div>
      </div>
      <div class="rack02 floatL"></div>
    </div>
    <div class="row02 floatL child">
      <div class="desk_square">
        <div class="naisen naisen_onsquare">2013</div>
      </div>
      <div class="desk_rec0506">
        <div class="naisen_l">
          <div class="naisen naisen_l56">2024</div>
        </div>
      </div>
      <div class="rack02 floatL"></div>
    </div>
    <div class="row01 floatL child">
      <div class="desk_square">
        <div class="naisen naisen_onsquare">2012</div>
      </div>
        <div class="desk_rec0506">
          <div class="naisen_l">
            <div class="naisen naisen_l56">2025</div>
            <div class="naisen naisen_l56">2041</div>
          </div>
        </div>
      <div class="rack02 floatL"></div>
    </div>
    <div class="row07 floatL child">
      <div class="desk_rec07">
        <div class="naisen_l">
            <div class="naisen naisen_l7">2122</div>
        </div>
      </div>
      <div class="rack02 floatL">
      </div>
    </div>
    <!--正方形机1列目-->
    <div class="desk_recleft floatL child">
      <div class="desk_square02"></div>
      <div class="desk_square02">
        <div class="naisen naisen_onfree">2060</div>
      </div>
      <div class="desk_square02"></div>
      <div class="desk_square02">
        <div class="naisen naisen_onfree">2063</div>
      </div>
    </div>
    <!--正方形机2列目-->
    <div class="desk_recleft floatL child">
      <div class="desk_square02"></div>
      <div class="desk_square02"></div>
      <div class="desk_square02"></div>
      <div class="desk_square02"></div>
    </div>
    <!--正方形机3列目-->
    <div class="desk_recright floatL child">
      <div class="desk_square02">
        <div class="naisen naisen_onfree">2061</div>
      </div>
      <div class="desk_square02"></div>
      <div class="desk_square02">
        <div class="naisen naisen_onfree">2064</div>
      </div>
    </div>
    <!--正方形机4列目-->
    <div class="desk_recright floatL child">
      <div class="desk_square02"></div>
      <div class="desk_square02"></div>
      <div class="desk_square02">
        <div class="naisen naisen_onfree">2065</div>
      </div>
    </div>
    <!--正方形机5列目-->
    <div class="desk_recright floatL child">
      <div class="desk_square02">
        <div class="naisen naisen_onfree">2062</div>
      </div>
      <div class="desk_square02"></div>
      <div class="desk_square02"></div>
    </div>
  </div>
</template>

<script>
export default {

}
</script>

<style scoped>
  .floatL {
    float: left;
  }
  /*ラック*/
  .rack01 {
      margin: 130px 10px 0 5px;
      width: 15px;
      height: 515px;
      background-color: #E1BE7E;
  }
  .rack02 {
      width: 65px;
      height: 20px;
      margin: 5px 19px 0;
      background-color: #E1BE7E;
  }

  /*列＿1行目*/
  .row01 {
      margin: 50px 8px 0 0;
  }
  .desk_square {
      margin: 0 30px 0 30px;
      width: 45px;
      height: 50px;
    background-color: #91cdf7;
  }
  .desk_rec01 {
      margin: 30px 30px 0 30px;
      width: 45px;
      height: 450px;
      background-color: #91cdf7;
  }
  /*列＿２行目以降*/
  .row02 {
      margin: 50px 0 0;
  }
  .desk_rec02 {
      margin: 30px 30px 0;
      width: 45px;
      height: 515px;
    background-color: #91cdf7;
  }

  /*列＿5,6行目*/
  .desk_rec0506 {
    margin: 95px 30px 0;
    width: 45px;
    height: 450px;
    background-color: #91cdf7;
  }

  /*列＿7行目*/
  .desk_rec07 {
    margin: 130px 30px 0 30px;
    width: 45px;
    height: 515px;
    background-color: #91cdf7;
  }
  /*列＿8.9行目*/
  .desk_recleft {
    margin: 130px 0 0 ;
  }
  /*列＿10.11.12行目*/
  .desk_recright {
    margin: 260px 0 0 ;
  }

  /*フリースペース_正方形*/
  .desk_square02 {
      position: relative;
      left: 25px;
    margin: 0 28px 70px;
    width: 60px;
    height: 60px;
    background-color: #91cdf7;
  }

  /* 内線関係 */
  .naisen{
      width: 45px;
      height: 20px;
      background-color: #f7ffa3;
      color: #495f92;
      font-family: 'Century Gothic';
      font-size: 16px;
      font-weight: bold;
      text-align: center;
      border: 2px solid #495f92;
      border-radius: 5px;
  }
  .naisen_onsquare{
      position: absolute;
      margin-left: -2px;
      margin-top: 13px;
  }
  .naisen_l{
      position: absolute;
  }
  .naisen_oneigyo{
      margin-left: -2px;
      margin-bottom: 9px;
  }
  .naisen_oneigyolast{
      margin-left: -2px;
      margin-top: 38px;
  }
  .naisen_l2{
      position: absolute;
      margin-left: -2px;
      margin-top: 35px;
  }
  .naisen_l3{
      margin-left: -2px;
      margin-top: 35px;
      margin-bottom: 205px;
  }
  .naisen_l4{
      margin-left: -2px;
      margin-top: 35px;
      margin-bottom: 205px;
  }
  .naisen_l56{
      margin-left: -2px;
      margin-top: 35px;
      margin-bottom: 205px;
  }
  .naisen_l7{
      margin-left: -2px;
      margin-top: 458px;
  }
  .naisen_onfree{
      position: absolute;
      margin-left: 6px;
      margin-top: 19px;
  }
  .naisen_hashi{
    margin-left: -2px;
    margin-top: -35px;
    margin-bottom: 0px;
  }
  .naisen_taka{
    margin-left: -2px;
    margin-bottom: 0px;
    margin-top: 5px;
  }
</style>
