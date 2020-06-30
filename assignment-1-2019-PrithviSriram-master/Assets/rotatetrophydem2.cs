using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatetrophydem2 : MonoBehaviour
{
    public GameObject trophy;

    bool alreadyCollided = false;

    public float movementSmooth = -20f;


    void Start()
    {
    }

    void Update()
    {
        trophy.transform.Rotate(movementSmooth * Time.deltaTime, movementSmooth * Time.deltaTime, movementSmooth * Time.deltaTime, Space.Self);
    }
}
