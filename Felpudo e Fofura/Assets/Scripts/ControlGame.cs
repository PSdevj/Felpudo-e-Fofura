using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.ParticleSystem;
using UnityEngine.SceneManagement;

public class ControlGame : MonoBehaviour
{
    public bool gameLigado = true;
    public GameObject telaMatch;
    public GameObject telaNoMatch;


    public ParticleSystem particles;


    // Start is called before the first frame update
    void Start()
    {
        gameLigado = true;
        Time.timeScale = 1;
        var emission = particles.emission;
        emission.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Match()
    {
        telaMatch.SetActive(true);
        Time.timeScale = 0;
        gameLigado = false;

    }

    public void SimMatch()
    {
        telaMatch.SetActive(false);
        ativadorParticulas();
        

    }

    public void NoMatch()
    {
        telaNoMatch.SetActive(true);
        Time.timeScale = 0;

    }
    public void ativadorParticulas()
    {
        
        telaMatch.SetActive(false);
        var emission = particles.emission;
        emission.enabled = true;
    }

}
