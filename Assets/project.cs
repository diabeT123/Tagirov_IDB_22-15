using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class project : MonoBehaviour
{
    public GameObject sphere;
    public GameObject tree;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    public void start_sphere ()
    {
     sphere.SetActive(!sphere.activeSelf);
    }
    public void start_tree()
    {
     tree.SetActive(!tree.activeSelf);
    }
}
