using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoesGeneration : MonoBehaviour
{

    public IEnumerator coroutine;
    public int i = 0;
    public GameObject particlePrefab1;
    public GameObject particlePrefab2;
    public GameObject particlePrefab3;
    public GameObject particlePrefab4;
    public GameObject particlePrefab5;

    bool alreadyCollided = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (alreadyCollided)
        {
            while (i == 0)
            {
                coroutine = GenerateDomino(0.2f);
                i = 1;
                StartCoroutine(coroutine);
                i = 1;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //TODO Check if the collision object has a tag of "Ball", if so then set the boolean isColliding to true
        if (collision.gameObject.CompareTag("Ball"))
        {
            alreadyCollided = true;
        }
    }

    IEnumerator GenerateDomino(float tie)
    {
        /*        Debug.Log("abc");
                for (i = 1; i < 6; i++)
                {
                    particlePrefab.transform.position = new Vector3(7.54f, -8.28f, 8.25f - (1.2f * i));
                    Instantiate(particlePrefab );//, particlePrefab.transform.position, Quaternion.identity);
        *//*            if(i==0)
                    {
                        Destroy(particlePrefab);
                    }
        *//*            count = count + 1;
                    yield return new WaitForSeconds(0.5f);//WaitForSeconds(0.5f);
                    //particlePrefab.constraints = RigidbodyConstraints.None;
                }
        */
        i = 1;
        particlePrefab1.transform.position = new Vector3(7.54f, -6.28f, 11.0f);
        Instantiate(particlePrefab1);//, particlePrefab.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.5f);//WaitForSeconds(0.5f);
        Debug.Log("1");
        particlePrefab2.transform.position = new Vector3(7.54f, -6.28f, 9.5f);
        Instantiate(particlePrefab2);//, particlePrefab.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.5f);//WaitForSeconds(0.5f);
        Debug.Log("2");

        particlePrefab3.transform.position = new Vector3(7.54f, -6.28f, 8.0f);
        Instantiate(particlePrefab3);//, particlePrefab.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.5f);//WaitForSeconds(0.5f);
        Debug.Log("3");

        particlePrefab4.transform.position = new Vector3(7.54f, -6.28f, 6.50f);
        Instantiate(particlePrefab4);//, particlePrefab.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.5f);//WaitForSeconds(0.5f);
        Debug.Log("4");

        particlePrefab5.transform.position = new Vector3(7.54f, -6.28f, 5.0f);
        Instantiate(particlePrefab5);//, particlePrefab.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(0.5f);//WaitForSeconds(0.5f);
        Debug.Log("5");
        i = 1;

    }
}
