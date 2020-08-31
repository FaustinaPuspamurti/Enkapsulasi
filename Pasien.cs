using System;
using System.Collections.Generic;
using System.Text;
namespace rumahsakit
{
    class Pasien : User
    {
        public string biodataPasien()
        {
            base.riwayatPasien = "Serangan Jantung";
            return riwayatPasien;
        }
    }
}
