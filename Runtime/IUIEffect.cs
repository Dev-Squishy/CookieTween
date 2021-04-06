using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CookieTweener
{
    public interface IUIEffect
    {
        IEnumerator Execute();
    }

}
