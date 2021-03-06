#!/bin/sh
#/**
# *(C) Copyright 2015 Hewlett-Packard Development Company, L.P.
# *
# * Licensed under the Apache License, Version 2.0 (the "License");
# * you may not use this file except in compliance with the License.
# * You may obtain a copy of the License at
# *
# *     http://www.apache.org/licenses/LICENSE-2.0
# *
# * Unless required by applicable law or agreed to in writing, software
# * distributed under the License is distributed on an "AS IS" BASIS,
# * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# * See the License for the specific language governing permissions and
# * limitations under the License.
# */
# This is used for starting multiple servers on the same machine.
# run it from 'bin/wms'

bin=`dirname "${BASH_SOURCE-$0}"`
bin=`cd "$bin" >/dev/null && pwd`

if [ $# -lt 2 ]; then
  S=`basename "${BASH_SOURCE-$0}"`
  echo "Usage: $S [start|stop] offset(s)"
  echo ""
  echo "    e.g. $S start 1 2"
  exit
fi

export WMS_SERVER_OPTS=" "

run_server () {
  DN=$2
  export WMS_IDENT_STRING="$USER-$DN"
  "$bin"/wms-daemon.sh $1 server
}

cmd=$1
shift;

for i in $*
do
  run_server $cmd $i
done
