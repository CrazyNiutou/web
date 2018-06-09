layui.define(['layer', 'laypage'], function(exports) {
	exports('test', function() {
		$.ajax({
			type:'get',
			url:'http://localhost:55636/api/content/GetArticleList/articleType=1',
			success:function(data){
				alert("123");
			},
			error:function(){
				alert("异常！");
			}
		})
	})
})