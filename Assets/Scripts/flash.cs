using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class flash : MonoBehaviour
{
   public Light L;
   public double[] x=new double[]{0.8,0.6,0.5,0.2,0.9,1,0.9,1,0.5,1,1,1,1,1,0.9};
    //通过控制物体的MeshRenderer组件的开关来实现物体闪烁的效果
    private MeshRenderer BoxColliderClick;
    double LG;
    double num;
    // Use this for initialization
    void Start()
    {
    //    L = GetComponent<Light>();
    }
  
    // Update is called once per frame
    void Update()
    {
        // num += 1;
        // L.intensity = x[num]*(L.intensity);
        
        // if(num >= 12.0)
        // {
        //     num = 0;
        // }
    }
}

