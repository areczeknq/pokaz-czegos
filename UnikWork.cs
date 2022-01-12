using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnikWork : MonoBehaviour
{
    public StatsPlayer player;
    internal int zrecznoscdouniku;
    internal int unik;
    internal int procennatrafienie;
    [SerializeField] Text unik1;
    private bool wzrostuniku = false;
    private bool trafienie = false;


    private void Update()
    {
        unik1.text = unik.ToString();
        Dzialanieuniku();
        procennatrafienie = Random.Range(1, 100);
        Procentnatrafienie();//przypisac potem do walki zamiast update po ruchu


    }
    void Dzialanieuniku()
    {
        if (zrecznoscdouniku ==5)
        {      
           unik++; 
           zrecznoscdouniku -= 5;
           
        }
    }
   
    void Procentnatrafienie()
    {
        if(procennatrafienie == unik)
        {
            trafienie = true;
        }
        else if (procennatrafienie <= unik)
        {
            trafienie = true;
        }
        
    }
}
