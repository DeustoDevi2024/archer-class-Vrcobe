using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightMovement : MonoBehaviour
{
    [SerializeField]
    private Transform target;


    private Light light;
    // Start is called before the first frame update
    void Start()
    {
        light = this.GetComponent<Light>();
        this.transform.position = target.position;
        light.intensity = 20;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = target.position + new Vector3(0,1,0);
        
        this.transform.rotation = target.rotation;
    }
}
