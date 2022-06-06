using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Com.MorganHouston.EscapeVR
{
    public class RotateObject : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(Vector3.up, 500 * Time.deltaTime);
        }
    }
}
