using hepsiSefBlog.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace hepsiSefBlog.Data.Context.Repos
{
    public class RecipeRepository : IRecipeRepository
    {
        //veritabanı içeriği nesnesi
        private readonly BlogDbContext _context;
        public RecipeRepository(BlogDbContext context)
        {
            _context = context;
        }
        public int Add(Recipe recipe)
        {
            _context.Entry(recipe).State = EntityState.Added;
            return _context.SaveChanges();
        }
        public Recipe GetRecipeByFilter(Expression<Func<Recipe, bool>> filter)
        {
            //INFO: null gidebilir.
            //TODO: service'de kontrol edilmeli.
            return _context.Recipe.Where(filter).FirstOrDefault();
        }

        public int Update(Recipe entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return _context.SaveChanges();
        }

        public int Delete(Recipe recipe)
        {
            _context.Entry(recipe).State = EntityState.Deleted;
            return _context.SaveChanges();
        }

        public ICollection<Recipe> GetRecipes(Expression<Func<Recipe, bool>> filter = null)
        {
            if (filter == null)
                return _context.Recipe.ToList();

            return _context.Recipe.Where(filter).ToList();
        }

    }
}