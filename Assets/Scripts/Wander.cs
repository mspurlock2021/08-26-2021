using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour
{
    public float Speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tempP = this.gameObject.transform.position;

        tempP.x += Speed * Time.deltaTime;
        this.gameObject.transform.position = tempP;
    }
}
