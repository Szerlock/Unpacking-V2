using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneStarter : MonoBehaviour
{
[SerializeField]
    protected GameObject box;

    void Awake()
    {
        //for (int i = 3; i < 7; i++)
        //{
          //  for (int j = -2; j < 2; j++)
           // {   
                GameObject newBox = Instantiate(box, new Vector3(4, 0), Quaternion.identity);
                newBox.AddComponent<BoxCollider2D>();
                newBox.AddComponent<BoxClickHandler>();
            //}        
        //}
        
    }

    void TaskOnClick()
    {
        
        
    }

}
