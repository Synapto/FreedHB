﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="hb_geometry.cs" company="HandBrake Project (https://handbrake.fr)">
//   This file is part of the HandBrake source code - It may be used under the terms of the GNU General Public License.
// </copyright>
// <summary>
//   Defines the hb_geometry type.
// </summary>
// <auto-generated>Disable Stylecop Warnings for this file</auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace HandBrake.Interop.Interop.HbLib
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// The hb_geometry_s.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct hb_geometry_s
    {
        /// <summary>
        /// The width.
        /// </summary>
        public int width;

        /// <summary>
        /// The height.
        /// </summary>
        public int height;

        /// <summary>
        /// The par.
        /// </summary>
        public hb_rational_t par;
    }

    /// <summary>
    /// The hb_ui_geometry_s.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct hb_geometry_settings_s
    {
        /// <summary>
        ///  Anamorphic mode, see job struct anamorphic
        /// </summary>
        public int mode;

        /// <summary>
        ///  Specifies settings that shouldn't be changed
        /// </summary>
        public int keep; 

        /// <summary>
        /// use dvd dimensions to determine PAR
        /// </summary>
        public int itu_par; 

        /// <summary>
        /// pixel alignment for loose anamorphic
        /// </summary>
        public int modulus; 

        /// <summary>
        /// Cropping
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I4)]
        public int[] crop;

        /// <summary>
        /// max destination storage width
        /// </summary>
        public int maxWidth; 

        /// <summary>
        ///  max destination storage height
        /// </summary>
        public int maxHeight;

        /// <summary>
        /// Pixel aspect used in custom anamorphic
        /// </summary>
        public hb_geometry_s geometry; 
    }

    /// <summary>
    /// The hb_rational_t.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct hb_rational_t
    {
        /// <summary>
        /// The num. W
        /// </summary>
        public int num;

        /// <summary>
        /// The den. H
        /// </summary>
        public int den;
    }
}