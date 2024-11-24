using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_LOP.DTO
{
    internal class SinhVienDTO
    {
        private string _masv;
        private string _hoten;
        private string _phai;
        private string _ngaysinh;
        private string _noisinh;
        private string _malop;
        public string masv
        {
            get { return _masv; }
            set { _masv = value; }
        }
        public string hoten
        {
            get { return _hoten; }
            set { _hoten = value; }
        }
        public string phai
        {
            get { return _phai; }
            set { _phai = value; }
        }
        public string ngaysinh
        {
            get { return _ngaysinh; }
            set { _ngaysinh = value; }
        }
        public string noisinh
        {
            get { return _noisinh; }
            set { _noisinh = value; }
        }
        public string malop
        {
            get { return _malop; }
            set { _malop = value; }
        }

        public SinhVienDTO()
        {
            _masv = "";
            _hoten = "";
            _phai = "";
            _ngaysinh = "";
            _noisinh = "";
            _malop = "";
        }
        public SinhVienDTO(string masv, string hoten, string phai, string ngaysinh, string noisinh, string malop)
        {
            _masv = masv;
            _hoten = hoten;
            _phai = phai;
            _ngaysinh = ngaysinh;
            _noisinh = noisinh;
            _malop = malop;
        }
    }
}
