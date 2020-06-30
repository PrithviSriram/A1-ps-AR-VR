using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateBridge : MonoBehaviour
{
    public Camera cam;
    public GameObject bridge;
    private IEnumerator coroutine;
    float movementSmooth = 10.0f;
    void Start()
    {
        cam = Camera.main;

        //TODO Use the pos.y of this transform and assign it to the targetYPos
        //targetYPos = referenceTransform.transform.position.y;//-2.064308f;
        //Invoke("rotateback", 30.0f);
    }
    
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            //Debug.Log("Pressed left click.");
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
                StartCoroutine(Rotate(hitInfo));
        }
    }
/*    void rotateback()
    {
        bridge.transform.rotation = Quaternion.Euler(0, -45.0f, 0);
    }*/
    IEnumerator Rotate(RaycastHit hit)
    {
        //TODO calculate a taget position for this very elevator, and move it to the target position 
        //referenceTransform.position.y = targetYPos;
        //Vector3 finpos = new Vector3(thisElevator.transform.position.x, targetYPos, thisElevator.transform.position.z);
        //thisElevator.transform.position = Vector3.Lerp(thisElevator.transform.position, finpos, Time.deltaTime * movementSmooth * 5.0f);
        Quaternion wantedRotation = Quaternion.Euler(0, 90, -10);
        Quaternion currentRotation = hit.transform.rotation;
        if (hit.collider.name == "Bridge" | hit.collider.name == "BridgeWall1" | hit.collider.name == "BridgeWall2")
        {
            while(true)
            {
                hit.transform.rotation = Quaternion.RotateTowards(currentRotation, wantedRotation, Time.deltaTime * movementSmooth);
                currentRotation = hit.transform.rotation;
                //Debug.Log(hit.transform.rotation.y);
                if (hit.transform.rotation.y >=0.7044)
                {
                    //Debug.Log("yay");
                    break; 
                }
                yield return null;
            }
            yield return new WaitForSeconds(20.0f);
            while (true)
            {
                currentRotation = hit.transform.rotation;
                hit.transform.rotation = Quaternion.RotateTowards(currentRotation, Quaternion.Euler(0, 0, 0),Time.deltaTime * movementSmooth*10);
                if (hit.transform.rotation.y < 0.01)
                {
                    break;
                }
                yield return null;
            }
            yield return new WaitForSeconds(1.0f);

        }
    }
}
