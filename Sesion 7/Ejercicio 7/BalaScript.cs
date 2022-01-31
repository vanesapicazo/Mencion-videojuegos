using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaScript : MonoBehaviour
{

    GameObject spaceShip;
    SpaceShipScript scriptNave;

    // Start is called before the first frame update
    void Start()
    {
        spaceShip = GameObject.FindGameObjectWithTag("Nave");
        scriptNave = spaceShip.GetComponent<SpaceShipScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        scriptNave.SetDisparar();
        Destroy(gameObject);

        if(collision.gameObject.tag == "enemy")
        {
            scriptNave.end();
        }
    }

}