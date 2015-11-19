﻿#region License

//     This file is part of PapyrusDotNet.
// 
//     PapyrusDotNet is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     PapyrusDotNet is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with PapyrusDotNet.  If not, see <http://www.gnu.org/licenses/>.
//  
//     Copyright 2015, Karl Patrik Johansson, zerratar@gmail.com

#endregion

#region

using PapyrusDotNet.Core;

#endregion

namespace Example1
{
    public class GenericTest
    {
        [Property, Auto] private GenericClass<int> genericInteger;

        public void OnInit()
        {
            genericInteger.Set(9999);
            var value = genericInteger.Get();
            Debug.Trace("The value is: " + value, 0);
        }
    }

    public class GenericClass<T> : Form
    {
        public T GenericVariable;

        public void Set(T value)
        {
            GenericVariable = value;
        }

        public T Get()
        {
            return GenericVariable;
        }
    }
}