using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace UNKNOWNSPACE.Data
{
	    public class ApplicationDbContext
	    {
		        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			            : base(options)
		        {

		        }
		public DbSet<ACCOUNT> ACCOUNT {get; set;}
		public DbSet<ACTVCODE> ACTVCODE {get; set;}
		public DbSet<ACTVTYPE> ACTVTYPE {get; set;}
		public DbSet<ADMIN_CONFIG> ADMIN_CONFIG {get; set;}
		public DbSet<ASGNMNTACAT> ASGNMNTACAT {get; set;}
		public DbSet<ASGNMNTCATTYPE> ASGNMNTCATTYPE {get; set;}
		public DbSet<ASGNMNTCATVAL> ASGNMNTCATVAL {get; set;}
		public DbSet<BASETYPE> BASETYPE {get; set;}
		public DbSet<BUDGCHNG> BUDGCHNG {get; set;}
		public DbSet<CALENDAR> CALENDAR {get; set;}
		public DbSet<COSTTYPE> COSTTYPE {get; set;}
		public DbSet<CURRTYPE> CURRTYPE {get; set;}
		public DbSet<DISCUSSION> DISCUSSION {get; set;}
		public DbSet<DISCUSSION_READ> DISCUSSION_READ {get; set;}
		public DbSet<DOCCATG> DOCCATG {get; set;}
		public DbSet<DOCSTAT> DOCSTAT {get; set;}
		public DbSet<DOCUMENT> DOCUMENT {get; set;}
		public DbSet<EXPPROJ> EXPPROJ {get; set;}
		public DbSet<EXTAPP> EXTAPP {get; set;}
		public DbSet<FACTOR> FACTOR {get; set;}
		public DbSet<FACTVAL> FACTVAL {get; set;}
		public DbSet<FILTPROP> FILTPROP {get; set;}
		public DbSet<FINDATES> FINDATES {get; set;}
		public DbSet<FINTMPL> FINTMPL {get; set;}
		public DbSet<FUNDSRC> FUNDSRC {get; set;}
		public DbSet<GCHANGE> GCHANGE {get; set;}
		public DbSet<IMAGEDATA> IMAGEDATA {get; set;}
		public DbSet<ISSUHIST> ISSUHIST {get; set;}
		public DbSet<JOBSVC> JOBSVC {get; set;}
		public DbSet<LOCATION> LOCATION {get; set;}
		public DbSet<MEMOTYPE> MEMOTYPE {get; set;}
		public DbSet<NEXTKEY> NEXTKEY {get; set;}
		public DbSet<OBS> OBS {get; set;}
		public DbSet<PCATTYPE> PCATTYPE {get; set;}
		public DbSet<PCATVAL> PCATVAL {get; set;}
		public DbSet<PFOLIO> PFOLIO {get; set;}
		public DbSet<PHASE> PHASE {get; set;}
		public DbSet<POBS> POBS {get; set;}
		public DbSet<PREFER> PREFER {get; set;}
		public DbSet<PROCGROUP> PROCGROUP {get; set;}
		public DbSet<PROCITEM> PROCITEM {get; set;}
		public DbSet<PROFILE> PROFILE {get; set;}
		public DbSet<PROFPRIV> PROFPRIV {get; set;}
		public DbSet<PROJCOST> PROJCOST {get; set;}
		public DbSet<PROJECT> PROJECT {get; set;}
		public DbSet<PROJEST> PROJEST {get; set;}
		public DbSet<PROJFUND> PROJFUND {get; set;}
		public DbSet<PROJISSU> PROJISSU {get; set;}
		public DbSet<PROJPCAT> PROJPCAT {get; set;}
		public DbSet<PROJPROP> PROJPROP {get; set;}
		public DbSet<PROJRISK> PROJRISK {get; set;}
		public DbSet<PROJSHAR> PROJSHAR {get; set;}
		public DbSet<PROJTHRS> PROJTHRS {get; set;}
		public DbSet<PROJWBS> PROJWBS {get; set;}
		public DbSet<PRPFOLIO> PRPFOLIO {get; set;}
		public DbSet<RCATTYPE> RCATTYPE {get; set;}
		public DbSet<RCATVAL> RCATVAL {get; set;}
		public DbSet<RFOLIO> RFOLIO {get; set;}
		public DbSet<RISKTYPE> RISKTYPE {get; set;}
		public DbSet<ROLECATTYPE> ROLECATTYPE {get; set;}
		public DbSet<ROLECATVAL> ROLECATVAL {get; set;}
		public DbSet<ROLELIMIT> ROLELIMIT {get; set;}
		public DbSet<ROLERATE> ROLERATE {get; set;}
		public DbSet<ROLERCAT> ROLERCAT {get; set;}
		public DbSet<ROLES> ROLES {get; set;}
		public DbSet<RPT> RPT {get; set;}
		public DbSet<RPTBATCH> RPTBATCH {get; set;}
		public DbSet<RPTGROUP> RPTGROUP {get; set;}
		public DbSet<RPTLIST> RPTLIST {get; set;}
		public DbSet<RSRC> RSRC {get; set;}
		public DbSet<RSRCCURV> RSRCCURV {get; set;}
		public DbSet<RSRCRATE> RSRCRATE {get; set;}
		public DbSet<RSRCRCAT> RSRCRCAT {get; set;}
		public DbSet<RSRCROLE> RSRCROLE {get; set;}
		public DbSet<RSRCSEC> RSRCSEC {get; set;}
		public DbSet<RSRFOLIO> RSRFOLIO {get; set;}
		public DbSet<SETTINGS> SETTINGS {get; set;}
		public DbSet<SHIFT> SHIFT {get; set;}
		public DbSet<SHIFTPER> SHIFTPER {get; set;}
		public DbSet<SUMTASK> SUMTASK {get; set;}
		public DbSet<SUMTRSRC> SUMTRSRC {get; set;}
		public DbSet<TASK> TASK {get; set;}
		public DbSet<TASKACTV> TASKACTV {get; set;}
		public DbSet<TASKDOC> TASKDOC {get; set;}
		public DbSet<TASKFDBK> TASKFDBK {get; set;}
		public DbSet<TASKFIN> TASKFIN {get; set;}
		public DbSet<TASKMEMO> TASKMEMO {get; set;}
		public DbSet<TASKNOTE> TASKNOTE {get; set;}
		public DbSet<TASKPRED> TASKPRED {get; set;}
		public DbSet<TASKPROC> TASKPROC {get; set;}
		public DbSet<TASKRISK> TASKRISK {get; set;}
		public DbSet<TASKRSRC> TASKRSRC {get; set;}
		public DbSet<TASKUSER> TASKUSER {get; set;}
		public DbSet<THRSPARM> THRSPARM {get; set;}
		public DbSet<TRAKVIEW> TRAKVIEW {get; set;}
		public DbSet<TRSRCFIN> TRSRCFIN {get; set;}
		public DbSet<UDFCODE> UDFCODE {get; set;}
		public DbSet<UDFTYPE> UDFTYPE {get; set;}
		public DbSet<UDFVALUE> UDFVALUE {get; set;}
		public DbSet<UMEASURE> UMEASURE {get; set;}
		public DbSet<USERCOL> USERCOL {get; set;}
		public DbSet<USERDATA> USERDATA {get; set;}
		public DbSet<USERENG> USERENG {get; set;}
		public DbSet<USEROBS> USEROBS {get; set;}
		public DbSet<USERS> USERS {get; set;}
		public DbSet<USERSET> USERSET {get; set;}
		public DbSet<USESSION> USESSION {get; set;}
		public DbSet<VIEWPROP> VIEWPROP {get; set;}
		public DbSet<WBRSCAT> WBRSCAT {get; set;}
		public DbSet<WBSBUDG> WBSBUDG {get; set;}
		public DbSet<WBSMEMO> WBSMEMO {get; set;}
		public DbSet<WBSRSRC> WBSRSRC {get; set;}
		public DbSet<WBSRSRC_QTY> WBSRSRC_QTY {get; set;}
		public DbSet<WBSSTEP> WBSSTEP {get; set;}
	        protected override void OnModelCreating(ModelBuilder modelBuilder)
		        {
			            base.OnModelCreating(modelBuilder);
			modelBuild.Entity<ACCOUNT>.HasNoKey();
			modelBuild.Entity<ACTVCODE>.HasNoKey();
			modelBuild.Entity<ACTVTYPE>.HasNoKey();
			modelBuild.Entity<ADMIN_CONFIG>.HasNoKey();
			modelBuild.Entity<ASGNMNTACAT>.HasNoKey();
			modelBuild.Entity<ASGNMNTCATTYPE>.HasNoKey();
			modelBuild.Entity<ASGNMNTCATVAL>.HasNoKey();
			modelBuild.Entity<BASETYPE>.HasNoKey();
			modelBuild.Entity<BUDGCHNG>.HasNoKey();
			modelBuild.Entity<CALENDAR>.HasNoKey();
			modelBuild.Entity<COSTTYPE>.HasNoKey();
			modelBuild.Entity<CURRTYPE>.HasNoKey();
			modelBuild.Entity<DISCUSSION>.HasNoKey();
			modelBuild.Entity<DISCUSSION_READ>.HasNoKey();
			modelBuild.Entity<DOCCATG>.HasNoKey();
			modelBuild.Entity<DOCSTAT>.HasNoKey();
			modelBuild.Entity<DOCUMENT>.HasNoKey();
			modelBuild.Entity<EXPPROJ>.HasNoKey();
			modelBuild.Entity<EXTAPP>.HasNoKey();
			modelBuild.Entity<FACTOR>.HasNoKey();
			modelBuild.Entity<FACTVAL>.HasNoKey();
			modelBuild.Entity<FILTPROP>.HasNoKey();
			modelBuild.Entity<FINDATES>.HasNoKey();
			modelBuild.Entity<FINTMPL>.HasNoKey();
			modelBuild.Entity<FUNDSRC>.HasNoKey();
			modelBuild.Entity<GCHANGE>.HasNoKey();
			modelBuild.Entity<IMAGEDATA>.HasNoKey();
			modelBuild.Entity<ISSUHIST>.HasNoKey();
			modelBuild.Entity<JOBSVC>.HasNoKey();
			modelBuild.Entity<LOCATION>.HasNoKey();
			modelBuild.Entity<MEMOTYPE>.HasNoKey();
			modelBuild.Entity<NEXTKEY>.HasNoKey();
			modelBuild.Entity<OBS>.HasNoKey();
			modelBuild.Entity<PCATTYPE>.HasNoKey();
			modelBuild.Entity<PCATVAL>.HasNoKey();
			modelBuild.Entity<PFOLIO>.HasNoKey();
			modelBuild.Entity<PHASE>.HasNoKey();
			modelBuild.Entity<POBS>.HasNoKey();
			modelBuild.Entity<PREFER>.HasNoKey();
			modelBuild.Entity<PROCGROUP>.HasNoKey();
			modelBuild.Entity<PROCITEM>.HasNoKey();
			modelBuild.Entity<PROFILE>.HasNoKey();
			modelBuild.Entity<PROFPRIV>.HasNoKey();
			modelBuild.Entity<PROJCOST>.HasNoKey();
			modelBuild.Entity<PROJECT>.HasNoKey();
			modelBuild.Entity<PROJEST>.HasNoKey();
			modelBuild.Entity<PROJFUND>.HasNoKey();
			modelBuild.Entity<PROJISSU>.HasNoKey();
			modelBuild.Entity<PROJPCAT>.HasNoKey();
			modelBuild.Entity<PROJPROP>.HasNoKey();
			modelBuild.Entity<PROJRISK>.HasNoKey();
			modelBuild.Entity<PROJSHAR>.HasNoKey();
			modelBuild.Entity<PROJTHRS>.HasNoKey();
			modelBuild.Entity<PROJWBS>.HasNoKey();
			modelBuild.Entity<PRPFOLIO>.HasNoKey();
			modelBuild.Entity<RCATTYPE>.HasNoKey();
			modelBuild.Entity<RCATVAL>.HasNoKey();
			modelBuild.Entity<RFOLIO>.HasNoKey();
			modelBuild.Entity<RISKTYPE>.HasNoKey();
			modelBuild.Entity<ROLECATTYPE>.HasNoKey();
			modelBuild.Entity<ROLECATVAL>.HasNoKey();
			modelBuild.Entity<ROLELIMIT>.HasNoKey();
			modelBuild.Entity<ROLERATE>.HasNoKey();
			modelBuild.Entity<ROLERCAT>.HasNoKey();
			modelBuild.Entity<ROLES>.HasNoKey();
			modelBuild.Entity<RPT>.HasNoKey();
			modelBuild.Entity<RPTBATCH>.HasNoKey();
			modelBuild.Entity<RPTGROUP>.HasNoKey();
			modelBuild.Entity<RPTLIST>.HasNoKey();
			modelBuild.Entity<RSRC>.HasNoKey();
			modelBuild.Entity<RSRCCURV>.HasNoKey();
			modelBuild.Entity<RSRCRATE>.HasNoKey();
			modelBuild.Entity<RSRCRCAT>.HasNoKey();
			modelBuild.Entity<RSRCROLE>.HasNoKey();
			modelBuild.Entity<RSRCSEC>.HasNoKey();
			modelBuild.Entity<RSRFOLIO>.HasNoKey();
			modelBuild.Entity<SETTINGS>.HasNoKey();
			modelBuild.Entity<SHIFT>.HasNoKey();
			modelBuild.Entity<SHIFTPER>.HasNoKey();
			modelBuild.Entity<SUMTASK>.HasNoKey();
			modelBuild.Entity<SUMTRSRC>.HasNoKey();
			modelBuild.Entity<TASK>.HasNoKey();
			modelBuild.Entity<TASKACTV>.HasNoKey();
			modelBuild.Entity<TASKDOC>.HasNoKey();
			modelBuild.Entity<TASKFDBK>.HasNoKey();
			modelBuild.Entity<TASKFIN>.HasNoKey();
			modelBuild.Entity<TASKMEMO>.HasNoKey();
			modelBuild.Entity<TASKNOTE>.HasNoKey();
			modelBuild.Entity<TASKPRED>.HasNoKey();
			modelBuild.Entity<TASKPROC>.HasNoKey();
			modelBuild.Entity<TASKRISK>.HasNoKey();
			modelBuild.Entity<TASKRSRC>.HasNoKey();
			modelBuild.Entity<TASKUSER>.HasNoKey();
			modelBuild.Entity<THRSPARM>.HasNoKey();
			modelBuild.Entity<TRAKVIEW>.HasNoKey();
			modelBuild.Entity<TRSRCFIN>.HasNoKey();
			modelBuild.Entity<UDFCODE>.HasNoKey();
			modelBuild.Entity<UDFTYPE>.HasNoKey();
			modelBuild.Entity<UDFVALUE>.HasNoKey();
			modelBuild.Entity<UMEASURE>.HasNoKey();
			modelBuild.Entity<USERCOL>.HasNoKey();
			modelBuild.Entity<USERDATA>.HasNoKey();
			modelBuild.Entity<USERENG>.HasNoKey();
			modelBuild.Entity<USEROBS>.HasNoKey();
			modelBuild.Entity<USERS>.HasNoKey();
			modelBuild.Entity<USERSET>.HasNoKey();
			modelBuild.Entity<USESSION>.HasNoKey();
			modelBuild.Entity<VIEWPROP>.HasNoKey();
			modelBuild.Entity<WBRSCAT>.HasNoKey();
			modelBuild.Entity<WBSBUDG>.HasNoKey();
			modelBuild.Entity<WBSMEMO>.HasNoKey();
			modelBuild.Entity<WBSRSRC>.HasNoKey();
			modelBuild.Entity<WBSRSRC_QTY>.HasNoKey();
			modelBuild.Entity<WBSSTEP>.HasNoKey();
			}}}