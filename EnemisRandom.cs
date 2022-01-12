using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemisRandom : MonoBehaviour
{
    public StatsPlayer player;
    public UnikWork unik;
    int[] przeciwnikEz;
 
    int RandomZycie;
    int RandomSi³a;
    int RandomWitalnosc;
    int RandomZrecznosc;
    int RandomMaxDmg;
    int RandomMinDmg;

    int ZrecznoscPrzeciwnika;
    int ZyciePrzeciwnika;
    int SilaPrzeciwnika;
    int WitalnoscPrzeciwnika;
    int MaxDmgPrzeciwnika;
    int MinDmgPrzeciwnika;

    private void Start()
    {
        
    }
    private void Update()
    {
        przeciwnikEz = new int[] 
        {ZyciePrzeciwnika,WitalnoscPrzeciwnika,SilaPrzeciwnika,ZrecznoscPrzeciwnika,MinDmgPrzeciwnika,MaxDmgPrzeciwnika};
        print(MinDmgPrzeciwnika);
        print(MaxDmgPrzeciwnika);
        print(ZrecznoscPrzeciwnika);
        print(ZyciePrzeciwnika);
        print(SilaPrzeciwnika);
        print(WitalnoscPrzeciwnika);
       
        ObliczanieWartosci();
        LosowanieWartosci();

    }

    void ObliczanieWartosci()
    {
        MinDmgPrzeciwnika = RandomMinDmg + player.DmgMini;
        MaxDmgPrzeciwnika = RandomMaxDmg + player.DmgMax;
        ZrecznoscPrzeciwnika = RandomZrecznosc + player.zrecznosc;
        WitalnoscPrzeciwnika = RandomWitalnosc + player.witalnosc;
        ZyciePrzeciwnika = RandomZycie + player.pz;
        SilaPrzeciwnika = RandomSi³a + player.sila;
    }
    void LosowanieWartosci()
    {
        RandomMaxDmg = Random.Range(-22, 50);
        RandomMinDmg = Random.Range(-9, 20);
        RandomZrecznosc = Random.Range(3, 5);
        RandomWitalnosc = Random.Range(1,30);
        RandomZycie = Random.Range(-100, 100);
        RandomSi³a = Random.Range(1, 20);     
    }

}

