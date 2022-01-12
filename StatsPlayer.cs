using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class StatsPlayer : MonoBehaviour
{
    public UnikWork unikpraca;
    [SerializeField] Text Obra¿eniaMini;
    [SerializeField] Text Obra¿eniaMax;
    [SerializeField] Text WyswietlanieSila1;
    [SerializeField] Text WyswietlanieWitalnosc;
    [SerializeField] Text WyswietlanieZrecznosc;
    [SerializeField] Text WyswietlanieZycie;

     public int pz = 500;
     internal int sila = 1;
     internal int witalnosc = 1;
     internal int zrecznosc = 1;
     internal int Lvl = 1;

     public int Dostepnepukty = 0;
     public long nextlvl = 50;
     public long AktulanyExp;
     internal int DmgMax = 19;
     internal int DmgMini = 5;

     int randomowyprzyrostlvl;
     int randomowyprzyrostwitalnosc;

     bool maxlvl = true;
     bool lvlup = false;
     bool wzorstsi³y = false;
     bool wzrostzrecznosc = false;    
     bool wzrostwitalnosc = false;


    private void Update()
    {
        
        Jakdzia³aZrecznosc();
        JakDzia³aWitalnosc();
        Radomowka();
        LvlUpWzrostStatystyk();
        Lvlup();
        JakDzia³¹Si³a();
        WyswietlanieStat();
        Blokadaexpa();
    }
    void Lvlup()
    {
        if (nextlvl <= AktulanyExp)
        {
            if (maxlvl == true)     
            { 
            Lvl++;
            Dostepnepukty += 3;
            lvlup = true;
            nextlvl += nextlvl + 1 + 1;
            }
        }
    }
    public void RozdawaniepuktowZrecznosc()
    {
        if (Dostepnepukty > 0)
        {
            zrecznosc++;
            Dostepnepukty -= 1;
            wzrostzrecznosc = true;
            unikpraca.zrecznoscdouniku++;
        }
    }    
    public void RozdawaniepuktowWitalnosc()
    {
        if (Dostepnepukty > 0)
        {
            witalnosc++;
            Dostepnepukty -= 1;
            wzrostwitalnosc = true;
        }
    }
    public void RozdawaniepuktowSi³a()
    {
        if (Dostepnepukty > 0)
        {
            sila++;
            Dostepnepukty -= 1;
            wzorstsi³y = true;
        }
    }
    void Jakdzia³aZrecznosc()
    {
        if(wzrostzrecznosc)
        {
            wzrostzrecznosc = false;
        }
    }
    void JakDzia³aWitalnosc()
    {
        if(wzrostwitalnosc)
        {
            pz += randomowyprzyrostwitalnosc;
            wzrostwitalnosc = false;
        }
    }

    void JakDzia³¹Si³a()
    {

        if (wzorstsi³y)
        {
            DmgMini += 3;
            DmgMax += 3;
            wzorstsi³y = false;
        }
    }
  
    void LvlUpWzrostStatystyk() 
    {
        if (lvlup)
        {
            pz += randomowyprzyrostlvl;
            lvlup = false;
        }
    }
    void Radomowka()
    {
        randomowyprzyrostwitalnosc = Random.Range(5, 12);
         randomowyprzyrostlvl = Random.Range(30, 100);
    }

    void WyswietlanieStat()
    {
       Obra¿eniaMini.text = DmgMini.ToString();
       Obra¿eniaMax.text = DmgMax.ToString();
       WyswietlanieSila1.text = sila.ToString();
       WyswietlanieWitalnosc.text = witalnosc.ToString();
       WyswietlanieZrecznosc.text = zrecznosc.ToString();
       WyswietlanieZycie.text =  pz.ToString();
    }
   
    
    void Blokadaexpa()
    {
        if (Lvl >= 50)
        {
            maxlvl = false;
        }
    }
}
