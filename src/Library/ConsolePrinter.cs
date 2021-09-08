//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------
using System;
namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public static void Print(Recipe recipe)
        {
            Console.Write(recipe.RecipeText());
        }
    
    }
} 