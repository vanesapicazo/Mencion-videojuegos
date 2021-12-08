using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript: MonoBehaviour
{
    public GameObject myPrefab;
    public List<GameObject> cartas = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 6; i++)
        {
            GameObject nueva_carta = Instantiate(myPrefab, new Vector3((-12 + i * 4), 3, 0), Quaternion.identity);

            nueva_carta.name = ("Carta" + i);

            cartas.Add(nueva_carta);
        }

        for(int i = 1; i < 6; i++)
        {
            GameObject nueva_carta = Instantiate(myPrefab, new Vector3((-12 + i * 4), -3, 0), Quaternion.identity);

            nueva_carta.name = ("Carta" + (i + 5));

            cartas.Add(nueva_carta);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
