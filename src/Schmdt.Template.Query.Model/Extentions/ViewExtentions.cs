using Schmidt.Template.Query.Model.Model;
using Schmidt.Template.Query.Model.ViewModel;

namespace Schmidt.Template.Query.Model.Extentions
{
    public static class ViewExtentions
    {
        public static PersonViewModel ToViewModel(this Person person) => person;
    }
}
