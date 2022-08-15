using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Dash360.Models
{
    public class Snapshot
    {
        [Required]
        public int ID { get; set; }
        
        public String Application { get; set; }

        [Required]
        public String Name { get; set; }

        public String Description { get; set; }

        public DateTime Date { get; set; }

        public String OriginalName { get; set; }

        public String UnitTimePhase { get; set; }

        public String NonLaborUnitTimePhase { get; set; }

        public String TravelUnitTimePhase { get; set; }

        public int? ContingencyTable { get; set; }

        public int? ResourceFile { get; set; }

        public int? WBSCodeFile { get; set; }
        public int? WPCodeFile { get; set; }
        public int? EstimatorFile { get; set; }
        public int? ActivityCodeFile { get; set; }
        public int? BasisCodeFile { get; set; }
        public int? Locked { get; set; }

        public String EstimateGrid1Alias { get; set; }
        public String EstimateGrid1Units { get; set; }
        public String EstimateGrid2Alias { get; set; }
        public String EstimateGrid2Units { get; set; }
        public String EstimateGrid3Alias { get; set; }
        public String EstimateGrid3Units { get; set; }

        public int? RegistrySetID { get; set; }

        public RegistrySet registrySet { get; set; }

        public String CalendarOrFiscalYear { get; set; }

        public int FiscalYearStartMonth { get; set; }

        public bool ProjectNeedsRecalculating { get; set; } = false;

        public bool ReportWbsSummaryCostType { get; set; }
        public int ReportWbsSummaryCostTypeNotebookField { get; set; }
        public bool ReportWbsSummaryEstimateWithDescription { get; set; }
        public bool LockSchedule { get; set; }

        public DateTime StatusDate { get; set; }
        public DateTime? ReportingPeriod { get; set; }

        public String EVBudgetColor { get; set; }
        public String EVEarnedColor { get; set; }
        public String EVActualColor { get; set; }

        public bool IsDefaultProject { get; set; }

        public String FundingSource { get; set; }

        public int? NumHoursWorkDay { get; set; }

        public String WorkDays { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public List<RiskThreshold> RiskThresholds { get; set; }
        public List<NotebookCategorySnapshot> NotebookCategorySnapshots { get; set; }
        public List<WBSNotebookCategorySnapshot> WBSNotebookCategorySnapshots { get; set; }
        public List<ResourceAssignmentNotebookCategorySnapshot> ResourceAssignmentNotebookCategorySnapshots { get; set; }
        public List<RiskRegisterNotebookCategorySnapshot> RiskRegisterNotebookCategorySnapshots { get; set; }
        public List<ControlAccountNotebookCategorySnapshot> ControlAccountNotebookCategorySnapshots { get; set; }


        [ForeignKey("WBSCodeFile")]
        public CodeFile WBSFile { get; set; }

        [ForeignKey("WPCodeFile")]
        public CodeFile WPFile { get; set; }

        [ForeignKey("ResourceFile")]
        public ResourceFile ResourceCodeFile { get; set; }

        [ForeignKey("EstimatorFile")]
        public CodeFile EstimatorCodeFile { get; set; }

        [ForeignKey("ActivityCodeFile")]
        public CodeFile ActivityFile { get; set; }

        [ForeignKey("BasisCodeFile")]
        public CodeFile BasisFile { get; set; }

        [ForeignKey("ContingencyTable")]
        public ContingencySource ContingencyFile { get; set; }

        public List<WorkPackagePermissions> WorkPackagePermissions { get; set; }
        
        public List<CostEstimate> CostEstimates { get; set; }
        public List<RiskIdPrefix> RiskIdPrefixes { get; set; }
        public List<UncertaintyClass> UncertaintyClasses { get; set; }
        
        public List<Holiday> Holidays { get; set; }

        public List<CostClass> CostClasses { get; set; }

        public SnapshotContract Contract { get; set; }

        public List<SnapshotReportingCalendar> ReportingCalendars { get; set; }

        [JsonIgnore]
        public virtual ICollection<ResourceAssignment> ResourceAssignments { get; set; }

    }
}
