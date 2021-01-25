using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI winLabel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject other = collision.gameObject;
        if (other.CompareTag("ExitDoor"))
        {
            winLabel.gameObject.SetActive(true);
        }

    }



}
