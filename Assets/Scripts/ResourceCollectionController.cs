using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceCollectionController : MonoBehaviour
{
    public bool hasMiningPick;
    public bool hasAxe;
    public bool canCollect;
    public GameObject currentResourceToCollect;
    public ResourceInfo.TypesOfResource pickUpResource; 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (canCollect)
            {
                //Add timer
                //Connect to inventory
                //Inventory Full
                pickUpResource = currentResourceToCollect.GetComponent<ResourceInfo>().collectingResource(hasMiningPick, hasAxe);
                
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Resource"))
        {
            canCollect = true;
            currentResourceToCollect = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Resource"))
        {
            canCollect = false;
            currentResourceToCollect = null;
        }
    }

}
