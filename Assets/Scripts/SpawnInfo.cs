using UnityEngine;
using System.Collections;

public class SpawnInfo{
    public Transform target;
    public Material material;
    public float time;

    public SpawnInfo(Transform t , Material m , float time)
    {
        this.material = m;
        this.target = t;
        this.time = time;
    }
}
