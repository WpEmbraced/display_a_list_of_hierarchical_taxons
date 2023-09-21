@if (Model.Item.Fields.Category != null && Model.Item.GetHierarchicalTaxons("Category").Count() > 0) {
    var taxons = Model.Item.GetHierarchicalTaxons("Category").Where(c => c.Parent != null && c.Parent.Name.Equals("interest-groups")).Select(t => t.Title).ToList();
    if (taxons != null) {
        <div>
        @foreach (string oneTaxon in taxons) {
            <span>@oneTaxon</span>
        }
        </div>
    }
}
