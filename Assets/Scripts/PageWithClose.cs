using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageWithClose : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.Find("BtnClose").GetComponent<UnityEngine.UI.Button>().onClick.AddListener(delegate ()
        {
            print("clock page close");
            // NOTE: 其实这些Destory和Instantiate都可以搞个全局pool掉优化内存 先这么写吧 不行了再说
            Destroy(this.gameObject);
        });
        // 原则上同时应该最多一张Page，需要search下destory掉拥有同component的gameobject
    }
}
