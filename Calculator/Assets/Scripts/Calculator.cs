using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class Calculator : MonoBehaviour
{
    public Text txt;
    public List<string> workArray;
    string a;
    int e = 0;
    public void odin()
    {
        a += "1";
        txt.text = a;
    }

    public void dva()
    {
        a += "2";
        txt.text = a;
    }
    public void tri()
    {
        a += "3";
        txt.text = a;
    }
    public void chiteri()
    {
        a += "4";
        txt.text = a;
    }
    public void pyt()
    {
        a += "5";
        txt.text = a;
    }
    public void Schesty()
    {
        a += "6";
        txt.text = a;
    }
    public void sewenn()
    {
        a += "7";
        txt.text = a;
    }
    public void vosem()
    {
        a += "8";
        txt.text = a;
    }
    public void nine()
    {
        a += "9";
        txt.text = a;
    }
    public void nul()
    {
        a += "0";
        txt.text = a;

    }
    public void plus()
    {
        e++;
        workArray.Add(a);
        a = "";
    }
    public void minus()
    {
        e++;
        e++;
        workArray.Add(a);
        a = "";
    }
    public void umnocenie()
    {
        e++;
        e++;
        e++;
        workArray.Add(a);
        a = "";
    }
    public void delenie()
    {
        e++;
        e++;
        e++;
        e++;
        workArray.Add(a);
        a = "";
    }
    public void cleear()
    {
        a = "";

        txt.text = a;
        workArray.Add(a);
    }
    public void rawno()
    {
        workArray.Add(a);
        if (e == 1)
        {
            int b = int.Parse(workArray[^2]) + int.Parse(workArray[^1]);
            txt.text = b.ToString();
            e = 0;
        }
        else
        {
            if (e == 2)
            {
                int b = int.Parse(workArray[^2]) - int.Parse(workArray[^1]);
                txt.text = b.ToString();
                e = 0;
            }
            else
            {
                if (e == 3)
                {
                    int b = int.Parse(workArray[^2]) * int.Parse(workArray[^1]);
                    txt.text = b.ToString();
                    e = 0;
                }
                else
                {
                    if (e == 4)
                    {
                        int b = int.Parse(workArray[^2]) / int.Parse(workArray[^1]);
                        txt.text = b.ToString();
                        e = 0;
                    }
                }
            }
        }
    }
}