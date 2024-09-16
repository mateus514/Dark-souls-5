using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CarregarCena : MonoBehaviour
{
    public string cenaParaCarregar;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(cenaParaCarregar);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
