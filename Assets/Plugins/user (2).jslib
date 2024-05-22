mergeInto(LibraryManager.library, {

    getUserNickname: function () {
        return window.x1_unity_data.user.nickname
    }

});


function getUserNickname() {
    return window.x1_unity_data.user.nickname
}