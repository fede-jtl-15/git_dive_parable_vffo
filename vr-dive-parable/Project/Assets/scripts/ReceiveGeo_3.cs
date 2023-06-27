using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveGeo_3 : MonoBehaviour
{
        public OSC osc;
        public GameObject Geo_3;


    // Use this for initialization
    void Start () {
       osc.SetAddressHandler("/Geo_OnOff_3", OnReceiveGeoOnOff_3);
    }
    
    // Update is called once per frame
    void Update () {
    
    }

    void OnReceiveGeoOnOff_3(OscMessage message) {
        float G_OnOff_3 = message.GetFloat(0);
        if (G_OnOff_3 == 0)
                {
                    Geo_3.SetActive(false);
                }
                else  Geo_3.SetActive(true);
     }
        
 }

