/*
    This file is part of PapyrusDotNet.

    PapyrusDotNet is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    PapyrusDotNet is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with PapyrusDotNet.  If not, see <http://www.gnu.org/licenses/>.
	
	Copyright 2015, Karl Patrik Johansson, zerratar@gmail.com
 */

using System.Collections.Generic;

namespace PapyrusDotNet.CoreBuilder.Papyrus.Script
{
    public class PapyrusScriptStateFunction
    {
        public bool IsAuto;
        public string Name;

        public List<PapyrusScriptFunction> Functions { get; set; } = new List<PapyrusScriptFunction>();
    }
}