﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix
{
    /// <summary>
    /// Represents a repeating field group within a message
    /// </summary>
    public class Group : FieldMap
    {
        /// <summary>
        /// Create a group with the specified count and delimiter fields.
        /// </summary>
        /// <param name="field">tag of the counter field</param>
        /// <param name="delim">delimiter field's tag (first field in the group)</param>
        public Group(int field, int delim)
        {
            Field = field;
            Delim = delim;
        }

        /// <summary>
        /// Create a group with the specified count and delimiter fields and field ordering.
        /// </summary>
        /// <param name="field">tag of the counter field</param>
        /// <param name="delim">delimiter field's tag (first field in the group)</param>
        /// <param name="fieldOrd">the group's member tags in order</param>
        public Group(int field, int delim, int[] fieldOrd)
            :base(fieldOrd)
        {
            Field = field;
            Delim = delim;
        }

        /// <summary>
        /// returns a copy of src (it's only as deep as FieldMap implemented)
        /// </summary>
        /// <param name="src">the Group to copy</param>
        public Group(Group src)
            :base(src)
        {
            Field = src.Field;
            Delim = src.Delim;
        }

        /// <summary>
        /// Tag of the group's counter field
        /// </summary>
        public int Field
        {
            get { return _field; }
            private set { _field = value; }
        }

        /// <summary>
        /// Tag of the group's delimiter field (first field in the group)
        /// </summary>
        public int Delim
        {
            get { return _delim; }
            private set { _delim = value; }
        }

        #region Private Members
        private int _field;
        private int _delim;
        #endregion
    }
}
