using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ships : MonoBehaviour
{
    public int soliders;
    float timer;
    GameController gc;
    public int saveTimeRate;

    private int[] upgradeQtt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer >= soliders)
        {
            gc.WarriorsNumQtt();    
            timer = 0;
        }
    }
}
