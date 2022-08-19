/* Ashley Maynez
 * Test1
 * 12/4/19
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider old)
    {
        if (old.gameObject.CompareTag("Asteroid"))
        {     
            Destroy(old.gameObject);
        }
    }
}
