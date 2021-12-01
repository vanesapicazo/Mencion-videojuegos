using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    List<string> nombres = new List<string>();
    List<string> categories = new List<string>();


    // Start is called before the first frame update
    void Start()
    {
        InitFighters();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitFighters()
    {
        GameObject[] personajes = GameObject.FindGameObjectsWithTag("Fighter");


        nombres.Add("Scorpion");
        nombres.Add("Kano");
        nombres.Add("Sonya");
        nombres.Add("Johnny Cage");
        nombres.Add("Sub-Zero");

        categories.Add("Ninja");
        categories.Add("Mercenario");
        categories.Add("Teniente");
        categories.Add("Actor");

        int salud = 100;

        Fighter Scorpion = personajes[0].GetComponent<Fighter>();
        Fighter Kano = personajes[1].GetComponent<Fighter>();
        Fighter Sonya = personajes[2].GetComponent<Fighter>();
        Fighter JohnnyCage = personajes[3].GetComponent<Fighter>();
        Fighter SubZero = personajes[4].GetComponent<Fighter>();

        Scorpion.GetComponent<Fighter>().nombre = nombres[0];
        Kano.nombre = nombres[1];
        Sonya.nombre = nombres[2];
        JohnnyCage.nombre = nombres[3];
        SubZero.nombre = nombres[4];

        Scorpion.category = categories[0];
        Kano.category = categories[1];
        Sonya.category = categories[2];
        JohnnyCage.category = categories[3];
        SubZero.category = categories[4];

        Scorpion.health = salud;
        Kano.health = salud;
        Sonya.health = salud;
        JohnnyCage.health = salud;
        SubZero.health = salud;


        Debug.Log("Nombre del luchador: " + Scorpion.nombre);
        Debug.Log(" Categoría del luchador: " + Scorpion.category);
        Debug.Log(" Salud del luchador: " + Scorpion.health + " PS");

        Debug.Log("Nombre del luchador: " + Kano.nombre);
        Debug.Log(" Categoría del luchador: " + Kano.category);
        Debug.Log(" Salud del luchador: " + Kano.health + " PS");

        Debug.Log("Nombre del luchador: " + Sonya.nombre);
        Debug.Log(" Categoría del luchador: " + Sonya.category);
        Debug.Log(" Salud del luchador: " + Sonya.health + " PS");

        Debug.Log("Nombre del luchador: " + JohnnyCage.nombre);
        Debug.Log(" Categoría del luchador: " + JohnnyCage.category);
        Debug.Log(" Salud del luchador: " + JohnnyCage.health + " PS");

        Debug.Log("Nombre del luchador: " + SubZero.nombre);
        Debug.Log(" Categoría del luchador: " + SubZero.category);
        Debug.Log(" Salud del luchador: " + SubZero.health + " PS");


        
    }
}
