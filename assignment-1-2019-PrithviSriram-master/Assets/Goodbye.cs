using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goodbye : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("loadscene",4.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        //TODO Check if the collision object has a tag of "Ball", if so then set the boolean isColliding to true
        if (collision.gameObject.CompareTag("dominoway"))
        {
           Invoke("loadscene", 4.0f);
        }
    }
void loadscene()
    {
        SceneManager.LoadScene("Demo_2");
    }
}
