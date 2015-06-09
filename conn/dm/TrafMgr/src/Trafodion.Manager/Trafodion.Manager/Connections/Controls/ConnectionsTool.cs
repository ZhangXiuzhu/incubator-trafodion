//
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
using System.Windows.Forms;
using Trafodion.Manager.Framework.Controls;

namespace Trafodion.Manager.Framework.Connections.Controls
{
    /// <summary>
    /// This is a wrapper form that contains a MySystemsUserControl and a Done button.
    /// </summary>
    public partial class ConnectionsTool : TrafodionForm
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public ConnectionsTool()
        {

            // Assume cancel
            DialogResult = DialogResult.Cancel;

            // Call the code generated by the forms designer
            InitializeComponent();

            // Start off in the center
            StartPosition = FormStartPosition.CenterParent;

            // Load the grid
            _theMySystemsUserControl.Populate();

        }

        /// <summary>
        /// Called when the user clicks Done
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TheDoneButtonClick(object sender, EventArgs e)
        {

            // This dialog always shows success.  The embedded control does the work.
            DialogResult = DialogResult.OK;

            // Dismiss us
            Close();

        }

    }
}