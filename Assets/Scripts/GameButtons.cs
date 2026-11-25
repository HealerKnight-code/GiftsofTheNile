using UnityEngine;

public class GameButtons : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void BastetCall()
    {
        gameManager.BastetRitual();
    }

    public void RaCall()
    {
        gameManager.RaRitual();
    }

    public void AnubisCall()
    {
        gameManager.AnubisRitual();
    }

    public void HapiCall()
    {
        gameManager.HapiRitual();
    }
}
