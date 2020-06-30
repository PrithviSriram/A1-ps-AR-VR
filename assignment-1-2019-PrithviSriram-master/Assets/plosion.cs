using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plosion : MonoBehaviour
{
    public GameObject originalObject;
    public GameObject particlePrefab;
    bool alreadyExploded;
    public int particleCount;
    public float particleMinSize, particleMaxSize;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (originalObject.activeInHierarchy == false && alreadyExploded == false)
        {
            Exploding();
            alreadyExploded = true;
        }
    }

    void Exploding()
    {
        for (int i = 0; i < particleCount; i++)
        {
            Instantiate(particlePrefab, originalObject.transform.position, Quaternion.identity);
            particlePrefab.transform.localScale = originalObject.transform.localScale * Random.Range(particleMinSize, particleMaxSize);
        }
    }
}
