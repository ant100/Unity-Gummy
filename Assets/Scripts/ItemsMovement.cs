using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);

        if(transform.position.y <= -12f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // check if it collides with the player
        if(collision.CompareTag("Player"))
        {
            // destroy element 
            Destroy(gameObject);

            // add score
            gameObject.GetComponent<ScoreManager>().addPoints();

            // update bar
            GameObject.Find("Score Bar").GetComponent<ScoreBarRenderer>().DrawScoreBar();
        }

    }
}
