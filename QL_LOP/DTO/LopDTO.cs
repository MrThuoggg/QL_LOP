using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_LOP.DTO
{
    internal class LopDTO
    {
        private string _malop;
        private string _tenlop;
        public string malop
        {
            get { return _malop; }
            set { _malop = value; }
        }
        public string tenlop
        {
            get { return _tenlop; }
            set { _tenlop = value; }
        }
        public LopDTO()
        {
            _malop = "";
            _tenlop = "";
        }
        public LopDTO( string malop, string tenlop)
        {
            _malop = malop;
            _tenlop = tenlop;
        }
    }
}
