using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateC : MonoBehaviour
{
    public Camera cam;
    //public GameObject platd;
    public GameObject platc;
    //public GameObject bridge;
    private IEnumerator coroutine;
    //public Vector3 cursize = new Vector3(1f,0.5f,1f);
    //public Vector3 finalsize = new Vector3(5f,0.5f,5f);
    float sizeUp = 5.0f;
    float movementSmooth = 10.0f;  
    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                //                Rotate(hitInfo);
                /*if (hitInfo.collider.name == "PointCPlatform" | hitInfo.collider.name == "PointCWall11" | hitInfo.collider.name == "PointCWall21" | hitInfo.collider.name == "PointCWall31")
                {
                    Debug.Log("a");
                    bridge.transform.Rotate(0, -90, 0);
                    Debug.Log("b");

                }*/
                StartCoroutine(sizeup_Rot(hitInfo));
                //Debug.Log("c");
            }
        }
    }
 /*   void Rotate(RaycastHit hit)
    {
        if (hit.collider.name == "PointCPlatform" | hit.collider.name == "PointCWall1" | hit.collider.name == "PointCWall2" | hit.collider.name == "PointCWall3")
        {
            transform.Rotate(10, 0, 0);
        }
    }
 */
    IEnumerator sizeup_Rot(RaycastHit hit)
    {
        Quaternion wantedRotation = Quaternion.Euler(10, -180, 0);
        Quaternion currentRotation = hit.transform.rotation;

        if (hit.collider.name == "PointCPlatform" | hit.collider.name == "PointCWall11" | hit.collider.name == "PointCWall21" | hit.collider.name == "PointCWall31")
        {
            while (true)
            {
                //platd.transform.localScale = Vector3.Lerp(cursize, finalsize, Time.deltaTime * sizeUp);
                //cursize = platd.transform.localScale;
                platc.transform.rotation = Quaternion.RotateTowards(currentRotation, wantedRotation, Time.deltaTime * movementSmooth*10);

                //Debug.Log(platc.transform.rotation.x);
                if (platc.transform.rotation.x < -7.27E-10)// & platd.transform.localScale.z >= 4.7)
                {
                    break;
                }
                yield return null;
            }
            yield return new WaitForSeconds(1.0f);
        }
    }
}
