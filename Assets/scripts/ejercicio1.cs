using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio1Inventario : MonoBehaviour
{
    private string nameobject;
    private int peso;
    private int level;
    private int curationodamage;

    public void inventario(string nameobject, int peso , int level, int curationodamage) { 
         this.nameobject=nameobject;
         this.peso=peso;
         this.level=level;
        this.curationodamage=curationodamage;
    }
    public virtual void Cast()
    {
        print("cast basico");
    }
    public virtual void Cancell()
    {

    }
}
public class swort : ejercicio1Inventario {
    public override void Cast()
    {
        print("Atacastes con la espada");
    }
    private void Start()
    {
        Cast();
    }
}
public class Potion : ejercicio1Inventario {
    public override void Cast()
    {
        base.Cast();

        print(" Te tomastes la pocion y te curastes ");
    }
    private void Start()
    {
        Cast();
    }
}
