using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private swort swort1 = new swort();
    private Potion potion1 = new Potion();

    private ejercicio2cofre cofre = new ejercicio2cofre();
    private ejercicio2puerta puerta = new ejercicio2puerta();

    private Bersek bersek1 = new Bersek();
    private Arquero Arquero1 = new Arquero();

    private void Start()
    {
        swort1.inventario("escalibur", 3 , 34 , 585);
        swort1.Cast();

        potion1.inventario("elixir", 1, 23, 300);
        potion1.Cast();

        cofre.Interactuar();
        puerta.Interactuar();

        bersek1.personaje();
        Arquero1.personaje();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
