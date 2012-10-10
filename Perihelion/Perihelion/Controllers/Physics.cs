using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Perihelion.Models;

namespace Perihelion.Controllers
{
    class Physics
    {
        Physics()
        {

        }

        /************************************************************************/
        /* Detects collisions between two GameObject objects                    */
        /************************************************************************/
        public bool checkCollision(GameObject go1, GameObject go2)
        {
            if (go1.BoundingBox.Intersects(go2.BoundingBox))
            {
                return true;
            }
            return false;
        }
    }
}
