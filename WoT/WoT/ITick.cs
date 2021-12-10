using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WoT
{
    public interface ITick
    {
        public void Tick(TimeSpan span);
    }
}