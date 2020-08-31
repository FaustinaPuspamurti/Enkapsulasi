using System;
using System.Collections.Generic;
using System.Text;
namespace rumahsakit
{
    class Dokter : User
    {
        public string biodataDokter()
        {
            base.riwayatPasien = "Sehat";
            return riwayatPasien;
        }
    }
}
