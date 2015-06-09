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

namespace Trafodion.Manager.UniversalWidget
{
    /// <summary>
    /// Factory to create an appropriate ChartRenderer based on the UniversalWidgetConfig passed
    /// </summary>
    public class ChartRendererFactory
    {
        public static ChartRenderer GetChartRenderer(UniversalWidgetConfig aConfig)
        {
            return (aConfig.ChartConfig != null) ? GetChartRenderer(aConfig.ChartConfig) : null;
        }

        public static ChartRenderer GetChartRenderer(ChartConfig aChartConfig)
        {
            return aChartConfig.GetChartRenderer();
        }
    }
}