/**********************************************************************
// @@@ START COPYRIGHT @@@
//
// (C) Copyright 1999-2014 Hewlett-Packard Development Company, L.P.
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
**********************************************************************/
/* -*-C++-*-
 *****************************************************************************
 *
 * File:         vprocutp.cpp
 * Created:      06/22/2010
 * Language:     C++
 *
 *
//=============================================================================
//
*
*****************************************************************************
*/

#include "vproc.h"
#include <stdio.h>


extern "C" { void
VPROC (PRODNUMMXUDR,DATE1MXUDR,MXUDR_CC_LABEL)
() {} }


#include "SCMVersHelp.h"

#define VERS_CV_MAJ 1
#define VERS_CV_MIN 0
#define VERS_CV_UPD 1

VERS_BIN (tdm_udrserv)



