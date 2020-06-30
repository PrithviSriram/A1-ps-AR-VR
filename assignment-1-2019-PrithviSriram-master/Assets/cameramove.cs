using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    //The target object that this camera is focosing on
    public GameObject targetObject;

    //A float used to tweak the camera movement
    [SerializeField]
    float cameraMovementSmooth = 1.0f;

    //An offset between camera and the target obejct
    Vector3 offset;

    void Start()
    {
        //TODO Calculate the offset between the camera and the target game object
        offset = transform.position - targetObject.transform.position;//Vector3.Distance(targetObject.transform.position, myCamera.transform.root.transform.position);
    }

    void Update()
    {
        //TODO Add the offset to the camera
        transform.position = targetObject.transform.position + offset;

    }
    /*    //The target object that this camera is focosing on
        public GameObject targetObject1;
        public GameObject targetObject2;
        //A float used to tweak the camera movement
        [SerializeField]
        float cameraMovementSmooth = 1.0f;

        //An offset between camera and the target obejct
        Vector3 offset;
        bool alreadycollided = false;

        void Start()
        {
            //TODO Calculate the offset between the camera and the target game object
            offset = transform.position - targetObject1.transform.position;//Vector3.Distance(targetObject.transform.position, myCamera.transform.root.transform.position);
        }

        void Update()
        {
            if(!alreadycollided)
            {
                offset = transform.position - targetObject1.transform.position;//Vector3.Distance(targetObject.transform.position, myCamera.transform.root.transform.position);
                tracker(targetObject1);

            }
            else
            {
                offset = transform.position - targetObject2.transform.position;//Vector3.Distance(targetObject.transform.position, myCamera.transform.root.transform.position);
                tracker(targetObject2);
            }
            //TODO Add the offset to the camera
        }
        private void OnCollisionEnter(Collision collision)
        {
            //TODO Check if the collision object has a tag of "Ball", if so then set the boolean isColliding to true
            if (collision.gameObject.CompareTag("Ball"))
            {
                Destroy(targetObject1);
                alreadycollided = true;
    *//*            targetObject1.gameObject.useGravity = false;
                targetObject1.velocity = Vector3.zero;
    *//*            //Destroy(targetObject1, 1.0f);
            }
        }
        void tracker(GameObject targetobject)
        {
            transform.position = targetobject.transform.position + offset;
        }
    */
}
