using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmTriiger : MonoBehaviour
{
    public enum OptionActions
    {
        Close,
        InstantiateUIObj
    }
    [System.Serializable]
    public struct Option
    {
        public string OptionMsg;
        public OptionActions OptionAction;
        public GameObject Obj;
    }

    interface Closeable
    {
        void Close();
    }

    public GameObject ButtonPrefab;
    public GameObject ConfirmDialogPrefab;
    public GameObject Canvas;

    private GameObject dialogInst;

    public Option[] Options = {
            new ConfirmTriiger.Option{
                    OptionMsg = "查看文件",
                    OptionAction = OptionActions.InstantiateUIObj,
            },
            new ConfirmTriiger.Option{
                    OptionMsg = "关闭",
                    OptionAction = OptionActions.Close,
            }
        };
    public string DialogMsg = "Example Msg";

    public void Start()
    {
    }

    private void OnTriggerEnter(Collider col)
    {
        this.dialogInst = Instantiate(ConfirmDialogPrefab, Canvas.transform);
        // dialog msg
        dialogInst.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = DialogMsg;
        foreach (Option opt in Options)
        {
            GameObject button = Instantiate(ButtonPrefab);
            button.transform.SetParent(dialogInst.transform.GetChild(1));
            button.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().text = opt.OptionMsg;
            button.GetComponent<UnityEngine.UI.Button>().onClick.AddListener(delegate ()
            {
                this.onClick(opt);
            });
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (this.dialogInst != null)
        {
            GameObject.Destroy(this.dialogInst);
        }
    }

    public void Close()
    {
        this.OnTriggerExit(null);
    }

    private void onClick(Option opt)
    {
        switch (opt.OptionAction)
        {
            case OptionActions.Close:
                if (opt.Obj != null)
                {
                    Closeable[] items = opt.Obj.GetComponents<Closeable>();
                    foreach (Closeable item in items)
                    {
                        item.Close();
                    }
                    return;
                }

                this.Close();
                return;
            case OptionActions.InstantiateUIObj:
                Instantiate(opt.Obj, Canvas.transform);
                this.Close();
                return;
        }
    }

    // public virtual void OnClickAccpet()
    // {
    //     if (Page != null)
    //     {
    //         Instantiate(Page, Canvas.transform);
    //         this.Close();
    //         return;
    //     }
    //     print("this example do nothing, rewrite this func please");
    // }
}
