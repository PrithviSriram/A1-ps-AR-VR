using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateplatformA : MonoBehaviour
{
    //[SerializeField]
    //float movementSmooth = 45f;
    public Camera cam;
    public GameObject platform;

    void Start()
    {
        cam = Camera.main;

        //TODO Use the pos.y of this transform and assign it to the targetYPos
        //targetYPos = referenceTransform.transform.position.y;//-2.064308f;
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            //Debug.Log("Pressed left click.");
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
                Rotate(hitInfo);
        }
    }
    void Rotate(RaycastHit hit)
    {
        //TODO calculate a taget position for this very elevator, and move it to the target position 
        //referenceTransform.position.y = targetYPos;
        //Vector3 finpos = new Vector3(thisElevator.transform.position.x, targetYPos, thisElevator.transform.position.z);
        //thisElevator.transform.position = Vector3.Lerp(thisElevator.transform.position, finpos, Time.deltaTime * movementSmooth * 5.0f);
        if(hit.collider.name == "PointAPlatform" | hit.collider.name == "PointCWall1" | hit.collider.name == "PointCWall2" | hit.collider.name == "PointCWall3")
        {
            platform.transform.Rotate(10, 0, 0);
        }
    }
}
