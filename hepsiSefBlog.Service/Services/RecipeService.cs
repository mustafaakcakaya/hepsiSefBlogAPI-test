using hepsiSefBlog.Data.Context;
using hepsiSefBlog.Data.Context.Repos;
using hepsiSefBlog.Data.Entities;
using hepsiSefBlog.Service.Model.Request;
using hepsiSefBlog.Service.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace hepsiSefBlog.Service.Services
{
    public class RecipeService
    {
        private readonly RecipeRepository _repository;
        //private readonly MockRecipeRepository _repository;
        public RecipeService(RecipeRepository repository)
        {
            _repository = repository;
        }
        //TODO : check expression entity type
        public List<RecipeResponse> GetAll(Expression<Func<Recipe, bool>> filter = null)
        {
            var recipes = _repository.GetRecipes(filter).ToList().Select(x => new RecipeResponse
            {
                Id = x.Id,
                Title = x.Title,
                HowTo = x.HowTo,
                ImageUrlList = x.ImageUrlList,
                Ingredients = x.Ingredients,
                Tags = x.Tags
            }).ToList();

            return recipes;
        }
        public RecipeResponse Get(int id)
        {
            var recipeEntity = _repository.GetRecipeByFilter(x=>x.Id == id);
            return new RecipeResponse
            {
                Id = recipeEntity.Id,
                Title = recipeEntity.Title,
                HowTo = recipeEntity.HowTo,
                ImageUrlList = recipeEntity.ImageUrlList,
                Ingredients = recipeEntity.Ingredients,
                Tags = recipeEntity.Tags
            };
        }
        public List<RecipeResponse> Query(RecipeQueryRequest recipeQuery)
        {
            return _repository.GetRecipes(x => x.Id == recipeQuery.Id || x.Tags.Contains(recipeQuery.Tag))
                .ToList().Select(x => new RecipeResponse
                {
                    Id = x.Id,
                    Title = x.Title,
                    HowTo = x.HowTo,
                    ImageUrlList = x.ImageUrlList,
                    Tags = x.Tags,
                    Ingredients = x.Ingredients
                }).ToList();
        }
        //int Add(Recipe recipe)
        //{

        //}

        //int Update(Recipe entity)
        //{

        //}
        //int Delete(Recipe recipe)
        //{

        //}

    }
}
