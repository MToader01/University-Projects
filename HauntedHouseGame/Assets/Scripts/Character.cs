using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character 
{
    public string name;
    public int exp;

    public Character (string name)
    {
        this.name = name;   
    }

    public Character(string name, int exp)
    {
        this.name = name;
        this.exp = exp;
    }


    public void PrintStatInfo()
    {
        Debug.LogFormat("My hero name is:{0} and his exp points are {1}", this.name, this.exp);
    }
}
