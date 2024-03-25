using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonModel<T> where T : new()
{
    private static T _instance;
    public static T Instance
    {
        get
        { 
            if(_instance == null)
                _instance = new T();
            return _instance;
        }
        set
        {
            _instance = value;
        }
    }
}
