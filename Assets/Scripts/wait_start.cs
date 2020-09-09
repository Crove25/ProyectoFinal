using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class wait_start : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(logo_wait());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator logo_wait()
    {
        yield return new WaitForSeconds(3);

        SceneManager.LoadScene("loggin");
    }


}
