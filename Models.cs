// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AttributeList
    {
        public string Title { get; set; }
        public int Index { get; set; }
    }

    public class BasicSettings
    {
        public string title { get; set; }
    }

    public class ColumnList
    {
        public string Title { get; set; }
        public int Index { get; set; }
        public bool IsVisible { get; set; }
    }

    public class Data
    {
        public int MarketYearCategoryId { get; set; }
        public StudySetup StudySetup { get; set; }
        public bool HasAttribute { get; set; }
        public Settings Settings { get; set; }
        public List<UnitOfValue> UnitOfValues { get; set; }
        public List<ColumnList> ColumnList { get; set; }
        public List<YearsList> YearsList { get; set; }
        public List<DataList> DataList { get; set; }
    }

    public class DataList
    {
        public List<object> ColumnsData { get; set; }
        public YearsData YearsData { get; set; }
        public string DataRowId { get; set; }
        public object ChangeLog { get; set; }
        public bool IsNewRow { get; set; }
    }

    public class Field
    {
        public bool isVisible { get; set; }
        public bool isYearValue { get; set; }
        public string caption { get; set; }
        public string dataField { get; set; }
        public int width { get; set; }
        public string formula { get; set; }
        public bool isValue { get; set; }
        public string dataType { get; set; }
        public string fieldType { get; set; }
        public bool readOnly { get; set; }
        public List<string> yearType { get; set; }
    }

    public class HandontableSettings
    {
        public bool dropdownMenu { get; set; }
        public bool filters { get; set; }
        public bool columnSorting { get; set; }
        public bool copyPaste { get; set; }
    }

    public class Root
    {
        public int HttpStatusCode { get; set; }
        public Data Data { get; set; }
    }

    public class Settings
    {
        public BasicSettings basicSettings { get; set; }
        public HandontableSettings handontableSettings { get; set; }
        public List<Field> fields { get; set; }
    }

    public class StudySetup
    {
        public int StudyDataSetId { get; set; }
        public string StudyDataSetName { get; set; }
        public int StudyProjectId { get; set; }
        public string ProjectName { get; set; }
        public int ProjectLeadId { get; set; }
        public string ProjectLead { get; set; }
        public List<int> AnalystIdList { get; set; }
        public List<string> AnalystNameList { get; set; }
        public int AnalystId { get; set; }
        public string AnalystName { get; set; }
        public int StudyYear { get; set; }
        public int MarketId { get; set; }
        public string MarketName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public int PrefillFromId { get; set; }
        public int StudyAreaId { get; set; }
        public int ViewId { get; set; }
        public string StudyAreaName { get; set; }
        public bool IsSignOff { get; set; }
        public bool IsMidYear { get; set; }
        public int LockedForEditBy { get; set; }
        public string LockedForEditByName { get; set; }
        public string CSVAnalystIds { get; set; }
        public string CSVAnalystNames { get; set; }
        public int CalculatorId { get; set; }
    }

    public class UnitOfValue
    {
        public string Title { get; set; }
        public string Unit { get; set; }
        public int Id { get; set; }
    }

    public class YearsData
    {
        public List<object> _2017 { get; set; }
        public List<object> _2018 { get; set; }
        public List<object> _2019 { get; set; }
        public List<object> _2020 { get; set; }
        public List<object> _2021 { get; set; }
        public List<object> _2022 { get; set; }
    }

    public class YearsList
    {
        public string Year { get; set; }
        public string Type { get; set; }
        public int Index { get; set; }
        public List<AttributeList> AttributeList { get; set; }
    }

