using System;
using Collection.ClassInduk;

namespace Collection.ClassAnak
{
    public class Sales : Karyawan
    {
        public override string Nik { get; set; }
        public override string Nama { get; set; }
        public double JumlahPenjualan { get; set; }
        public double Komisi { get; set; }
        public override double Gaji()
        {
            return JumlahPenjualan*Komisi;
        }
    }
}