using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveball : MonoBehaviour
{
    public GameObject todes;
    void Start()
    {
        Destroy(todes, 1.0f);
    }
    void Update()
    {
        if (transform.position.y < -30.0)
            SceneManager.LoadScene("Demo_2");
    }
    /*    // Start is called before the first frame update
        public Rigidbody rb;
    //    public Rigidbody cube;
        void Start()
        {
            rb = GetComponent<Rigidbody>();
    //        cube = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {

        }
        private void OnCollisionEnter(Collision collision)
        {
            //TODO Check if the collision object has a tag of "Ball", if so then set the boolean isColliding to true
            if (collision.gameObject.CompareTag("Player"))
            {
                Debug.Log("yes");
                rb.useGravity = true;
                //Destroy(cube);
            }
        }
    */
}
