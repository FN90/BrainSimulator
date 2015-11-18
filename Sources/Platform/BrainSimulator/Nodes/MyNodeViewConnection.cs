﻿using GoodAI.BrainSimulator.NodeView;
using GoodAI.Core;
using Graph;

namespace GoodAI.BrainSimulator.Nodes
{
    public class MyNodeViewConnection : NodeConnection
    {
        public override string Name
        {
            get
            {
                if (From != null && (From.Node is MyNodeView) && (Tag is MyConnection))
                {
                    MyNodeView fromNodeView = From.Node as MyNodeView;

                    var memBlock = fromNodeView.Node.GetAbstractOutput((Tag as MyConnection).FromIndex);
                    if (memBlock != null)
                        return memBlock.Dims.Print(printTotalSize: true);
                }

                return "0";
            }
            set
            {

            }
        }

        public bool Backward
        {
            get { return (state & RenderState.Backward) != 0; }
            set
            {
                if (value)
                {
                    state |= RenderState.Backward;
                }
                else
                {
                    state &= ~RenderState.Backward;
                }
            }
        }
    }
}
