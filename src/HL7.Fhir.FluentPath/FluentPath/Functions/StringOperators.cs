﻿/* 
 * Copyright (c) 2015, Furore (info@furore.com) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hl7.ElementModel;

namespace Hl7.FluentPath.Functions
{
    internal static class StringOperators
    {
        public static string FpSubstring(this string me, long start)
        {
            return me.FpSubstring(start, me.Length);
        }

        public static string FpSubstring(this string me, long start, long length)
        {
            if (start < 0 || start >= me.Length) return null;
            length = Math.Min(length, me.Length - start);

            return me.Substring((int)start, (int)length);
        }

        public static IValueProvider FpIndexOf(this string me, string fragment)
        {
            var result = me.IndexOf(fragment);

            if (result == -1)
                return null;
            else
                return new ConstantValue(result);
        }

        public static string FpReplace(this string me, string find, string replace)
        {
            if (find == String.Empty)
            {
                // weird, but as specified:  "abc".replace("","x") = "xaxbxc"
                return replace + String.Join(replace, me.ToCharArray());
            }
            else
                return me.Replace(find, replace);
        }
    }
}
