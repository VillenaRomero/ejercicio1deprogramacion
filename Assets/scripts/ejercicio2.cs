using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public interface IInteractuable {
    void Interactuar();
}
public class ejercicio2cofre : MonoBehaviour, IInteractuable
{
    public void Interactuar() {
        print("Has Abierto el cofre");
    }
}

public class ejercicio2puerta : MonoBehaviour, IInteractuable {
    public void Interactuar() {
        print("Has Abierto la puerta ");
    }
}
