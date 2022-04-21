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

        /// <summary>
        /// Le asigno a la clase Recipe la función de armar el texto de la receta
        /// por Expert, ya que es la clase que posee los conocimientos necesarios
        /// para llevar acabo la función.
        /// </summary>
        /// <returns></returns>
        public StringBuilder GetRecipeText()
        {
            StringBuilder text = new StringBuilder($"Receta de {this.FinalProduct.Description}:\n");
            foreach (Step step in this.steps)
            {
                text.Append($"{step.Quantity} de '{step.Input.Description}' " + $"usando '{step.Equipment.Description}' durante {step.Time}\n");
            }
            return text;
        }
    }
}