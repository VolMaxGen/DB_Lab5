﻿using lab5.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace lab5.Models.IngridientViewModels
{
    public class FilterIngridientViewModel
    {
        public SelectList Ingridients { get; private set; }
        public int? SelectedIngridient { get; private set; }
        public string SelectedName { get; private set; }

        public FilterIngridientViewModel(List<Ingridient> ingridients, int? ingridient, string name)
        {
            ingridients.Insert(0, new Ingridient { Name = "All", Id = -1 });
            Ingridients = new SelectList(ingridients, "Id", "Name", ingridient);
            SelectedIngridient = ingridient;
            SelectedName = name;
        }
    }
}
