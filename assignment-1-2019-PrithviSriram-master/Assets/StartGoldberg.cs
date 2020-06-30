using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartGoldberg : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam;
    public string standByText = "Click Platform";
    public string startedText = "Good Luck Prithvi!";
    public TextMeshProUGUI tmpr;
    void Start()
    {
        tmpr.text = standByText;
        cam = Camera.main;
        //tmpr = GetComponent<TextMeshPro>();//gameObject.AddComponent<TextMeshPro>();
        //Instantiate(tmpr);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            //Debug.Log("Pressed left click.");
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
                Interact(hitInfo);
        }
    }

    void Interact(RaycastHit hit)
    {
        //Debug.Log("hitting collider " + hit.collider.name);
        if (hit.collider.name == "StartPlatform")
        {
            tmpr.text = startedText;
            hit.transform.gameObject.SetActive(false);
        }
    }
}
