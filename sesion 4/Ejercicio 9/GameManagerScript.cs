using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript: MonoBehaviour
{
    public GameObject myPrefab;
    public GameObject texto;
    public List<GameObject> cartas = new List<GameObject>();

    public List<Sprite> faces;

    int[] contador = { 0, 0, 0, 0, 0 };
    int[] numeros = { 7, 1, 0, 9, 6 };

    int state = 1;
    int cardUp;
    int cardUpIndex;

    int numParejas = 0;

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
            nueva_carta.GetComponent<CardScript>().numero = numeros[pos];
            nueva_carta.GetComponent<CardScript>().index = i;

            cartas.Add(nueva_carta);

            posX = posX + 3;

            if(i == 4)
            {
                posX = -8;
                posY = -2;
            }
        }


        
    }

    public void ClickOnCard(int n, int index)
    {
        Debug.Log("He hecho click en la carta " + n);

        if(state == 1)
        {
            cardUp = n;
            cardUpIndex = index;
            state = 2;
        }
        else
        {
            if(n == cardUp)
            {
                Debug.Log("¡Has hecho una pareja!");
                cartas[index].SetActive(false);
                cartas[cardUpIndex].SetActive(false);

                numParejas++;
                texto.GetComponent<Text>().text = "Número de parejas: " + numParejas;
            }
            else
            {
                Debug.Log("No has hecho pareja");
                StartCoroutine(WaitAndPrint());
                cartas[index].GetComponent<CardScript>().Toggle();
                cartas[cardUpIndex].GetComponent<CardScript>().Toggle();
            }

            state = 1;

        }
    }


    IEnumerator WaitAndPrint()
    {
        Debug.Log("Antes de waitforseconds");
        yield return new WaitForSeconds(3);
        Debug.Log("Después de waitforseconds");
    }



    // Update is called once per frame
    void Update()
    {

    }
}
