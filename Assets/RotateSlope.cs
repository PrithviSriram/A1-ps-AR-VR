using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSlope : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Slope;

    bool alreadyCollided = false;

    [SerializeField]
    float movementSmooth = 45f;


    void Start()
    {
        //TODO Use the pos.y of this transform and assign it to the targetYPos
        //targetYPos = referenceTransform.transform.position.y;//-2.064308f;
    }

    void Update()
    {
        if (alreadyCollided)
        {
            Rotate(Slope);
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

    void Rotate(GameObject Slope)
    {
        //TODO calculate a taget position for this very elevator, and move it to the target position 
        //referenceTransform.position.y = targetYPos;
        //Vector3 finpos = new Vector3(thisElevator.transform.position.x, targetYPos, thisElevator.transform.position.z);
        //thisElevator.transform.position = Vector3.Lerp(thisElevator.transform.position, finpos, Time.deltaTime * movementSmooth * 5.0f);
        Quaternion currentRotation = Slope.transform.rotation;
        Quaternion wantedRotation = Quaternion.Euler(0, 0, -45);
        Slope.transform.rotation = Quaternion.RotateTowards(currentRotation, wantedRotation, Time.deltaTime * movementSmooth);


    }
}
