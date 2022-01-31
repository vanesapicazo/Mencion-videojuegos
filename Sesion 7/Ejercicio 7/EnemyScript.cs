using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    bool move = true;
    float sleep = 0.8f;
    bool jugando = true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(sleep);

        if (jugando)
        {
            MoveEnemy();
        }

        StartCoroutine(Wait());
    }

    private void MoveEnemy()
    {
        if (move == true)
        {

            if(transform.position.x > 5)
            {
                
                move = false;
                sleep -= 0.05f;
                transform.Translate(Vector2.down);
            }
            else
            {
                transform.Translate(Vector2.right);
            }
        }
        else
        {

            if(transform.position.x < -5)
            {
                move = true;
                sleep -= 0.05f;
                transform.Translate(Vector2.down);
            }
            else
            {
                transform.Translate(Vector2.left);
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "bala")
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Nave")
        {
            jugando = false;
        }
        
    }
}
