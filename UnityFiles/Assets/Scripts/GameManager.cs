using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static Player player;
    // Start is called before the first frame update
    void Start()
    {
          player = new Player(100,100,100,100,1,1,1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
