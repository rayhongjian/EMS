var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('EMS');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);