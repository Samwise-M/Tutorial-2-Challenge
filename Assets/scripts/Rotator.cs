using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Update()
    {
        transform.Rotate (new Vector2(0, 45) * Time.deltaTime);
    }
}
