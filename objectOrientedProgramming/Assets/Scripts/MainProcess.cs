using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;


public class MainProcess : MonoBehaviour
{
    [Header("First Process Items")]
    [SerializeField] TMP_InputField fistNameFirstInput;
    [SerializeField] TMP_InputField lastNameFirstInput;
    [SerializeField] TMP_InputField ageFirstInput;
    [Header("Second Process Items")]
    [SerializeField] TMP_InputField fistNameSecondInput;
    [SerializeField] TMP_InputField lastNameSecondInput;
    [SerializeField] TMP_InputField ageSecondInput;
    private void Start()
    {
        Bmw bmw1 = new Bmw();
        bmw1.Marka = "Bmw";
        bmw1.Model = "Bmw Modeli";
        bmw1.Hizi = 350f;
        bmw1.KapiSayisi = 2;
        bmw1.SifirMi = true;
        bmw1.YuzuyorMu = true;
        bmw1.Fiyati = 10000m;
        bmw1.SatisYap();
        string resultBmw = "Bmw toplam Fiyati " + bmw1.ToplamFiyati;

        Mercedes mercedes = new Mercedes();
        mercedes.Marka = "Mercedes";
        mercedes.Model = "mercedes Model";
        mercedes.Hizi = 400f;
        mercedes.KapiSayisi = 4;
        mercedes.SifirMi = true;
        mercedes.UcutorMu = true;
        mercedes.Fiyati = 12000m;
        string resultMercedes = "Mercedes toplam Fiyati " + mercedes.ToplamFiyati;
        mercedes.SatisYap();
    }
    public void ButtonClick()
    {
        Ýnsan insan1 = new Ýnsan();
        insan1.FirstName = fistNameFirstInput.text;
        insan1.LastName = lastNameFirstInput.text;
        //insan1.age =int.Parse( ageFirstInput.text);
        insan1.Age = System.Convert.ToInt32(ageFirstInput.text);
        //if (insan1.Age<1||insan1.Age>100)
        //{
        //    Debug.LogError("Ýnsan Yaþý 1 den küçün 100 den büyük olamaz.");
        //    throw new System.Exception("Hata oldu"); 
        //}
    }
    public void ButtonClickSecond()
    {

        Ýnsan insan1 = new Ýnsan();
        insan1.FirstName = fistNameSecondInput.text;
        insan1.LastName = lastNameSecondInput.text;
        insan1.Age = System.Convert.ToInt32(ageSecondInput.text);
        //if (insan1.Age < 1 || insan1.Age > 100)
        //{
        //    Debug.LogError("Ýnsan Yaþý 1 den küçün 100 den büyük olamaz.");
        //    throw new System.Exception("Hata oldu");
        //}
    }
   private void InhertanceOrnek()
    {
        Calisan calisan = new Calisan();
        calisan.FirstName = "Turkay";
        calisan.LastName = "Yýldýz";
        calisan.Age = 25;
        calisan.Salary = 15000m;

        Musteri musteri = new Musteri
        {
            FirstName = "Aydýn",
            LastName="Yýldýz",
            Age=55,
            BirtDate=DateTime.Now,
            KrediCartInfo1="46546546654"

        };
    }
}
