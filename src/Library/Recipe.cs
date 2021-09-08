//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Text;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }
        

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }
         public string RecipeText()
        {   
            StringBuilder Texto = new StringBuilder($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Texto.Append($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
            return Texto.ToString();
        }
        
        public void GetProductionCost()   // este metodo funciona para devolver el costo total de la preparacion
        {
            double Total = 0;
            foreach (Step item in steps)
            {
                ProductionCost a =new ProductionCost(item);
                Console.WriteLine(a.CalCost());
                Total += a.CostoInsumos() + a.CostoEquipo();
            }
            Console.WriteLine($"Costo Total de la prepararación es de ${Total}.");
             
        }
    }
}