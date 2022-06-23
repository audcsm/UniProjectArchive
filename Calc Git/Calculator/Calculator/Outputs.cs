using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Outputs
    {

        #region Attributes

        private decimal leftBud;
        private decimal Total;
        private decimal spentLux;
        private decimal spentEss;

        #endregion

        #region properties

        public decimal GetleftBud
        {
            get
            {
                return leftBud;
            }
            set
            {
                leftBud = value;
            }
        }

        public decimal GetTotal
        {
            get
            {
                return Total;
            }
            set
            {
                Total = value;
            }
        }
        public decimal GetspentLux
        {
            get 
            {
                return spentLux;           
            }
            set 
            {
                spentLux = value;
            }
        }
        public decimal Getspentess 
        {
            get 
            {
                return spentEss;            
            }
            set 
            {
                spentEss = value;
            }
        }
        #endregion

        #region Constructors
        public Outputs(decimal Tot, decimal left, decimal Lux, decimal Ess) 
        {
            Total = Tot;
            leftBud = left;
            spentLux = Lux;
            spentEss = Ess;
        }

        #endregion

    }
}
