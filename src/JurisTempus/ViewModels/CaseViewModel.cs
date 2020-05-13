using JurisTempus.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace JurisTempus.ViewModels
{
  public class CaseViewModel
  {
    public int Id { get; set; }
    public string FileNumber { get; set; }
    public CaseStatus Status { get; set; }

  }
}
