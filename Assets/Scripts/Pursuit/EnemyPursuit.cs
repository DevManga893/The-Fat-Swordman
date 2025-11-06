using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class EnemyPursuit : MonoBehaviour
{
    //public Transform player;
    [SerializeField] private float vp = 5f;//vp == velocity pursuit
    public GameObject e;//enemy
    public GameObject p;//Player

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        P_Function(p, vp);
    } 

    void P_Function(GameObject p,float v)
    {
       // e.transform.position += p.transform.position * v * Time.deltaTime;
       if(e.transform.localPosition != p.transform.localPosition)
        {
            e.transform.localPosition += p.transform.localPosition * v * Time.deltaTime;
        }
    }
}
