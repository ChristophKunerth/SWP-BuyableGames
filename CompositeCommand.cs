using System;
using System.Collections.Generic;
using System.Text;

namespace StateAndCommand
{
    //Keeps tabs on all Commands in it's children and executes them in order added.
    public abstract class CompositeCommand : ICommand
    {
        private IList<ICommand> _children = new List<ICommand>();

        protected void AddChild(ICommand command)
        {
            _children.Add(command);
        }

        public void Execute()
        {
            foreach(var child in _children)
            {
                child.Execute();
            }
        }
    }
}
