using ACME.LearningCenterPlatform.API.Publishing.Domain.Model.Aggregates;

namespace ACME.LearningCenterPlatform.API.Publishing.Domain.Repostiories;

public interface ITutorialRepository
{
    Task<Tutorial?> FindByCategoryIdAsync(int categoryId);
    
}