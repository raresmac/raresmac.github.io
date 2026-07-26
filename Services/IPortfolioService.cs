namespace raresmac.github.io.Services;

using raresmac.github.io.Models;

public interface IPortfolioService
{
    IReadOnlyList<string> GetCategories();
    IReadOnlyList<Project> GetProjects();
    IReadOnlyList<Project> GetProjectsByCategory(string category);
    IReadOnlyList<Certification> GetCertifications();
}
