using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOT.NEGOCIO
{
    public class AbonoProrrateo
    {
        private int _montoProrrateo;

        public AbonoProrrateo()
        {
        }

        public AbonoProrrateo(int montoProrrateo)
        {
            MontoProrrateo = montoProrrateo;
        }

        public int MontoProrrateo
        {
            get { return _montoProrrateo; }
            set { _montoProrrateo = value; }
        }

    }
}
