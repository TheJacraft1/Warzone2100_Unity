using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTank : BaseObjekt
{
    public BaseTankTop Top;
    public BaseTankBody Body;
    public BaseTankBottum Bottom;
    
    public BaseTank()
    {
        type = Type.Tank;
    }


}
