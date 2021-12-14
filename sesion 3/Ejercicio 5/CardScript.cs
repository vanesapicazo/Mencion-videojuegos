using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    SpriteRenderer myRenderer;
    public Sprite front;
    public Sprite back;

    bool faceUp = false;

    GameObject myGameManager;

    public int numero;

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<SpriteRenderer>();
        myGameManager = GameObject.FindGameObjectWithTag("GameController");
    }

    private void OnMouseDown()
    {
        myGameManager.GetComponent<GameManagerScript>().ClickOnCard(numero);

        if (!faceUp)
        {
            myRenderer.sprite = front;
        }
        else
        {
            myRenderer.sprite = back;
        }

        faceUp = !faceUp;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
