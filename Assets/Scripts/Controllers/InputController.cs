using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SbSTanks;

namespace SbSTanks
{
    public class InputController : IExecute
    {
        private IPCInputSpace _pCInputSpace;

        public InputController(IPCInputSpace pCInputSpace)
        {
            _pCInputSpace = pCInputSpace;
        }

        public void Execute(float deltaTime)
        {
            _pCInputSpace.CheckButtons();
        }
    }
}

