define(["homescreenSettings","userSettingsBuilder","dom","globalize","loading","userSettings","listViewStyle"],function(HomescreenSettings,userSettingsBuilder,dom,globalize,loading,currentUserSettings){"use strict";return function(view,params){var homescreenSettingsInstance,userId=params.userId||ApiClient.getCurrentUserId(),userSettings=userId===ApiClient.getCurrentUserId()?currentUserSettings:new userSettingsBuilder,autoSave=!0;view.addEventListener("viewshow",function(){homescreenSettingsInstance||(homescreenSettingsInstance=new HomescreenSettings({serverId:ApiClient.serverId(),userId:userId,element:view.querySelector(".homeScreenSettingsContainer"),userSettings:userSettings,enableSaveButton:!autoSave,enableSaveConfirmation:!autoSave})),homescreenSettingsInstance.loadData()}),view.addEventListener("viewbeforehide",function(){autoSave&&homescreenSettingsInstance&&homescreenSettingsInstance.submit()}),view.addEventListener("viewdestroy",function(){homescreenSettingsInstance&&(homescreenSettingsInstance.destroy(),homescreenSettingsInstance=null)})}});