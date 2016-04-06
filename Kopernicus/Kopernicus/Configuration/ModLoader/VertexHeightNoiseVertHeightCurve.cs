﻿/**
 * Kopernicus Planetary System Modifier
 * ====================================
 * Created by: BryceSchroeder and Teknoman117 (aka. Nathaniel R. Lewis)
 * Maintained by: Thomas P., NathanKell and KillAshley
 * Additional Content by: Gravitasi, aftokino, KCreator, Padishar, Kragrathea, OvenProofMars, zengei, MrHappyFace
 * ------------------------------------------------------------- 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston,
 * MA 02110-1301  USA
 * 
 * This library is intended to be used as a plugin for Kerbal Space Program
 * which is copyright 2011-2015 Squad. Your usage of Kerbal Space Program
 * itself is governed by the terms of its EULA, not the license above.
 * 
 * https://kerbalspaceprogram.com
 */

using System;
using UnityEngine;

namespace Kopernicus
{
    namespace Configuration
    {
        namespace ModLoader
        {
            [RequireConfigType(ConfigType.Node)]
            public class VertexHeightNoiseVertHeightCurve : ModLoader<PQSMod_VertexHeightNoiseVertHeightCurve>
            {
                // curve
                [ParserTarget("curve", optional = true)]
                public FloatCurveParser curve
                {
                    get { return mod.curve != null ? new FloatCurve(mod.curve.keys) : new FloatCurve(); }
                    set { mod.curve = value.curve.Curve; }
                }
                
                // Where the height starts
                [ParserTarget("heightStart", optional = true)]
                public NumericParser<float> heightStart
                {
                    get { return mod.heightStart; }
                    set { mod.heightStart = value; }
                }

                // Where the height ends
                [ParserTarget("heightEnd", optional = true)]
                public NumericParser<float> heightEnd
                {
                    get { return mod.heightEnd; }
                    set { mod.heightEnd = value; }
                }

                // The deformity of the simplex terrain
                [ParserTarget("deformity", optional = true)]
                public NumericParser<float> deformity
                {
                    get { return mod.deformity; }
                    set { mod.deformity = value; }
                }

                // The frequency of the simplex terrain
                [ParserTarget("frequency", optional = true)]
                public NumericParser<float> frequency
                {
                    get { return mod.frequency; }
                    set { mod.frequency = value; }
                }

                // Octaves of the simplex height
                [ParserTarget("octaves", optional = true)]
                public NumericParser<int> octaves
                {
                    get { return mod.octaves; }
                    set { mod.octaves = value; }
                }

                // Persistence of the simplex height
                [ParserTarget("persistance", optional = true)]
                public NumericParser<float> persistance
                {
                    get { return mod.persistance; }
                    set { mod.persistance = value; }
                }

                // The seed of the simplex height
                [ParserTarget("seed", optional = true)]
                public NumericParser<int> seed
                {
                    get { return mod.seed; }
                    set { mod.seed = value; }
                }

                // lacunarity
                [ParserTarget("lacunarity", optional = true)]
                public NumericParser<float> lacunarity
                {
                    get { return mod.lacunarity; }
                    set { mod.lacunarity = value; }
                }

                // mode
                [ParserTarget("mode", optional = true)]
                public EnumParser<LibNoise.Unity.QualityMode> mode
                {
                    get { return mod.mode; }
                    set { mod.mode = value; }
                }

                // mode
                [ParserTarget("noiseType", optional = true)]
                public EnumParser<PQSMod_VertexHeightNoiseVertHeightCurve.NoiseType> noiseType
                {
                    get { return mod.noiseType; }
                    set { mod.noiseType = value; }
                }
            }
        }
    }
}
