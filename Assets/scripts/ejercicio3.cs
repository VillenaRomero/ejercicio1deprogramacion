using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ejercicio3ClasePersonaje : MonoBehaviour
{
    private string name;
    private int life;
    public void personaje() {
        print("elige habilidad o activa tu habilidad");
    }
    public abstract void HabilidadEspecial();
}
public class Bersek : ejercicio3ClasePersonaje {
    public override void HabilidadEspecial() {
        print(" Bersek ataka ferozmente el campo ");
    }
    private void Start()
    {
        personaje();
    }
}
public class Arquero : ejercicio3ClasePersonaje {
    public override void HabilidadEspecial()
    {
        print(" el arquero lanza varias flechas");
    }
    private void Start()
    {
        personaje();
    }
}