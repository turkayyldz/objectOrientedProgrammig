using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bmw : Araba
{
    public bool YuzuyorMu { get; set; }
    public override void SatisYap()
    {
        ToplamFiyati = Fiyati;
        if (SifirMi)
        {
            ToplamFiyati += 5000m;
        }
        if (YuzuyorMu)
        {
            ToplamFiyati += 7000m;

        }
    }
}


