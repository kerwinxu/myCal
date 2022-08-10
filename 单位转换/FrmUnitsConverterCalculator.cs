using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using Xuhengxiao.MyDataStructure;

namespace Calculator
{
    public partial class FrmUnitsConverterCalculator : Form
    {
        ///这个单位换算我想用如下方法
        ///比如说长度转换，选择米作为基准，当按换算按钮后，将当前的长度换算成米，然后用一个方法来换算其他的。
        ///norm 为标准
        ///normLengthMeter 基准米，长度的.

        public double normLengthMeter;//基准米.
        public double normAreaSquareMeter;//基准平方米
        public double normWeightKe;//重量基准单位为克.
        public double normPowerWa;//功率基准单位选择瓦特
        public double normTemperatureSheShiDu;//温度基准单位选择摄氏度
        public double normThermalJiaoEr;//做功热量基准单位选择焦耳
        public double normVolumeSheng;//容积体积的基准单位选择升


        //如下是部分数据参数
        double dblMeiZhiGanLiangJiaLunCanShu = 4.40488377086;//美制干量加仑参数，这个是一加仑代表多少升
        double dblYingZhiYeTiHeGanLiangPinTuo = 0.56826125;//英制液体和关良品脱参数
        double dblMeiZhiYeTiJiaLun = 3.785411784;//美制液体加仑参数。换算成升的。

        public FrmUnitsConverterCalculator()
        {
            InitializeComponent();
            //设定角度为弧度
            UserControlUnitInput.strJiaoDuDanWei = "HuDu";
        }

        private void userControlUnitInput1_Load(object sender, EventArgs e)
        {

        }

        private void FrmUnitsConverterCalculator_Load(object sender, EventArgs e)
        {

        }

        public  void LengthConvert()
        {
            //这个方法会根据基准米来计算其他长度.

            //以下为公制
            LengthUnitKilometer.UnitValue = normLengthMeter / 1000;//千米
            LengthUnitMeter.UnitValue = normLengthMeter;//米
            LengthUnitDecimeter.UnitValue = normLengthMeter * 10;//分米
            LengthUnitCentimeter.UnitValue = normLengthMeter * 100;//厘米
            LengthUnitMillimeter.UnitValue = normLengthMeter * 1000;//毫米
            LengthUnitMicron.UnitValue = normLengthMeter * 1000000;//微米
            LengthUnitNanometrer.UnitValue = normLengthMeter * 1000000000;//纳米

            //以下为英制
            LengthUnitMile.UnitValue = normLengthMeter / 1609.344;//英里
            LengthUnitYard.UnitValue = normLengthMeter / 0.9144;//码
            LengthUnitFoot.UnitValue = normLengthMeter / 0.3048;//英尺
            LengthUnitInch.UnitValue=normLengthMeter/(25.4/1000);//英寸
            LengthUnitSeaMile.UnitValue = normLengthMeter / 1852;//海里
            LengthUnitFachom.UnitValue = normLengthMeter / 1.8288;//英寻
            LengthUnitFur.UnitValue = normLengthMeter / 201.168;//弗隆

            //以下为市制
            LengthUnitZhang.UnitValue = normLengthMeter / (10.0 / 3);//丈 3丈 = 10米
            LengthUnitShiChi.UnitValue = normLengthMeter / (1.0 / 3);//市尺 3尺 = 1米
            LengthUnitShiCun.UnitValue = normLengthMeter / (0.1/3);//市寸 3寸 = 10 厘米
            LengthUnitShiFen.UnitValue = normLengthMeter / (0.01/3);//市分

            //以下为台制
            LengthUnitTaiZhang.UnitValue = normLengthMeter /(100.0/33);//台丈
            LengthUnitTaiChi.UnitValue = normLengthMeter / (10.0/33);//台尺
            LengthUnitTaiCun.UnitValue = normLengthMeter / (1.0/33);//台寸
            
        }

        private void LengthUnitKilometer_btnConvertClick(object sender, EventArgs e)
        {
            normLengthMeter = LengthUnitKilometer.UnitValue * 1000;//千米
            LengthConvert();
        }

        private void LengthUnitMeter_btnConvertClick(object sender, EventArgs e)
        {
            normLengthMeter = LengthUnitMeter.UnitValue;//米
            LengthConvert();
        }

        private void LengthUnitDecimeter_btnConvertClick(object sender, EventArgs e)
        {
            normLengthMeter = LengthUnitDecimeter.UnitValue / 10;//分米
            LengthConvert();
        }

        private void LengthUnitCentimeter_btnConvertClick(object sender, EventArgs e)
        {
            normLengthMeter = LengthUnitCentimeter.UnitValue / 100;//厘米
            LengthConvert();
        }

        private void LengthUnitMillimeter_btnConvertClick(object sender, EventArgs e)
        {
            normLengthMeter = LengthUnitMillimeter.UnitValue / 1000;//毫米
            LengthConvert();
        }

        private void LengthUnitMicron_btnConvertClick(object sender, EventArgs e)
        {
            normLengthMeter = LengthUnitMicron.UnitValue / 1000000;//微米
            LengthConvert();
        }

        private void LengthUnitNanometrer_btnConvertClick(object sender, EventArgs e)
        {
            normLengthMeter = LengthUnitNanometrer.UnitValue / 1000000000;//纳米
            LengthConvert();
        }

        private void LengthUnitMile_btnConvertClick(object sender, EventArgs e)
        {
            normLengthMeter = LengthUnitMile.UnitValue * 1609.344;//英里
            LengthConvert();
        }

        private void LengthUnitYard_btnConvertClick(object sender, EventArgs e)
        {
            normLengthMeter = LengthUnitYard.UnitValue * 0.9144;//码
            LengthConvert();
        }

        private void LengthUnitFoot_btnConvertClick(object sender, EventArgs e)
        {
            normLengthMeter = LengthUnitFoot.UnitValue * 0.3048;//英尺
            LengthConvert();
        }

        private void LengthUnitInch_btnConvertClick(object sender, EventArgs e)
        {
            normLengthMeter = LengthUnitInch.UnitValue * 25.4 / 1000;//英寸
            LengthConvert();
        }

        private void LengthUnitSeaMile_btnConvertClick(object sender, EventArgs e)
        {
            normLengthMeter = LengthUnitSeaMile.UnitValue * 1852;//海里
            LengthConvert();
        }

        private void LengthUnitFachom_btnConvertClick(object sender, EventArgs e)
        {
            normLengthMeter = LengthUnitFachom.UnitValue * 1.8288;//英寻
            LengthConvert();
        }

        private void LengthUnitFur_btnConvertClick(object sender, EventArgs e)
        {
            normLengthMeter = LengthUnitFur.UnitValue * 201.168;//弗隆
            LengthConvert();
        }

        private void LengthUnitZhang_btnConvertClick(object sender, EventArgs e)
        {
            normLengthMeter = LengthUnitZhang.UnitValue *(10.0/3);//丈
            LengthConvert();
        }

        private void LengthUnitShiChi_btnConvertClick(object sender, EventArgs e)
        {
            normLengthMeter = LengthUnitShiChi.UnitValue * (1.0/3);//市尺
            LengthConvert();
        }

        private void LengthUnitShiCun_btnConvertClick(object sender, EventArgs e)
        {
            normLengthMeter = LengthUnitShiCun.UnitValue * (0.1/3);//市寸
            LengthConvert();
        }

        private void LengthUnitShiFen_btnConvertClick(object sender, EventArgs e)
        {
            normLengthMeter = LengthUnitShiFen.UnitValue * (0.01/3);//市分
            LengthConvert();
        }

        private void LengthUnitTaiZhang_btnConvertClick(object sender, EventArgs e)
        {
            normLengthMeter = LengthUnitTaiZhang.UnitValue * (100.0/33);//台丈
            LengthConvert();
        }

        private void LengthUnitTaiChi_btnConvertClick(object sender, EventArgs e)
        {
            normLengthMeter = LengthUnitTaiChi.UnitValue * (10.0/33);//台尺
            LengthConvert();
        }

        private void LengthUnitTaiCun_btnConvertClick(object sender, EventArgs e)
        {
            normLengthMeter = LengthUnitTaiCun.UnitValue * (1.0/33);//台寸
            LengthConvert();
        }


        private void chkBritishSystem_CheckedChanged(object sender, EventArgs e)
        {
            LengthUnitMile.BritishSystem = chkBritishSystem.Checked;//英里
            LengthUnitYard.BritishSystem = chkBritishSystem.Checked;//码
            LengthUnitFoot.BritishSystem = chkBritishSystem.Checked;//英尺
            LengthUnitInch.BritishSystem = chkBritishSystem.Checked;//英寸
            LengthUnitSeaMile.BritishSystem = chkBritishSystem.Checked;//海里
            LengthUnitFachom.BritishSystem = chkBritishSystem.Checked;//英寻
            LengthUnitFur.BritishSystem = chkBritishSystem.Checked;//弗隆
            LengthConvert();//刷新一下

        }

        private  void AreaConvert()//面积换算
        {
            //如下是公制
            AreaUnitSquareKilometer.UnitValue = normAreaSquareMeter / 10E+5;//平方公里
            AreaUnitHectare.UnitValue = normAreaSquareMeter / 10E+3;//公顷
            AreaUnitAre.UnitValue = normAreaSquareMeter / 100;//公亩
            AreaUnitSquareMeter.UnitValue = normAreaSquareMeter;//平方米
            AreaUnitSquareDecimeter.UnitValue = normAreaSquareMeter * 100;//平方分米
            AreaUnitSquareCentimeter.UnitValue = normAreaSquareMeter * 10E+3;//平方厘米
            AreaUnitSquareMillimeter.UnitValue = normAreaSquareMeter * 10E+5;//平方毫米

            //如下是英制
            AreaUnitSquareMile.UnitValue = normAreaSquareMeter / 2589988.110336;//平方英里
            AreaUnitSquareFoot.UnitValue = normAreaSquareMeter / 0.09290304;//平方英尺
            AreaUnitSquareYard.UnitValue = normAreaSquareMeter / 0.83612736;//平方码
            AreaUnitSquareInch.UnitValue = normAreaSquareMeter / 0.00064516;//平方英寸
            AreaUnitArce.UnitValue = normAreaSquareMeter / 4046.8564224;//英亩
            AreaUnitSquareRd.UnitValue = normAreaSquareMeter / 25.2928526;//平方竿

            //如下是市制
            AreaUnitQing.UnitValue = normAreaSquareMeter / (20000/3);//顷
            AreaUnitShiMu.UnitValue = normAreaSquareMeter / (2000/3);//市亩=666.66666666
            AreaUnitSquareZhang.UnitValue = normAreaSquareMeter / (2000/180);//平方丈
            AreaUnitFen.UnitValue = normAreaSquareMeter / (200/3);//分
            AreaUnitLi.UnitValue = normAreaSquareMeter / (20/3);//厘

            //如下是台制
            AreaUnitSquareTaiWanJia.UnitValue = normAreaSquareMeter / (2934*400/121);//台湾甲
            AreaUnitSquareTaiWanPing.UnitValue = normAreaSquareMeter / (400/121);//台湾坪
      


        }

        private void AreaUnitSquareKilometer_btnConvertClick(object sender, EventArgs e)
        {
            normAreaSquareMeter = AreaUnitSquareKilometer.UnitValue * 10E+5;//平方公里
            AreaConvert();
        }

        private void AreaUnitHectare_btnConvertClick(object sender, EventArgs e)
        {
            normAreaSquareMeter = AreaUnitHectare.UnitValue * 10E+3;//公顷
            AreaConvert();
        }

        private void AreaUnitAre_btnConvertClick(object sender, EventArgs e)
        {
            normAreaSquareMeter = AreaUnitAre.UnitValue * 100;//公亩
            AreaConvert();
        }

        private void AreaUnitSquareMeter_btnConvertClick(object sender, EventArgs e)
        {
            normAreaSquareMeter = AreaUnitSquareMeter.UnitValue;//平方米
            AreaConvert();
        }

        private void AreaUnitSquareDecimeter_btnConvertClick(object sender, EventArgs e)
        {
            normAreaSquareMeter = AreaUnitSquareDecimeter.UnitValue / 100;//平方分米
            AreaConvert();
        }

        private void AreaUnitSquareCentimeter_btnConvertClick(object sender, EventArgs e)
        {
            normAreaSquareMeter = AreaUnitSquareCentimeter.UnitValue / 10E+3;//平方厘米
            AreaConvert();
        }

        private void AreaUnitSquareMillimeter_btnConvertClick(object sender, EventArgs e)
        {
            normAreaSquareMeter = AreaUnitSquareMillimeter.UnitValue / 10E+5;//平方毫米
            AreaConvert();
        }

        private void AreaUnitSquareMile_btnConvertClick(object sender, EventArgs e)
        {
            normAreaSquareMeter = AreaUnitSquareMile.UnitValue * 2589988.110336;//平方英里
            AreaConvert();
        }

        private void AreaUnitArce_btnConvertClick(object sender, EventArgs e)
        {
            normAreaSquareMeter = AreaUnitArce.UnitValue * 4046.8564224;//英亩
            AreaConvert();
        }

        private void AreaUnitSquareYard_btnConvertClick(object sender, EventArgs e)
        {
            normAreaSquareMeter = AreaUnitSquareYard.UnitValue * 0.83612736;//平方码
            AreaConvert();
        }

        private void AreaUnitSquareFoot_btnConvertClick(object sender, EventArgs e)
        {
            normAreaSquareMeter = AreaUnitSquareFoot.UnitValue * 0.09290304;//平方英尺
            AreaConvert();
        }

        private void AreaUnitSquareInch_btnConvertClick(object sender, EventArgs e)
        {
            normAreaSquareMeter = AreaUnitSquareInch.UnitValue * 0.00064516;//平方英寸
            AreaConvert();
        }

        private void AreaUnitSquareRd_btnConvertClick(object sender, EventArgs e)
        {
            normAreaSquareMeter = AreaUnitSquareRd.UnitValue * 25.2928526;//平方竿
            AreaConvert();
        }

        private void AreaUnitQing_btnConvertClick(object sender, EventArgs e)
        {
            normAreaSquareMeter = AreaUnitQing.UnitValue * (20000/3);//顷
            AreaConvert();
        }

        private void AreaUnitShiMu_btnConvertClick(object sender, EventArgs e)
        {
            normAreaSquareMeter = AreaUnitShiMu.UnitValue * (2000/3);//市亩
            AreaConvert();
        }

        private void AreaUnitSquareZhang_btnConvertClick(object sender, EventArgs e)
        {
            normAreaSquareMeter = AreaUnitSquareZhang.UnitValue * (2000/180);//平方丈
            AreaConvert();
        }

        private void AreaUnitFen_btnConvertClick(object sender, EventArgs e)
        {
            normAreaSquareMeter = AreaUnitFen.UnitValue * (200/3);//分
            AreaConvert();
        }

        private void AreaUnitLi_btnConvertClick(object sender, EventArgs e)
        {
            normAreaSquareMeter = AreaUnitLi.UnitValue * (20/3);//厘
            AreaConvert();
        }

        private void AreaUnitSquareTaiWanJia_btnConvertClick(object sender, EventArgs e)
        {
            normAreaSquareMeter = AreaUnitSquareTaiWanJia.UnitValue * (2934 * 400 / 121);//台湾甲
            AreaConvert();
        }

        private void AreaUnitSquareTaiWanPing_btnConvertClick(object sender, EventArgs e)
        {
            normAreaSquareMeter = AreaUnitSquareTaiWanPing.UnitValue * (400 / 121);//台湾坪
            AreaConvert();
        }

        private  void WeightConvert()
        {
            //公制
            WeightUnitGongDun.UnitValue = normWeightKe /1E+6;//公吨
            WeightUnitGongjin.UnitValue = normWeightKe / 1E+3;//公斤
            WeightUnitKe.UnitValue = normWeightKe;//克
            WeightUnitHaoKe.UnitValue = normWeightKe / 1e-3;//毫克
            WeightUnitWeiKe.UnitValue = normWeightKe / 1e-6;//微克
            WeightUnitNaKe.UnitValue = normWeightKe / 1e-9;//纳克

            //市制
            WeightUnitShiJin.UnitValue = normWeightKe / 500;//市斤
            WeightUnitShiDan.UnitValue = normWeightKe / 50000;//市担
            WeightUnitShiLiang.UnitValue = normWeightKe / 50;//市两
            WeightUnitShiQian.UnitValue = normWeightKe / 5;//市钱

            //台制
            WeightUnitTaiJin.UnitValue = normWeightKe / 600;//台斤
            WeightUnitTaiLiang.UnitValue=normWeightKe/(600/16);//台两
            WeightUnitTaiQian.UnitValue = normWeightKe / (60 / 16);//台钱

            //香港的司马制
            WeightUnitSiMaJin.UnitValue = normWeightKe / 604.79;//司马斤
            WeightUnitSiMaLiang.UnitValue = normWeightKe / 37.42849791;//司马两

            //金衡制
            WeightUnitJinHengBang.UnitValue = normWeightKe / 373.2417216;//金衡磅
            WeightUnitJinHengAngSi.UnitValue = normWeightKe / 31.1034768;//金衡盎司
            WeightUnitYingQian.UnitValue = normWeightKe / 1.55517384;//英钱
            //WeightUnitJinHengGeLing.UnitValue = normWeightKe / 0.06479891;//金衡格令

            //专属单位
            WeightUnitKeLa.UnitValue = normWeightKe / 0.2;//克拉

            //常衡制
            WeightUnitYingZhiChangDun.UnitValue=normWeightKe / 1016046.91;//英制长吨
            WeightUnitMeiZhiDuanDun.UnitValue = normWeightKe / 907184.744;//美制短吨
            WeightUnitYingDan.UnitValue = normWeightKe / (8 * 14 * 453.59237);//英担
            WeightUnitMeiDan.UnitValue = normWeightKe / 45359.237;//美担
            WeightUnitYingShi.UnitValue = normWeightKe / (14 * 45359237);//英石
            WeightUnitGuoJiBang.UnitValue = normWeightKe / 453.59237;//国际磅
            WeightUnitChangHengAngSi.UnitValue = normWeightKe / (453.59237 / 16);//常衡盎司
            WeightUnitChangHengDaLan.UnitValue = normWeightKe / (453.59237 / 16 / 16);//常衡打兰
            WeightUnitGeLing.UnitValue = normWeightKe / 0.06479891;//格令

        }

        private void WeightUnitGongDun_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitGongDun.UnitValue * 1e+6;//公吨
            WeightConvert();
        }

        private void WeightUnitGongjin_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitGongjin.UnitValue * 1e+3;//公斤
            WeightConvert();
        }

        private void WeightUnitKe_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitKe.UnitValue;
            WeightConvert();
        }

        private void WeightUnitHaoKe_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitHaoKe.UnitValue / 1e+3;
            WeightConvert();
        }

        private void WeightUnitWeiKe_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitWeiKe.UnitValue / 1e+6;
            WeightConvert();
        }

        private void WeightUnitNaKe_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitNaKe.UnitValue / 1e+9;
            WeightConvert();
        }

        private void WeightUnitJinHengBang_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitJinHengBang.UnitValue * 373.2417216;
            WeightConvert();
        }

        private void WeightUnitJinHengAngSi_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitJinHengAngSi.UnitValue * 31.1034768;
            WeightConvert();
        }

        private void WeightUnitYingQian_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitYingQian.UnitValue * 1.55517384;
            WeightConvert();
        }

        private void WeightUnitShiDan_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitShiDan.UnitValue * 50000;
            WeightConvert();
        }

        private void WeightUnitShiJin_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitShiJin.UnitValue * 500;
            WeightConvert();
        }

        private void WeightUnitShiLiang_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitShiLiang.UnitValue * 50;
            WeightConvert();
        }

        private void WeightUnitShiQian_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitShiQian.UnitValue * 5;
            WeightConvert();
        }

        private void WeightUnitTaiJin_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitTaiJin.UnitValue * 600;
            WeightConvert();
        }

        private void WeightUnitTaiLiang_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitTaiLiang.UnitValue * (600 / 16);
            WeightConvert();
        }

        private void WeightUnitTaiQian_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitTaiQian.UnitValue * (60 / 16);
            WeightConvert();
        }

        private void WeightUnitSiMaJin_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitSiMaJin.UnitValue * 604.79;
            WeightConvert();
        }

        private void WeightUnitSiMaLiang_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitSiMaLiang.UnitValue * 37.42849791;
            WeightConvert();
        }

        private void WeightUnitYingZhiChangDun_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitYingZhiChangDun.UnitValue * 1016046.91;
            WeightConvert();
        }

        private void WeightUnitMeiZhiDuanDun_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitMeiZhiDuanDun.UnitValue * 907184.74;
            WeightConvert();
        }

        private void WeightUnitYingDan_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitYingDan.UnitValue * (8 * 14 * 453.59237);
            WeightConvert();
        }

        private void WeightUnitMeiDan_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitMeiDan.UnitValue * 45359.237; 
            WeightConvert();
        }

        private void WeightUnitYingShi_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitYingShi.UnitValue * (14 * 453.59237);
            WeightConvert();
        }

        private void WeightUnitGuoJiBang_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitGuoJiBang.UnitValue * 453.59237;
            WeightConvert();
        }

        private void WeightUnitChangHengAngSi_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitChangHengAngSi.UnitValue * (453.59237 / 16);
            WeightConvert();
        }

        private void WeightUnitChangHengDaLan_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitChangHengDaLan.UnitValue * 1.7718452;
            WeightConvert();
        }

        private void WeightUnitGeLing_btnConvertClick(object sender, EventArgs e)
        {
            normWeightKe = WeightUnitGeLing.UnitValue * 0.06479891;
            WeightConvert();
        }

        private void PowerConvert()//功率换算
        {

            PowerUnitWa.UnitValue = normPowerWa;//瓦
            PowerUnitQianWa.UnitValue = normPowerWa / 1000;//千瓦
            PowerUnitYingZhiMaLi.UnitValue = normPowerWa / 745.6999;//英制马力
            PowerUnitMiZhiMaLi.UnitValue = normPowerWa / 735.499;//米制马力
            PowerUnitGongZhiMaLi.UnitValue = normPowerWa / 735.49875;//公制马力
            PowerUnitDianQiMaLi.UnitValue = normPowerWa / 746;//电气马力
            PowerUnitGuoLuMaLi.UnitValue = normPowerWa / 9809.5;//锅炉马力
            PowerUnitYeYaMaLi.UnitValue = normPowerWa / 745.6999;//液压马力
            PowerUnitQianKeMiMeiMiao.UnitValue = normPowerWa / 9.80665;//千克米/秒
            PowerUnitQianKaMeiMiao.UnitValue = normPowerWa / 4186.8;//千卡/秒
            PowerUnitYingReDanWeiMeiXiaoShi.UnitValue = normPowerWa / 0.29307107;//英热单位/秒
            PowerUnitYingChiBangMeiMiao.UnitValue = normPowerWa / (745.6999 / 550);//英尺磅/秒
            PowerUnitJiaoErMeiMiao.UnitValue = normPowerWa;//焦耳/秒
            PowerUnitNiuDunMiMeiMiao.UnitValue = normPowerWa;//牛顿米/秒

        }

        private void PowerUnitWa_btnConvertClick(object sender, EventArgs e)
        {
            normPowerWa = PowerUnitWa.UnitValue;
            PowerConvert();
        }

        private void PowerUnitQianWa_btnConvertClick(object sender, EventArgs e)
        {
            normPowerWa = PowerUnitQianWa.UnitValue * 1000;
            PowerConvert();
        }

        private void PowerUnitYingZhiMaLi_btnConvertClick(object sender, EventArgs e)
        {
            normPowerWa = PowerUnitYingZhiMaLi.UnitValue * 745.6999;
            PowerConvert();
        }

        private void PowerUnitMiZhiMaLi_btnConvertClick(object sender, EventArgs e)
        {
            normPowerWa = PowerUnitMiZhiMaLi.UnitValue * 735.499;
            PowerConvert();
        }

        private void PowerUnitGongZhiMaLi_btnConvertClick(object sender, EventArgs e)
        {
            normPowerWa = PowerUnitGongZhiMaLi.UnitValue * 735.49875;
            PowerConvert();
        }

        private void PowerUnitDianQiMaLi_btnConvertClick(object sender, EventArgs e)
        {
            normPowerWa = PowerUnitDianQiMaLi.UnitValue * 746;
            PowerConvert();
        }

        private void PowerUnitGuoLuMaLi_btnConvertClick(object sender, EventArgs e)
        {
            normPowerWa = PowerUnitGuoLuMaLi.UnitValue * 9809.5;
            PowerConvert();
        }

        private void PowerUnitYeYaMaLi_btnConvertClick(object sender, EventArgs e)
        {
            normPowerWa = PowerUnitYeYaMaLi.UnitValue * 745.6999;
            PowerConvert();
        }

        private void PowerUnitQianKeMiMeiMiao_btnConvertClick(object sender, EventArgs e)
        {
            normPowerWa = PowerUnitQianKeMiMeiMiao.UnitValue * 9.80665;
            PowerConvert();
        }

        private void PowerUnitQianKaMeiMiao_btnConvertClick(object sender, EventArgs e)
        {
            normPowerWa = PowerUnitQianKaMeiMiao.UnitValue * 4186.8;
            PowerConvert();
        }

        private void PowerUnitYingReDanWeiMeiXiaoShi_btnConvertClick(object sender, EventArgs e)
        {
            normPowerWa = PowerUnitYingReDanWeiMeiXiaoShi.UnitValue * 0.29307107;
            PowerConvert();
        }

        private void PowerUnitYingChiBangMeiMiao_btnConvertClick(object sender, EventArgs e)
        {
            normPowerWa=PowerUnitYingChiBangMeiMiao.UnitValue*(745.6999/550);
            PowerConvert();
        }

        private void PowerUnitJiaoErMeiMiao_btnConvertClick(object sender, EventArgs e)
        {
            normPowerWa = PowerUnitJiaoErMeiMiao.UnitValue;
            PowerConvert();
        }

        private void PowerUnitNiuDunMiMeiMiao_btnConvertClick(object sender, EventArgs e)
        {
            normPowerWa = PowerUnitNiuDunMiMeiMiao.UnitValue;
            PowerConvert();
        }

        private void TemperatureConvert()
        {
            TemperatureUnitSheShiDu.UnitValue = normTemperatureSheShiDu;//摄氏度
            TemperatureUnitHuaShiDu.UnitValue = normTemperatureSheShiDu * 9 / 5 + 32;//华氏度
            TemperatureUnitKaiShiDu.UnitValue = normTemperatureSheShiDu + 273.15;//开氏度
            TemperatureUnitLanShiDu.UnitValue = (normTemperatureSheShiDu + 273.15) * 1.8;//兰氏度
            TemperatureUnitLieShiDu.UnitValue = normTemperatureSheShiDu *4/5;//列氏度
            TemperatureUnitNiuDunWenBiao.UnitValue = normTemperatureSheShiDu * 33/100;//牛顿温标
            TemperatureUnitLanJinWenBiao.UnitValue = (normTemperatureSheShiDu + 273.15) * 9 / 5;//兰金温标
        }

        private void TemperatureUnitSheShiDu_btnConvertClick(object sender, EventArgs e)
        {
            normTemperatureSheShiDu = TemperatureUnitSheShiDu.UnitValue;
            TemperatureConvert();
        }

        private void TemperatureUnitHuaShiDu_btnConvertClick(object sender, EventArgs e)
        {
            normTemperatureSheShiDu = (TemperatureUnitHuaShiDu.UnitValue - 32) / 1.8;
            TemperatureConvert();
        }

        private void TemperatureUnitKaiShiDu_btnConvertClick(object sender, EventArgs e)
        {
            normTemperatureSheShiDu = TemperatureUnitKaiShiDu.UnitValue -273.15;
            TemperatureConvert();
        }

        private void TemperatureUnitLanShiDu_btnConvertClick(object sender, EventArgs e)
        {
            normTemperatureSheShiDu = TemperatureUnitLanShiDu.UnitValue / 1.8 - 273.15;
            TemperatureConvert();
        }

        private void TemperatureUnitLieShiDu_btnConvertClick(object sender, EventArgs e)
        {
            normTemperatureSheShiDu = TemperatureUnitLieShiDu.UnitValue *5/4;
            TemperatureConvert();
        }

        private void TemperatureUnitGuoJiShiYongWenBiao_btnConvertClick(object sender, EventArgs e)
        {
            normTemperatureSheShiDu = TemperatureUnitNiuDunWenBiao.UnitValue * 100 / 33;
            TemperatureConvert();
        }

        private void ThermalCorvert()
        {
            ThermalUnitJiaoEr.UnitValue = normThermalJiaoEr;//焦耳
            ThermalUnitQianKeLiMi.UnitValue = normThermalJiaoEr / 9.80665;//千克力米
            ThermalUnitMiZhiMaLiShi.UnitValue = normThermalJiaoEr / 2.64779e+6;
            ThermalUnitYingZhiMaLiShi.UnitValue = normThermalJiaoEr / 2.68452e+6;
            ThermalUnitQianWaShi.UnitValue = normThermalJiaoEr / 3.6e+6;
            ThermalUnitYingReDanWei.UnitValue = normThermalJiaoEr / 1055.05585;
            ThermalUnitYingChiBang.UnitValue = normThermalJiaoEr / 1.35582;
            ThermalUnitKa.UnitValue = normThermalJiaoEr / 4.184;
            ThermalUnitDaKa.UnitValue = normThermalJiaoEr / 4184;
        }

        private void ThermalUnitKa_btnConvertClick(object sender, EventArgs e)
        {
            normThermalJiaoEr = ThermalUnitKa.UnitValue * 4.184;
            ThermalCorvert();
        }

        private void ThermalUnitDaKa_btnConvertClick(object sender, EventArgs e)
        {
            normThermalJiaoEr = ThermalUnitDaKa.UnitValue * 4184.0;
            ThermalCorvert();
        }

        private void ThermalUnitJiaoEr_btnConvertClick(object sender, EventArgs e)
        {
            normThermalJiaoEr = ThermalUnitJiaoEr.UnitValue;
            ThermalCorvert();
        }

        private void ThermalUnitQianWaShi_btnConvertClick(object sender, EventArgs e)
        {
            normThermalJiaoEr = ThermalUnitQianWaShi.UnitValue * 3.6e+6;
            ThermalCorvert();
        }

        private void ThermalUnitYingReDanWei_btnConvertClick(object sender, EventArgs e)
        {
            normThermalJiaoEr = ThermalUnitYingReDanWei.UnitValue * 1055.05585;
            ThermalCorvert();
        }

        private void ThermalUnitYingChiBang_btnConvertClick(object sender, EventArgs e)
        {
            normThermalJiaoEr = ThermalUnitYingChiBang.UnitValue * 1.35582;
            ThermalCorvert();
        }

        private void ThermalUnitQianKeLiMi_btnConvertClick(object sender, EventArgs e)
        {
            normThermalJiaoEr = ThermalUnitQianKeLiMi.UnitValue * 9.80665;
            ThermalCorvert();
        }

        private void ThermalUnitMiZhiMaLiShi_btnConvertClick(object sender, EventArgs e)
        {
            normThermalJiaoEr = ThermalUnitMiZhiMaLiShi.UnitValue * 2.64779e+6;
            ThermalCorvert();
        }

        private void ThermalUnitYingZhiMaLiShi_btnConvertClick(object sender, EventArgs e)
        {
            normThermalJiaoEr = ThermalUnitYingZhiMaLiShi.UnitValue * 2.68452e+6;
            ThermalCorvert();
        }


        private void VolumeConvert()//容积、体积转换
        {
            //公制转换
            VolumeUnitLiFangMi.UnitValue = normVolumeSheng / 1e+3;//立方米
            VolumeUnitSheng.UnitValue = normVolumeSheng;//升
            VolumeUnitFenSheng.UnitValue = normVolumeSheng * 10;//分升
            VolumeUnitLiSheng.UnitValue = normVolumeSheng * 100;//厘升
            VolumeUnitHaoSheng.UnitValue = normVolumeSheng * 1e+3;//立方厘米，即毫升
            VolumeUnitWeiSheng.UnitValue = normVolumeSheng * 1e+6;//立方毫米，即毫升
            


            //英美同制体积计量
            VolumeUnitMuYingChi.UnitValue = normVolumeSheng / 1233805.58606;//亩英尺
            VolumeUnitLiFangMa.UnitValue = normVolumeSheng / (9.144 *9.144*9.144);//立方码，9.144是码换算成分米的
            VolumeUnitLiFangYingChi.UnitValue = normVolumeSheng / (3.048 *3.048*3.048);//立方英尺，3.048是英尺换算成分米的
            VolumeUnitLiFangYingCun.UnitValue = normVolumeSheng / ((25.4 / 100) *(25.4/100)*(25.4/100));//立方英寸，25.4/100是英寸换算成分米的

            /*
            ///如下是美制干量
            ///美制干量中最重要的是加仑，它被定义为4.404 883 770 86升。
            ///品脱定义为加仑的 1/8
            ///夸脱定义为2倍品脱
            ///配克定义为8倍夸脱
            ///蒲式耳定义为4倍配克
            ///桶定义为105倍夸脱
            ///
             */

            VolumeUnitMeiZhiGanLiangJiaLun.UnitValue = normVolumeSheng / dblMeiZhiGanLiangJiaLunCanShu;
            VolumeUnitMeiZhiGanLiangPinTuo.UnitValue = normVolumeSheng / (dblMeiZhiGanLiangJiaLunCanShu / 8);
            VolumeUnitMeiZhiGanLiangKuaTuo.UnitValue = normVolumeSheng / (dblMeiZhiGanLiangJiaLunCanShu / 4);
            VolumeUnitMeiZhiGanLiangPeiKe.UnitValue = normVolumeSheng / (dblMeiZhiGanLiangJiaLunCanShu * 2);
            VolumeUnitMeiZhiGanLiangPuShiEr.UnitValue = normVolumeSheng / (dblMeiZhiGanLiangJiaLunCanShu * 8);
            VolumeUnitMeiZhiGanLiangTong.UnitValue = normVolumeSheng / (105 * dblMeiZhiGanLiangJiaLunCanShu / 4);

            /*如下是英制液体和干量
             * 这个最重要的是加仑，它被定义为 4.546 09升
             * 英制品脫現在的官方定義是0.56826125 升,品脱有官方定义，还是用品脱比较好些
             * 
             * 1 英制品脱 = 4 及耳 = 1/2 夸脱 = 1/8 加仑= 1/64 蒲式耳
             * 1 英制品脱 = 20 液盎司 
             * 桶被定义为36加仑,288倍品脱
             * 
             */

            VolumeUnitYingZhiYeLiangHeGanLiangPinTuo.UnitValue = normVolumeSheng / dblYingZhiYeTiHeGanLiangPinTuo;//品脱
            VolumeUnitYingZhiYeLiangHeGanLiangKuaTuo.UnitValue = normVolumeSheng / (dblYingZhiYeTiHeGanLiangPinTuo * 2);//夸脱＝2倍品脱
            VolumeUnitYingZhiYeLiangHeGanLiangJiaLun.UnitValue = normVolumeSheng / (dblYingZhiYeTiHeGanLiangPinTuo * 8);//加仑
            VolumeUnitYingZhiYeLiangHeGanLiangPuShiEr.UnitValue = normVolumeSheng / (dblYingZhiYeTiHeGanLiangPinTuo * 64);//蒲式耳
            VolumeUnitYingZhiYeLiangHeGanLiangTong.UnitValue = normVolumeSheng / (dblYingZhiYeTiHeGanLiangPinTuo * 288);//桶
            VolumeUnitYingZhiYeLiangHeGanLiangYeLiangAngSi.UnitValue = normVolumeSheng / (dblYingZhiYeTiHeGanLiangPinTuo / 20);//液量盎司

            /*
             * 如下是美制液体。
             * 
             * 美制的液体加仑被定义为3.785 411 784升。这个是维基百科上的数据，应该是准确的，就拿它作为基准吧。
             * 1蒲式耳等于8加仑
             * 
             * 
             *  美制湿量品脱 = 16 美制液盎司 
             *  1 美制湿量夸脱 = 32 美制液盎司 
             * 
             */


            VolumeUnitMeiZhiYeTiYuanYouTong.UnitValue=normVolumeSheng / (42 * dblMeiZhiYeTiJiaLun);//这个数据会比维基百科上说原油桶为158.9873多了好几位小数
            VolumeUnitMeiZhiYeTiPiJiuTong.UnitValue = normVolumeSheng / 117.3;//这个是从维基百科上找的119.2，没找到更准确的数据
            VolumeUnitMeiZhiYeTiQiTaTong.UnitValue = normVolumeSheng / 119.2;// 这个是从维基百科上找的，但不知道其他的桶是不是都是这个数据。
            VolumeUnitMeiZhiYeTiJiaLun.UnitValue = normVolumeSheng/dblMeiZhiYeTiJiaLun;//加仑
            VolumeUnitMeiZhiYeTiKuaTuo.UnitValue=normVolumeSheng/(dblMeiZhiYeTiJiaLun/4);//夸脱
            VolumeUnitMeiZhiYeTiPinTuo.UnitValue = normVolumeSheng / (dblMeiZhiYeTiJiaLun / 8);//品脱
            VolumeUnitMeiZhiYeTiJiEr.UnitValue = normVolumeSheng / (dblMeiZhiYeTiJiaLun / 32);//及耳等于1/32加仑
            VolumeUnitMeiZhiYeTiYeLiangAngSi.UnitValue = normVolumeSheng / (dblMeiZhiYeTiJiaLun / 128);//液量盎司＝1/128加仑
            VolumeUnitMeiZhiYeTiYeLiangDaLan.UnitValue = normVolumeSheng / (dblMeiZhiYeTiJiaLun / 1024);//液量打兰等于 1/1024加仑
            VolumeUnitMeiZhiYeTiLiangDi.UnitValue = normVolumeSheng / (dblMeiZhiYeTiJiaLun / 7864320);//量滴等于 1/7864320加仑

        }

        private void VolumeUnitLiFangMi_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitLiFangMi.UnitValue * 1e+3;//立方米
            VolumeConvert();
        }

        private void VolumeUnitSheng_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitSheng.UnitValue;// 升
            VolumeConvert();
        }

        private void VolumeUnitFenSheng_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitFenSheng.UnitValue / 10;//分升
            VolumeConvert();
        }

        private void VolumeUnitLiSheng_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitLiSheng.UnitValue / 100;//厘升
            VolumeConvert();
        }

        private void VolumeUnitHaoSheng_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitHaoSheng.UnitValue / 1000;//毫升
            VolumeConvert();
        }

        private void VolumeUnitWeiSheng_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitWeiSheng.UnitValue / 1e+6;//微升
            VolumeConvert();
        }

        private void VolumeUnitMuYingChi_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitMuYingChi.UnitValue * 1233805.58606;//亩英尺
            VolumeConvert();
        }

        private void VolumeUnitLiFangMa_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitLiFangMa.UnitValue * (9.144 *9.144*9.144);//立方码
            VolumeConvert();
        }

        private void VolumeUnitLiFangYingChi_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitLiFangYingChi.UnitValue * (3.048 *3.048*3.048);//立方英尺
            VolumeConvert();
        }

        private void VolumeUnitLiFangYingCun_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitLiFangYingCun.UnitValue * ((25.4 / 100) * (25.4 / 100) * (25.4 / 100));//立方英寸
            VolumeConvert();
        }

        private void VolumeUnitMeiZhiGanLiangTong_btnConvertClick(object sender, EventArgs e)
        {

            normVolumeSheng = VolumeUnitMeiZhiGanLiangTong.UnitValue * (105 * dblMeiZhiGanLiangJiaLunCanShu / 4);//美制干量桶
            VolumeConvert();

        }

        private void VolumeUnitMeiZhiGanLiangPuShiEr_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitMeiZhiGanLiangPuShiEr.UnitValue * (dblMeiZhiGanLiangJiaLunCanShu * 8);//美制干量蒲式耳
            VolumeConvert();
        }

        private void VolumeUnitMeiZhiGanLiangPeiKe_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitMeiZhiGanLiangPeiKe.UnitValue * (dblMeiZhiGanLiangJiaLunCanShu * 2);//美制干量配克
            VolumeConvert();
        }

        private void VolumeUnitMeiZhiGanLiangJiaLun_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitMeiZhiGanLiangJiaLun.UnitValue * dblMeiZhiGanLiangJiaLunCanShu;//美制干量加仑
            VolumeConvert();
        }

        private void VolumeUnitMeiZhiGanLiangKuaTuo_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitMeiZhiGanLiangKuaTuo.UnitValue * (dblMeiZhiGanLiangJiaLunCanShu / 4);//美制干量夸脱
            VolumeConvert();
        }

        private void VolumeUnitMeiZhiGanLiangPinTuo_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitMeiZhiGanLiangPinTuo.UnitValue * (dblMeiZhiGanLiangJiaLunCanShu / 8);// 美制干量品脱
            VolumeConvert();
        }

        private void VolumeUnitYingZhiYeLiangHeGanLiangTong_btnConvertClick(object sender, EventArgs e)
        {

            normVolumeSheng = VolumeUnitYingZhiYeLiangHeGanLiangTong.UnitValue * (dblYingZhiYeTiHeGanLiangPinTuo * 288);//桶
            VolumeConvert();

        }

        private void VolumeUnitYingZhiYeLiangHeGanLiangPuShiEr_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitYingZhiYeLiangHeGanLiangPuShiEr.UnitValue * dblYingZhiYeTiHeGanLiangPinTuo * 64;//蒲式耳
            VolumeConvert();
        }

        private void VolumeUnitYingZhiYeLiangHeGanLiangJiaLun_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitYingZhiYeLiangHeGanLiangJiaLun.UnitValue * dblYingZhiYeTiHeGanLiangPinTuo * 8;//加仑
            VolumeConvert();
        }

        private void VolumeUnitYingZhiYeLiangHeGanLiangKuaTuo_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitYingZhiYeLiangHeGanLiangKuaTuo.UnitValue * dblYingZhiYeTiHeGanLiangPinTuo * 2;//夸脱＝2倍品脱
        }

        private void VolumeUnitYingZhiYeLiangHeGanLiangPinTuo_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitYingZhiYeLiangHeGanLiangPinTuo.UnitValue * dblYingZhiYeTiHeGanLiangPinTuo;//品脱
            VolumeConvert();
        }

        private void VolumeUnitYingZhiYeLiangHeGanLiangYeLiangAngSi_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitYingZhiYeLiangHeGanLiangYeLiangAngSi.UnitValue * (dblYingZhiYeTiHeGanLiangPinTuo / 20);//液量盎司
            VolumeConvert();
        }

        private void VolumeUnitMeiZhiYeTiYuanYouTong_btnConvertClick(object sender, EventArgs e)
        {

            normVolumeSheng = VolumeUnitMeiZhiYeTiYuanYouTong.UnitValue * (42 * dblMeiZhiYeTiJiaLun);//这个数据会比维基百科上说原油桶为158.9873多了好几位小数
            VolumeConvert();

        }

        private void VolumeUnitMeiZhiYeTiPiJiuTong_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitMeiZhiYeTiPiJiuTong.UnitValue * 117.3;//这个是从维基百科上找的119.2，没找到更准确的数据
            VolumeConvert();
        }

        private void VolumeUnitMeiZhiYeTiQiTaTong_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitMeiZhiYeTiQiTaTong.UnitValue * 119.2;// 这个是从维基百科上找的，但不知道其他的桶是不是都是这个数据。
            VolumeConvert();
        }

        private void VolumeUnitMeiZhiYeTiJiaLun_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitMeiZhiYeTiJiaLun.UnitValue * dblMeiZhiYeTiJiaLun;//美制液体加仑
            VolumeConvert();
        }

        private void VolumeUnitMeiZhiYeTiKuaTuo_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitMeiZhiYeTiKuaTuo.UnitValue * (dblMeiZhiYeTiJiaLun / 4);//夸脱
            VolumeConvert();
        }

        private void VolumeUnitMeiZhiYeTiPinTuo_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitMeiZhiYeTiPinTuo.UnitValue * (dblMeiZhiYeTiJiaLun / 8);//品脱
            VolumeConvert();
        }

        private void VolumeUnitMeiZhiYeTiJiEr_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitMeiZhiYeTiJiEr.UnitValue * (dblMeiZhiYeTiJiaLun / 32);//及耳等于1/32加仑
            VolumeConvert();
        }

        private void VolumeUnitMeiZhiYeTiYeLiangAngSi_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitMeiZhiYeTiYeLiangAngSi.UnitValue * (dblMeiZhiYeTiJiaLun / 128);//液量盎司＝1/128加仑
            VolumeConvert();
        }

        private void VolumeUnitMeiZhiYeTiYeLiangDaLan_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitMeiZhiYeTiYeLiangDaLan.UnitValue * (dblMeiZhiYeTiJiaLun / 1024);//液量打兰等于 1/1024加仑
            VolumeConvert();

        }

        private void VolumeUnitMeiZhiYeTiLiangDi_btnConvertClick(object sender, EventArgs e)
        {
            normVolumeSheng = VolumeUnitMeiZhiYeTiLiangDi.UnitValue * (dblMeiZhiYeTiJiaLun / 7864320);//量滴等于 1/7864320加仑
            VolumeConvert();
        }

        private void radioButtonJiaoDu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonJiaoDu.Checked)
            {
                UserControlUnitInput.strJiaoDuDanWei = "JiaoDu";
            }
        }

        private void radioButtonHuDu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHuDu.Checked)
            {
                UserControlUnitInput.strJiaoDuDanWei = "HuDu";
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //clsProcess.Start("http://www.xuhengxiao.com/?p=31");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //clsProcess.Start("http://www.xuhengxiao.com/?p=31");
        }



        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //clsProcess.Start("http://xuhengxiao.taobao.com/");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //clsProcess.Start("http://www.xuhengxiao.com/");
        }

        private void userControlUnitInput19_btnConvertClick(object sender, EventArgs e)
        {
            //([R] − 491.67) × 5⁄9
            normTemperatureSheShiDu = (TemperatureUnitLanJinWenBiao.UnitValue - 491.67) * 5 / 9;
            TemperatureConvert();

        }



    }
}
