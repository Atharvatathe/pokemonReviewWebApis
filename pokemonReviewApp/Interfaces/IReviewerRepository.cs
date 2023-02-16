using pokemonReviewApp.Models;

namespace pokemonReviewApp.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int reviewerId);
        ICollection<Review> GetReviewByReviewer(int reviewerId);

        bool ReviewerExist(int reviewerId);

    }
}
