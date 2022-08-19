/* Ashley Maynez
 * Test1
 * 12/4/19
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float degreesPerSec = 160f;
    public Rigidbody bullet;
    public Text gameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            float rotAmount = degreesPerSec * Time.deltaTime;
            float curRot = transform.localRotation.eulerAngles.z;
            transform.localRotation = Quaternion.Euler(new Vector3(0, 0, curRot + rotAmount));
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            float rotAmount = degreesPerSec * Time.deltaTime;
            rotAmount *= -1;
            float curRot = transform.localRotation.eulerAngles.z;
            transform.localRotation = Quaternion.Euler(new Vector3(0, 0, curRot + rotAmount));
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody bullet2 = (Rigidbody)Instantiate(bullet, (transform.position + transform.up * 2), bullet.rotation);
            Shooting(bullet2);
        }


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Asteroid"))
        {
            gameOver.text = "GAMEOVER";
            gameObject.SetActive(false);
        }
    }

    void Shooting(Rigidbody bullet)
    {
        bullet.velocity = transform.TransformDirection(Vector3.up * 10);
    }
}
