using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platdChange : MonoBehaviour
{
    public Camera cam;
    //public GameObject platd;
    private IEnumerator coroutine;
    public Vector3 cursize = new Vector3(1.0f, 0.5f, 1.0f);
    public Vector3 intermediatesize = new Vector3(5.0f, 0.5f, 5.0f);
    public Vector3 finalsize = new Vector3(1.0f, 0.5f, 1.0f);
    public Vector3 finalpos = new Vector3(7.5f, 4.4f, 7.65f);
    public Vector3 curpos;
    float sizedown = 5.0f;
    //float movementSmooth = 0.5f;
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
                StartCoroutine(sizedown_goup(hitInfo));
            }
        }
    }
    IEnumerator sizedown_goup(RaycastHit hit)
    {
        if (hit.collider.name == "PointDPlatform" | hit.collider.name == "PointDWall1" | hit.collider.name == "PointDWall2" | hit.collider.name == "PointDWall3" | hit.collider.name == "PointDWall4")
        {
            //            cursize = platd.transform.localScale;
            //            curpos = platd.transform.position;
            cursize = transform.localScale;
            curpos = transform.position;

            while (true)
            {
                //platd.transform.localScale = Vector3.Lerp(cursize, finalsize, Time.deltaTime * sizedown);
                transform.localScale = Vector3.Lerp(cursize, intermediatesize, Time.deltaTime * sizedown);
                //cursize = platd.transform.localScale;
                cursize = transform.localScale;
                Debug.Log(cursize);
                if (transform.localScale.z >= 5.0)//if (platd.transform.localScale.z <= 1.2)
                {
                    break;
                }
                yield return null;
            }
            yield return new WaitForSeconds(4.0f);
            while (true)
            {
                cursize = transform.localScale;
                //platd.transform.localScale = Vector3.Lerp(cursize, finalsize, Time.deltaTime * sizedown);
                transform.localScale = Vector3.Lerp(cursize, finalsize, Time.deltaTime * sizedown);
                //cursize = platd.transform.localScale;
                cursize = transform.localScale;
                Debug.Log(transform.localScale);
                if (transform.localScale.z >= 5.0)//if (platd.transform.localScale.z <= 1.2)
                {
                    break;
                }
                yield return null;
            }
            yield return new WaitForSeconds(1.0f);
            while (true)
            {
/*                platd.transform.position = Vector3.Lerp(curpos, finalpos, Time.deltaTime * movementSmooth);
                curpos = platd.transform.position;
                if (platd.transform.position.y > 4.3)
*/              
                transform.position = Vector3.Lerp(curpos, finalpos, Time.deltaTime * sizedown/10);
                curpos = transform.position;
                if (transform.position.y > 4.3)

                {
                    break;
                }
                yield return null;
            }
            yield return new WaitForSeconds(1.0f);
        }
    }
}
