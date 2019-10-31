using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] items = null;
    [SerializeField]
    private float startTime = 3f;
    [SerializeField]
    private float spawningTime = 2f;
    private Vector2 position;
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        index = 0;
        reshuffle(items);
        InvokeRepeating("SpawnObject", startTime, spawningTime);
    }

    void SpawnObject()
    {
        if(index < items.Length)
        {
            // Instantiate object at a random position between edges
            position = new Vector2(Random.Range(-7.5f, 7.5f), transform.position.y);
            var item = Instantiate(items[index], position, Quaternion.identity);
            item.transform.parent = this.transform;
            index++;
        }
        else
        {
            // Out of clothes, end level
            if (GameManager.gm)
                GameManager.gm.LevelComplete();
        }
    }

    void reshuffle(GameObject[] items)
    {
        // Knuth shuffle algorithm
        for (int t = 0; t < items.Length; t++)
        {
            GameObject tmp = items[t];
            int r = Random.Range(t, items.Length);
            items[t] = items[r];
            items[r] = tmp;
        }
    }
}
