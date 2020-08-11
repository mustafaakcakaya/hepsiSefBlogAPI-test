using hepsiSefBlog.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace hepsiSefBlog.Data.Context
{
    public interface IRecipeRepository
    {
        int Add(Recipe recipe);
        Recipe GetRecipeByFilter(Expression<Func<Recipe, bool>> filter);
        int Update(Recipe entity);
        int Delete(Recipe recipe);

        ICollection<Recipe> GetRecipes(Expression<Func<Recipe, bool>> filter = null);

    }
}
