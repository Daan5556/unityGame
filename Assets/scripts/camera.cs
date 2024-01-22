using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class camera : MonoBehaviour
{
    [SerializeField] GameObject target;
    private Transform transform;
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(target.transform.position.x, -1F, -10F);
    }
}
