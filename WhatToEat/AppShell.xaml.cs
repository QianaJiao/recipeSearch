﻿using System;
using System.Collections.Generic;
using Recipes.Models;
using Recipes.ViewModels;
using Recipes.Views;
using Microsoft.Maui.Controls;

namespace Recipes
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(SearchResultsPage), typeof(SearchResultsPage));
            Routing.RegisterRoute(nameof(SearchResultDetailPage), typeof(SearchResultDetailPage));
            Routing.RegisterRoute(nameof(RecipeDetailPage), typeof(RecipeDetailPage));
            Routing.RegisterRoute(nameof(NewRecipePage), typeof(NewRecipePage));
            Routing.RegisterRoute(nameof(EditRecipePage), typeof(EditRecipePage));
        }

        public static RecipeData Data { get; set; }

        public static Item[] MyRecipes { get; set; }

    }
}
