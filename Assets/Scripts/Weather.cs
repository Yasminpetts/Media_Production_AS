using UnityEngine;
using UnityEngine.UI;

public class ParticleController : MonoBehaviour
{
    public ParticleSystem rainFallParticleSystem; // Reference to your RainFall Particle System

    // Start is called before the first frame update
    public void Start()
    {
        // Find the RainFallButton and SunButton by name within the Canvas2
        Button rainFallButton = GameObject.Find("Canvas2/Panel2/RainFallButton").GetComponent<Button>();
        Button sunButton = GameObject.Find("Canvas2/Panel2/SunButton").GetComponent<Button>();

        // Add listeners for button clicks
        rainFallButton.onClick.AddListener(ActivateRainFall);
        sunButton.onClick.AddListener(DeactivateRainFall);

        //show cursor
        Cursor.lockState = CursorLockMode.None;
    }
    // Function to activate the RainFall particle system
    public void ActivateRainFall()
    {
        rainFallParticleSystem.Play();
        GetComponent <ParticleSystem>().Play (); ParticleSystem.EmissionModule em = GetComponent<ParticleSystem>().emission; em.enabled = true;
    }

    // Function to deactivate the RainFall particle system
    public void DeactivateRainFall()
    {
        rainFallParticleSystem.Stop();
        GetComponent <ParticleSystem>().Play (); ParticleSystem.EmissionModule em = GetComponent<ParticleSystem>().emission; em.enabled = false;
    }

    
}