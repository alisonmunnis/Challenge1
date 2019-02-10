using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 start;
    public Vector3 end;

    void Update()
    {
        start = new Vector3(93.5f, 0.5f, 7.2f);
        end = new Vector3(93.5f, 0.5f, -3.11f);

        transform.position = new Vector3(Mathf.PingPong(start, end, Time.time, 3);
    }
}
