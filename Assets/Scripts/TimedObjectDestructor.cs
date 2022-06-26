using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedObjectDestructor : MonoBehaviour
{
    /// <summary>
    /// 
    /// Destroys wave particles
    /// 
    /// </summary>

    public void Start()
    {
        Destroy(this.gameObject, 9f);
    }

}
