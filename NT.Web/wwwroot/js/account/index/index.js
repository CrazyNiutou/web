$(function () {
    $("#btnLogin").click(function () {
        var password = $("#txtPwd").val();
        var username = $("#txtUserName").val();
        var url = "login?username=" + username + "&pwd=" + password + "&home/index";
        $.ajax({
            type: "GET",
            url: url,
            //data: {userName:text,pwd:text1},
            contentType: "application/json;charset=utf-8",
            dataType: "json",
            success: function (data) {
                console.log(data);
                window.location.href = data;
            },
            error: function (err) {
                console.log(err); 
            }
        });
    })
})