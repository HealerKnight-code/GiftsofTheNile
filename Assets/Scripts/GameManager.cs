using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int gold = 5;

    public int goldPerMinute = 5;
    public int goldTimer = 0;

    public int favourHapi = 0;

    public int favourAnubis = 0;

    public int favourRa = 0;

    public int favourBastet = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void BastetRitual()
    {
        if (gold >= 5)
        {
            gold = gold - 5;
            goldPerMinute = goldPerMinute + 2;
            if (favourBastet < 100)
            {
                favourBastet = favourBastet + 25;
            }
        }
    }

    public void RaRitual()
    {
        if (gold >= 10)
        {
            gold = gold - 10;
            goldPerMinute = goldPerMinute + 3;
            if (favourRa < 100)
            {
                favourRa = favourRa + 25;
            }

            if (favourAnubis > 0 && favourAnubis < 100)
            {
                favourAnubis = favourAnubis - 5;
            }
        }
    }

    public void AnubisRitual()
    {
        if (gold >= 20)
        {
            gold = gold - 20;
            if (favourAnubis < 100)
            {
                favourAnubis = favourAnubis + 25;
            }
        }
    }

    public void HapiRitual()
    {
        if (gold >= 30)
        {
            if (favourAnubis >= 50)
            {
                gold = gold - 30;
                favourHapi = favourHapi + 25;
            }
        }
    }
}