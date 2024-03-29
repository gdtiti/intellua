﻿using System;
using System.Collections.Generic;

namespace Intellua
{
    public abstract class IAutoCompleteItem : IComparable, IEquatable<IAutoCompleteItem>
    {
        #region Methods (5)

        // Public Methods (5) 

        public Int32 CompareTo(IAutoCompleteItem other)
        {
            return getName().CompareTo(other.getName());
        }

        public int CompareTo(Object obj)
        {
            IAutoCompleteItem item = obj as IAutoCompleteItem;
            if (item != null)
                return CompareTo(item);
            else
            {
                throw new ArgumentException("Object is not a IAutoCompleteItem");
            }
        }
        public bool Equals(IAutoCompleteItem other) {
            if (this.GetType() != other.GetType()) return false;
            return getName() == other.getName();

        }

        public abstract string getACString();

        public abstract string getName();

        public abstract string getToolTipString();

        public abstract bool isPrivate();

        #endregion Methods
    }

    internal class AutoCompleteItemComparer : EqualityComparer<IAutoCompleteItem>
    {
        #region Methods (2)

        // Public Methods (2) 

        public override bool Equals(IAutoCompleteItem b1, IAutoCompleteItem b2)
        {
            if (b1.getName() == b2.getName())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode(IAutoCompleteItem item)
        {
            return item.getName().GetHashCode();
        }

        #endregion Methods
    }
}