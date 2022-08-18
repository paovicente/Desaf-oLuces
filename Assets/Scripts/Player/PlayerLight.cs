using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLight : MonoBehaviour {
    
    private Light spotLight;
    private const float LOWINTENSITY = 2f;
    // Start is called before the first frame update
    void Start(){
        spotLight = GetComponent<Light>();
        InvokeRepeating("Battery",1f,1f);
    }
    
    private void Battery(){
        spotLight.intensity -= 5f;
        if (spotLight.intensity == 50)
            spotLight.color = Color.magenta;
        if (spotLight.intensity == 0)
            CancelInvoke("Battery");
    }
}
