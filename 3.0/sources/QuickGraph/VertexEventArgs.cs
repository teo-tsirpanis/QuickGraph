﻿using System;
using System.Diagnostics.Contracts;

namespace QuickGraph
{
    [Serializable]
    public abstract class VertexEventArgs<TVertex> : EventArgs
    {
        private readonly TVertex vertex;
        protected VertexEventArgs(TVertex vertex)
        {
            Contract.Requires(vertex != null);
            this.vertex = vertex;
        }

        public TVertex Vertex
        {
            get { return this.vertex; }
        }
    }

    public delegate void VertexAction<TVertex>(TVertex e);
}
