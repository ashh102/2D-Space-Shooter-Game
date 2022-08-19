/* Ashley Maynez
 * Test1
 * 12/4/19
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AsteroidScript : MonoBehaviour
{
    public GameObject asteroid;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnNext", 1.0f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(0f, 0f, 0f), 1.0f * Time.deltaTime);
    }

    void SpawnNext()
    {
        int random = Random.Range(0, 3);
        Vector3 spawnPoint = Camera.main.ViewportToWorldPoint(new Vector3(1, Random.Range(0.0f, 1.0f), 10));

        if (random == 0)
        {
            spawnPoint = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(0.0f, 1.0f), 1, 10));
        }

        if (random == 1)
        {
            spawnPoint = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(0.0f, 1.0f), 0, 10));
        }

        if (random == 2)
        {
            spawnPoint = Camera.main.ViewportToWorldPoint(new Vector3(0, Random.Range(0.0f, 1.0f), 10));
        }

        if (random == 3)
        {
            spawnPoint = Camera.main.ViewportToWorldPoint(new Vector3(1, Random.Range(0.0f, 1.0f), 10));
        }

        GameObject nextAsteroid;
        nextAsteroid = (GameObject)Instantiate(asteroid, spawnPoint, Quaternion.identity);
    }
}
