using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{

    [SerializeField] GameObject MainCam;
    [SerializeField] GameObject FirstPersonCam;
    // Use this for initialization
    void Start()
    {

        MainCam.SetActive(false);
        FirstPersonCam.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.C))
        {
            MainCam.SetActive(!MainCam.activeSelf);
            FirstPersonCam.SetActive(!FirstPersonCam.activeSelf);

        }

    }
}
