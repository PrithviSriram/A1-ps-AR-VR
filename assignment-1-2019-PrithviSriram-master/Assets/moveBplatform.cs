using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBplatform : MonoBehaviour
{
    public Camera cam;
    private IEnumerator coroutine;
    float movementSmooth = 0.1f;
//    public GameObject plat;
    Vector3 currentpos = new Vector3(7.5f, -9.0f, -13.0f);
    Vector3 finalpos = new Vector3(7.5f, -9.0f, 13.0f);
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
                StartCoroutine(Translate(hitInfo));
        }
    }
    IEnumerator Translate(RaycastHit hit)
    {
        if (hit.collider.name == "PointBPlatform" | hit.collider.name == "PointBWall1" | hit.collider.name == "PointBWall2" | hit.collider.name == "PointBWall3")
        {
            while (true)
            {
                transform.position = Vector3.Lerp(currentpos, finalpos, Time.deltaTime * movementSmooth);
                currentpos = transform.position;
                if (transform.position.z >= 12.5)
                {
                    break;
                }
                yield return null;
            }
            yield return new WaitForSeconds(1.0f);
            while (true)
            {
                currentpos = transform.position;
                transform.position = Vector3.Lerp(currentpos, new Vector3(7.5f, -9.0f, -13.0f), Time.deltaTime * movementSmooth*100);
                currentpos = transform.position;
                if (transform.position.z <= -12.5)
                {
                    break;
                }
                yield return null;
            }

            yield return new WaitForSeconds(1.0f);
        }
    }
}
