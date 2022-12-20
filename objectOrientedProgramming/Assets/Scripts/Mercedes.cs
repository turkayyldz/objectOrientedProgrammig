using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercedes :Araba
{
   public bool UcutorMu { get; set; }
    public override void SatisYap()
    {
        ToplamFiyati = Fiyati;
        if (SifirMi)
        {
            ToplamFiyati += 4000m;
        }
        if (UcutorMu)
        {
            ToplamFiyati += 6000m;

        }
    }
}
