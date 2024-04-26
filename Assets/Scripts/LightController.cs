using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    private Light light;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        this.light.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void offLight()
    {
        this.light.enabled = false;
    }
    public void onLight()
    {
        this.light.enabled = true;
    }
}
