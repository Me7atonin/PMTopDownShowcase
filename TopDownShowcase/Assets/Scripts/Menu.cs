using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    string leveltoload = "1stPart";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //IF button named Play is clicked load scene named 1stPart
        

    }



    public void QuitGame()
    {
        Application.Quit();
    }

}
