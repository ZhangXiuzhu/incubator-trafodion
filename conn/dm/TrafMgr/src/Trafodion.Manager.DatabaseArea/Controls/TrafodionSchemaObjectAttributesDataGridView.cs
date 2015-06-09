﻿//
// @@@ START COPYRIGHT @@@
//
// (C) Copyright 2007-2015 Hewlett-Packard Development Company, L.P.
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//
// @@@ END COPYRIGHT @@@
//

using System;
using System.Collections.Generic;
using System.Text;
using Trafodion.Manager.Framework.Controls;
using Trafodion.Manager.DatabaseArea.Model;
using System.Windows.Forms;


namespace Trafodion.Manager.DatabaseArea.Controls
{
    /// <summary>
    /// This class displays Creation Time and Redefinition Time in a datagrid.
    /// If your schema level object has these values then derive your attributes datagrid from this class 
    /// instead of TrafodionObjectAttributesDataGridView.
    /// </summary>
    public abstract class TrafodionSchemaObjectAttributesDataGridView : TrafodionObjectAttributesDataGridView
    {
        #region Fields

        private TrafodionSchemaObject _sqlMxSchemaObject;

        #endregion

        #region Properties

        public TrafodionSchemaObject TrafodionSchemaObject
        {
            get { return _sqlMxSchemaObject; }
            set
            {
                _sqlMxSchemaObject = value;
               
                AddRow(Properties.Resources.CreationTime,  _sqlMxSchemaObject.FormattedCreateTime());
                AddRow(Properties.Resources.RedefinitionTime, _sqlMxSchemaObject.FormattedRedefTime());
             }
        }

        #endregion

        /// <summary>
        /// A data grid to display TrafodionSchemaObject attributes information.
        /// </summary>
        /// <param name="aDatabaseObjectsControl">
        /// The DatabaseObjectsControl that contains the tree.
        /// </param>
        /// <param name="aTrafodionSchemaObject">
        /// The TrafodionObject that will have it's attributes displayed.
        /// </param>
        public TrafodionSchemaObjectAttributesDataGridView(DatabaseObjectsControl aDatabaseObjectsControl, TrafodionSchemaObject aTrafodionSchemaObject)
            : base(aDatabaseObjectsControl, aTrafodionSchemaObject)
        {
            TrafodionSchemaObject = aTrafodionSchemaObject;
        }

              
    }
}