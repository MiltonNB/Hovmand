using Windows.UI.Xaml;
using AddOns.UI.Implementation;
using Commands.Implementation;
using ViewModel.App.Implementation;
using Hovmand.Model.Catalog.DomainCatalogs;

namespace Hovmand.ViewModel.App
{
    public class FileViewModel : AppViewModelBase
    {
        private bool _isLoading;
        private bool _isSaving;
        private bool _isEditing;
        private bool _isDeleting;

        public FileViewModel()
        {
            _isLoading = false;
            _isSaving = false;
            _isEditing = false;
            _isDeleting = false;

            AddCommands();
        }

        public bool IsWorking
        {
            get { return _isLoading || _isSaving; }
        }


        public string LoadingText
        {
            get
            {
                if (_isLoading)
                {
                    return "Loading data...";
                }
                if (_isSaving)
                {
                    return "Saving data...";
                }
                if (_isEditing)
                {
                    return "Editing data...";
                }
                if (_isDeleting)
                {
                    return "Deleting data...";
                }
                return "";
            }
        }

        private void OnLoadingBegins()
        {
            _isLoading = true;
            UpdateOnStateChange();
        }

        private void OnLoadingEnds()
        {
            _isLoading = false;
            UpdateOnStateChange();
        }

        private void OnSavingBegins()
        {
            _isSaving = true;
            UpdateOnStateChange();
        }

        private void OnSavingEnds()
        {
            _isSaving = false;
            UpdateOnStateChange();
        }

        private void OnEditingBegins()
        {
            _isEditing = true;
            UpdateOnStateChange();
        }

        private void OnEditingEnds()
        {
            _isEditing = false;
            UpdateOnStateChange();
        }

        private void OnDeletingBegins()
        {
            _isDeleting = true;
            UpdateOnStateChange();
        }

        private void OnDeletingEnds()
        {
            _isDeleting = false;
            UpdateOnStateChange();
        }

        private void UpdateOnStateChange()
        {
            OnPropertyChanged(nameof(IsWorking));
            OnPropertyChanged(nameof(LoadingText));
        }

        public override void AddCommands()
        {
            NavigationCommands.Add("Load", new RelayCommandAsync(async () =>
            {
                OnLoadingBegins();
                DialogWithReturnValue.ReturnValueType retVal = await DialogWithReturnValue.PresentDialogWithReturnValue("Are you sure you want to load data?", "LOAD");
                if (retVal == DialogWithReturnValue.ReturnValueType.OK)
                {
                    DomainModel.Instance.LoadEnds += OnLoadingEnds;
                    //await DomainModel.Instance.LoadAsync();
                }
                else
                {
                    OnLoadingEnds();
                }
            }));

            NavigationCommands.Add("Save", new RelayCommandAsync(async () =>
            {
                OnSavingBegins();
                DialogWithReturnValue.ReturnValueType retVal = await DialogWithReturnValue.PresentDialogWithReturnValue("Are you sure you want to save?", "SAVE");
                if (retVal == DialogWithReturnValue.ReturnValueType.OK)
                {
                    DomainModel.Instance.LoadEnds += OnSavingEnds;
                    //await DomainModel.Instance.SaveAsync();
                }
                else
                {
                    OnSavingEnds();
                }
            }));

            NavigationCommands.Add("Edit", new RelayCommandAsync(async () =>
            {
                OnSavingBegins();
                DialogWithReturnValue.ReturnValueType retVal = await DialogWithReturnValue.PresentDialogWithReturnValue("Are you sure you want to edit?", "Edit");
                if (retVal == DialogWithReturnValue.ReturnValueType.OK)
                {
                    DomainModel.Instance.LoadEnds += OnSavingEnds;
                    //await DomainModel.Instance.SaveAsync();
                }
                else
                {
                    OnSavingEnds();
                }
            }));

            NavigationCommands.Add("Delete", new RelayCommandAsync(async () =>
            {
                OnSavingBegins();
                DialogWithReturnValue.ReturnValueType retVal = await DialogWithReturnValue.PresentDialogWithReturnValue("Are you sure you want to delete", "DELETE");
                if (retVal == DialogWithReturnValue.ReturnValueType.OK)
                {
                    DomainModel.Instance.LoadEnds += OnSavingEnds;
                    //await DomainModel.Instance.SaveAsync();
                }
                else
                {
                    OnSavingEnds();
                }
            }));

            NavigationCommands.Add("Cancel", new RelayCommandAsync(async () =>
            {
                DialogWithReturnValue.ReturnValueType retVal = await DialogWithReturnValue.PresentDialogWithReturnValue("Are you sure you want to Cancel?", "CANCEL");
                if (retVal == DialogWithReturnValue.ReturnValueType.OK)
                {
                    Application.Current.Exit();
                }
            }));
        }
    }
}