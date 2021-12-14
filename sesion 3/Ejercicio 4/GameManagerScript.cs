using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript: MonoBehaviour
{
    public GameObject myPrefab;
    public List<GameObject> cartas = new List<GameObject>();

    public List<Sprite> faces;

    int[] contador = { 0, 0, 0, 0, 0 };

    // Start is called before the first frame update
    void Start()
    {
        float posX = -8;
        float posY = 3;

        GameObject nueva_carta;

        for(int i = 0; i < 10; i++)
        {
            nueva_carta = Instantiate(myPrefab, new Vector3(posX, posY, 0), Quaternion.identity);
            nueva_carta.name = "card" + i;

            bool encontrado = false;
            int pos = 0;

            while (!encontrado)
            {
                pos = Random.Range(0, 5);

                if(contador[pos] < 2)
                {
                    contador[pos] += 1;
                    encontrado = true;
                }
            }

             
            nueva_carta.GetComponent<CardScript>().front = faces[pos];

            cartas.Add(nueva_carta);

            posX = posX + 3;

            if(i == 4)
            {
                posX = -8;
                posY = -2;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
