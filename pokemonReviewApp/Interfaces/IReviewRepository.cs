﻿using pokemonReviewApp.Models;

namespace pokemonReviewApp.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReview(int reviewId);
        ICollection<Review> GetReviewOfAPokemon(int pokeId);
        bool ReviewExist(int reviewId);
    }
}
