using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeUpAnimation : MonoBehaviour
{
    //public Vector3 startVelocity;
    public Rigidbody rb;
    //public GameObject Domino;
    //public GameObject target_size;
    public float sizeUp;
    Vector3 final = new Vector3(2.0f, 3.5f, 0.2f);
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.velocity = startVelocity;
        //rb
        ////        rb.constraints = RigidbodyConstraints.FreezeRotation;
        //rb.transform.localScale = Vector3.Lerp(Vector3.zero, final, Time.deltaTime * sizeUp);
        ////        Invoke("ExecuteAfterTime", 0.2f);
        //Destroy(Domino);

    }
    ////    IEnumerator ExecuteAfterTime(float time)
    ////    {
    ////        yield return new WaitForSeconds(time);
    ////        rb.constraints |= ~RigidbodyConstraints.None;
    ////        // Code to execute after the delay
    ////    }

    // Update is called once per frame
    void Update()
    {
        if (rb.transform.localScale.y < 3.3)
            rb.transform.localScale = Vector3.Lerp(rb.transform.localScale, final, Time.deltaTime * sizeUp / 50);
        //rb.transform.localScale = Vector3.Lerp(Vector3.zero, Domino.transform.localScale, Time.deltaTime * sizeUp);
        //Domino.transform.localScale = Vector3.Lerp(Vector3.zero, final, Time.deltaTime * sizeUp);
    }
    private void OnCollisionEnter(Collision collision)
    {
        //TODO Check if the collision object has a tag of "Ball", if so then set the boolean isColliding to true
        if (!collision.gameObject.CompareTag("waytag"))
        {
            rb.constraints &= ~RigidbodyConstraints.FreezeRotationZ;
            rb.constraints &= ~RigidbodyConstraints.FreezeRotationX;
            rb.constraints &= ~RigidbodyConstraints.FreezeRotationY;
        }
    }
}
