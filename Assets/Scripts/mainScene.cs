using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var parameters = new LoadSceneParameters(LoadSceneMode.Additive);
        Scene subscene = SceneManager.LoadScene("me", parameters);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
