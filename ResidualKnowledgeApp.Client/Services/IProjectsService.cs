﻿using ResidualKnowledgeApp.Shared.DTO;
using ResidualKnowledgeApp.Shared.ViewModels;

namespace ResidualKnowledgeApp.Client.Services
{
    public interface IProjectsService
    {
        event Action OnChange;

        List<ProjectOverviewDTO> Projects { get; }

        Task<List<ProjectOverviewDTO>> GetProjectsAsync();

        Task<List<ProjectOverviewDTO>> DeleteProject(int id);

        ///////////////////////////////////////////////////////

        UserChoice UserChoice { get; }

        ProjectDetailsDTO Project { get; }

        CurriculumDTO Curriculum { get; }

        List<CheckingDisciplineDetailsDTO> CheckingDisciplines { get; }

        List<DisciplineDTO> DisciplinesForSelection { get; }

        HashSet<CompetenceWithDisciplineDTO> CompetencesForSelection { get; }

        HashSet<CompetenceWithDisciplineDTO> SelectedCompetences { get; }

        public string SheetLink { get; set; }

        Task SaveMarkCriteria(int checkingDisciplineId, List<MarkCriterion> markCriteria);

        Task<ProjectDetailsDTO> CreateProject(CreateProjectVM project);

        Task LoadProject(int projectId);

        Task<List<ProjectOverviewDTO>> UpdateProject(Project project, int id);

        Task<CurriculumDTO> UploadCurriculumAsync(Curriculum curriculum, HttpContent content);
        
        Task SetCheckingDisciplines(IEnumerable<DisciplineDTO> selectedDisciplines);

        Task SetCheckingCompetences(IEnumerable<CompetenceWithDisciplineDTO> selectedCompetences);

        Task UpdateCheckingDisciplineFiles(int id, CheckingDisciplineDetailsDTO updated);

        Task UploadFileAsync(HttpContent content);

        Task GetCheckingDisciplines();

        Task GetSheetLink(int projectId);
    }
}