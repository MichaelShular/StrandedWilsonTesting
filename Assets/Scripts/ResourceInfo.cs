using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceInfo : MonoBehaviour
{
    public TypesOfResourceNodes resourceType;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public enum TypesOfResourceNodes
    {
        Bush,
        Rock,
        Tree
    }

    public enum TypesOfResource
    {
        None,
        Berry,
        Twig,
        Rock,
        Ore,
        Plank
       
    }
    public enum TypesOFCollectionTools
    {
        None,
        MiningPick,
        Axe
    }
    public TypesOfResource collectingResource(bool hasPick, bool hasAxe)
    {
        TypesOfResource temp = TypesOfResource.None;
        int choosingItem = Random.Range(1, 10);

        switch (resourceType)
        {
            case TypesOfResourceNodes.Bush:
                if(choosingItem < 5)
                {
                    temp = TypesOfResource.Berry;
                }
                else
                {
                    temp = TypesOfResource.Twig;
                }
                break;
            case TypesOfResourceNodes.Rock:
                if (!hasPick)
                {
                    Debug.Log("Need Pick Tool");
                    return TypesOfResource.None;
                }
                temp = TypesOfResource.Ore;
                break;
            case TypesOfResourceNodes.Tree:
                if (!hasAxe)
                {
                    Debug.Log("Need Axe Tool");
                    return TypesOfResource.None;
                }
                temp = TypesOfResource.Plank;
                break;
            default:
                break;
        }
        Destroy(this.gameObject);
        return temp;
    }

}
