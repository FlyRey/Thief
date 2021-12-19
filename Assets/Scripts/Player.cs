using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _helth;
    public bool KeyOfDirector;
    public bool KeyOfWarehouse;
    public bool GetKeyFromDirector()
    {
        bool haveKey;
        if (KeyOfDirector == true)
        {
            haveKey = true;
        }
        else
        {
            haveKey = false;
        }
        return haveKey;
    }

    public bool GetKeyFromWarehouse()
    {
        bool haveKey;
        if (KeyOfWarehouse == true)
        {
            haveKey = true;
        }
        else
        {
            haveKey = false;
        }
        return haveKey;
    }

}
