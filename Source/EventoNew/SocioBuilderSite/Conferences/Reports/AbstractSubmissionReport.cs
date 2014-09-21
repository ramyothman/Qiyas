using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace SocioBuilderSite.Conferences.Reports
{
    public partial class AbstractSubmissionReport : DevExpress.XtraReports.UI.XtraReport
    {
        public AbstractSubmissionReport()
        {
            InitializeComponent();
        }

        public void LoadData(BusinessLogicLayer.Entities.Conference.Abstracts currentAbstract)
        {
            xrcellAbstractBackground.Html = currentAbstract.Background;
            xrcellAbstractConclusion.Html = currentAbstract.Conclusions;
            xrcellAbstractMethods.Html = currentAbstract.Methods;
            xrcellAbstractResults.Html = currentAbstract.Results;
            //cellAbstractTitle.Visible = false;
            //cellAbstractTitle.Text = currentAbstract.AbstractTitle;
            xrcellAbstractTitle.Html = "<div style=\"font-size:19pt;font-family:Arial;\">" + currentAbstract.AbstractTitle + "</div>";
            string _abstractAuthors = "";
            string _abstractAuthorsInfo = "";
            List<string> symbols = new List<string>();
            symbols.Add("~");
            symbols.Add("^");
            symbols.Add("*");
            symbols.Add("$");
            int i = 0;
            foreach (BusinessLogicLayer.Entities.Conference.AbstractAuthors a in currentAbstract.CurrentAbstractAuthors)
            {
                if (i == 0)
                {
                    _abstractAuthors += String.Format("{0} {1} {2},", a.Title, a.FirstName, a.FamilyName);
                    _abstractAuthorsInfo += String.Format("Department of {0}, {1}, {2}, {3},", a.AffilitationDepartment, a.AffilitationInstitutionHospital, a.AffilitationCity, a.AffilitationCountry);
                    i++;
                    continue;
                }
                else
                {
                    _abstractAuthors += String.Format("{0}{1} {2} {3},", symbols[i], a.Title, a.FirstName, a.FamilyName);
                    _abstractAuthorsInfo += String.Format("{0}Department of {1}, {2}, {3}, {4},", symbols[i], a.AffilitationDepartment, a.AffilitationInstitutionHospital, a.AffilitationCity, a.AffilitationCountry);
                    i++;
                }
                if (i % 4 == 0)
                    i = 0;
            }
            _abstractAuthors = _abstractAuthors.Remove(_abstractAuthors.Length - 1, 1);
            _abstractAuthorsInfo = _abstractAuthorsInfo.Remove(_abstractAuthorsInfo.Length - 1, 1);
            cellAuthorName.Text = _abstractAuthors;
            cellAuthorInformation.Text = _abstractAuthorsInfo;
            cellAbstractCategory.Text = currentAbstract.CurrentConferenceCategory.CategoryName;
            cellAbstractKeywords.Text = currentAbstract.AbstractKeywords;
        }

    }
}
