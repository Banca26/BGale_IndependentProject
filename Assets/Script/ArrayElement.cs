using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayElement : MonoBehaviour
{
    public GameObject[] Fire_Hydrant;
    private int Fire_HydrantIndex;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("inst", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void inst()
    {

        Instantiate(Fire_Hydrant[0], transform.position, Fire_Hydrant[Fire_HydrantIndex].transform.rotation);
       

    }

    }




       
    
            