using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipScript : MonoBehaviour
{
    public int force;
    public int forceTorpedo; 
    Rigidbody2D myRB;
    public GameObject torpedo;
    bool disparo = true;


    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float movement = Input.GetAxis("Horizontal");

        myRB.velocity = transform.right * movement * force;

        float xPos = Mathf.Clamp(myRB.position.x, -6.66f, 6.66f);

        myRB.position = new Vector2(xPos, myRB.position.y);

        if (Input.GetButton("Jump") && disparo)
        {
            Vector2 posTorpedo = new Vector2(transform.position.x, transform.position.y + 1.278f);
            GameObject clone = Instantiate(torpedo, posTorpedo, Quaternion.identity);

            Rigidbody2D cloneRB = clone.GetComponent<Rigidbody2D>();

            Vector2 direccion = new Vector2(0f, 1f);

            cloneRB.velocity = direccion * forceTorpedo;

            disparo = false;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("NAVE: Collision");
    }

    public void SetDisparar()
    {
        disparo = true;
    }
}
