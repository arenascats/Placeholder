using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float m_speed = 20;
    public GameObject human;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //FixedUpdate();
       MoveControlByTranslate();
    }


// void FixedUpdate()
//     {
//         //起点在player对象下方groundedCheckOffset处,方向为向下,射线长度为groundedDistance,
//         //检测层为groundLayers指定的层
//         grounded = Physics.Raycast(rigi.transform.position + rigi.transform.up * -groundedCheckOffset,
//             transform.up * -1, groundedDistance, groundLayers);
//         if (grounded)
//         {
//             rigi.drag = groundDrag;
 
//             //在地上,可进行跳跃动作
//             if (Input.GetButton("Jump"))
//             {
//                 //为刚体施加一个向上的力:该力是由向上的跳跃速度和在刚体原速度方向上的一个速度合成的
//                 //VelocityChange是一个瞬时速度
//                 rigi.AddForce(transform.up * jumpSpeed + rigi.velocity.normalized * directionalJumpFactor
//                     , ForceMode.VelocityChange);
 
//                 if (onMyJump != null)
//                     onMyJump();
//             }
//             else
//             {
//                 //在地上且未跳跃,计算行走的方向
//                 //合成水平和竖直方向的矢量
//                 Vector3 movement = Input.GetAxis("Vertical") * rigi.transform.forward +
//                     SidestepAxisInput * rigi.transform.right;
 
//                 //速度的限制
//                 float appliedSpeed = walking ? speed / walkSpeedDownscale : speed;
 
//                 if (Input.GetAxis("Vertical") < 0.0f)
//                 {
//                     appliedSpeed /= walkSpeedDownscale;
//                 }
 
//                 if (movement.magnitude > 0.01f)
//                 {
//                     //在move的方向上添加一个瞬时速度
//                     rigi.AddForce(movement.normalized * appliedSpeed, ForceMode.VelocityChange);
//                 }
//                 else
//                 {
//                     //停止运动,且仅在y轴能运动
//                     rigi.velocity = new Vector3(0, rigi.velocity.y, 0);
//                     return;
//                 }
//             }
//         }
//         else
//         {
//             //在空中,阻力为0
//             rigi.drag = 0;
//         }
 
//     }
    void MoveControlByTranslate()
    {
        if (Input.GetKey(KeyCode.W)|Input.GetKey(KeyCode.UpArrow)) //前
        {
            this.transform.Translate(Vector3.forward*m_speed*Time.deltaTime*1);
        }
        if (Input.GetKey(KeyCode.S) | Input.GetKey(KeyCode.DownArrow)) //后
        {
            this.transform.Translate(Vector3.forward *- m_speed * Time.deltaTime*1);
        }
        if (Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.LeftArrow)) //左
        {
            this.transform.Translate(Vector3.right *-m_speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.RightArrow)) //右
        {
            this.transform.Translate(Vector3.right * m_speed * Time.deltaTime);
        }
    }
}
