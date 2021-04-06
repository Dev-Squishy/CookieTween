using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CookieTweenie

{
    public interface IUIEffect
    {
        IEnumerator Execute();
    }

}
