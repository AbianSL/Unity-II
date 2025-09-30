using System.Collections.Generic;
using UnityEngine;

public class TagLocator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        List<GameObject> taggedObjects = new List<GameObject>();
        taggedObjects.AddRange(GameObject.FindGameObjectsWithTag("Road"));
        taggedObjects.AddRange(GameObject.FindGameObjectsWithTag("Building"));
        taggedObjects.AddRange(GameObject.FindGameObjectsWithTag("Tree"));
        taggedObjects.AddRange(GameObject.FindGameObjectsWithTag("Player"));
        taggedObjects.AddRange(GameObject.FindGameObjectsWithTag("Terrain"));
        
        foreach (GameObject eachObject in taggedObjects)
        {
            Transform objTransform = eachObject.GetComponent<Transform>();
            Debug.Log("Object: " + eachObject.name + " Position: " + objTransform.position);
        }
        Debug.Log("Total tagged objects found: " + taggedObjects.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
