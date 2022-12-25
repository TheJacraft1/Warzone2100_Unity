using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public abstract class BaseObjekt : MonoBehaviour
{
    public enum Type
    {
        Building,
        TankHead,
        TankBody,
        TankBottum,
        Tank,
        Reserch
    }

    public Type type;
    public string name;
    public string description;



}
