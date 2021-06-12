using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour

{
    public Canvas openDoorText;

    // Start is called before the first frame update
    void Start()
    {
        openDoorText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (openDoorText.gameObject.activeInHierarchy && Input.GetKeyDown("f"))
        {
            SceneManager.LoadScene(1);
        }
    }

    void OnTriggerEnter(Collider other)
    {
       
        openDoorText.gameObject.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        openDoorText.gameObject.SetActive(false);
    }

}
