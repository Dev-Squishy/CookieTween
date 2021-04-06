using System.Collections;
using UnityEngine;
using CookieTweener;

namespace CookieTweener
{
    public class UIMove : IUIEffect
    {
        private Vector2 MoveDirection;

        public UIMove(Vector2 moveDir)
        {
            MoveDirection = moveDir;
        }

        public IEnumerator Execute()
        {
            return null;
        }
    }
}