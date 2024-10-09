using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShadowAIBrain : MonoBehaviour
{
    //hace que la sombra siga en xz pero no en y al objeto al que ha sido asignado

    private Vector3 tempPos;

    // Start is called before the first frame update
    void Start()
    {
        RecolocateShadow();
    }

    // Update is called once per frame
    void Update()
    {
        RecolocateShadow();
    }

    private void RecolocateShadow()
    {
        tempPos = transform.parent.position;
        tempPos.y = 0;
        transform.position = tempPos;   
    }
}
