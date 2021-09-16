using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noon : MonoBehaviour
{
    public float RotationSpeed = 1;
    public float sAngle;
    public float eAngle;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 angle = this.transform.eulerAngles;
        angle.x = sAngle;
        this.transform.eulerAngles = angle;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tempAngle = this.transform.eulerAngles;
        tempAngle.x = tempAngle.x + RotationSpeed * Time.deltaTime;
        this.transform.eulerAngles = tempAngle;
    }
}
