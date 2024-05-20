using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public interface ISelector
{
    bool Check(Ray ray);

    Transform GetSelection();
}
