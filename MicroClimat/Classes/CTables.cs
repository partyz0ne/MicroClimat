using System;

namespace MicroClimat.Classes
{
    class CTables
    {
        double _dblTempDry, _dblTempWet, _dblPressure;
        bool _bIce;
        double _ePar, _edPar, _ewPar;
        double _dblDRes, _dblRRes;
        bool _bStation = true;
        double _dblApar = 0.0007947;

        /// <summary>
        /// Температура сухого термометра психрометра.
        /// </summary>
        public double TempDry { set { _dblTempDry = value; } }
        /// <summary>
        /// Температура смоченного термометра психрометра.
        /// </summary>
        public double TempWet { set { _dblTempWet = value; } }
        /// <summary>
        /// Атмосферное давление.
        /// </summary>
        public double Pressure { set { _dblPressure = value; } }
        /// <summary>
        /// Показатель льда на смоченном термометре психрометра.
        /// </summary>
        public bool Ice { set { _bIce = value; } }
        /// <summary>
        /// Относительная влажность воздуха.
        /// </summary>
        public double Humidity { get { return _dblRRes; } }
        /// <summary>
        /// Недостаточность насыщения воздуха влагой.
        /// </summary>
        public double Saturation { get { return _dblDRes; } }

        /// <summary>
        /// Изменяет тип используемого психрометра.
        /// </summary>
        /// <param name="bStation">True, если используется стационарный психрометр,
        /// False - если аспирационный.</param>
        public void ChangePsyType(bool bStation)
        {
            if (_bStation != bStation)
            {
                if (bStation)
                {
                    _dblApar = 0.0007947;
                    _bStation = true;
                }
                else
                {
                    _dblApar = 0.000662;
                    _bStation = false;
                }
            }
        }

        /// <summary>
        /// Получить промежуточные коэффициенты параметров для расчетов.
        /// </summary>
        private void FillParams()
        {
            _ewPar = (_bIce && _dblTempWet < 0) ? GetEforIce() : GetEforWater(_dblTempWet);
            _ePar = _ewPar - _dblApar * _dblPressure * (_dblTempDry - _dblTempWet);
            _edPar = GetEforWater(_dblTempDry);
        }

        /// <summary>
        /// Получить параметр E для воды.
        /// </summary>
        /// <param name="dblTemp">Температура смоченного психрометра.</param>
        /// <returns></returns>
        private double GetEforWater(double dblTemp)
        {
            double dblT = 273 + dblTemp;
            double dblX = (dblT - 453) / 10;
            const double dblA = 3.1473172;
            const double dblB = 0.00295944;
            const double dblM = 0.0004191398;
            const double dblN = 0.0000001829924;
            const double dblS = 0.00000008243516;
            double dblPow = 5.3208 - (dblA - dblB * dblX + dblM * Math.Pow(dblX, 2) - dblN * Math.Pow(dblX, 3) + dblS * Math.Pow(dblX, 4)) * ((643 - dblT) / dblT);
            return Math.Pow(10, dblPow);
        }

        /// <summary>
        /// Получить параметр E для льда.
        /// </summary>
        /// <returns></returns>
        private double GetEforIce()
        {
            double dblT = 273.15 + _dblTempWet;
            const double dblT1 = 273.16;
            double dblPow = -9.09685 * (dblT1 / dblT - 1) - 3.56654 * Math.Log10(dblT1 / dblT) + 0.87682 * (1 - dblT / dblT1) + 0.78614;
            return Math.Pow(10, dblPow);
        }

        /// <summary>
        /// Произвести расчеты.
        /// </summary>
        /// <returns>True в случае удачи, False - в случае неудачи.</returns>
        public bool Calculate()
        {
            FillParams();
            _dblRRes = Math.Round((_ePar / _edPar) * 100, 0);
            _dblDRes = Math.Round(_edPar - _ePar, 2);
            return true;
        }
    }
}
