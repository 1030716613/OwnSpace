layui.use(['form','layer'],function(){
    var form = layui.form
        layer = parent.layer === undefined ? layui.layer : top.layer,
        $ = layui.jquery;

    form.on("submit(addUser)",function(data){
        //弹出loading
        var index = top.layer.msg('数据提交中，请稍候',{icon: 16,time:false,shade:0.8});
        // 实际使用时的提交信息
        $.post("/User/AddUser", {
             Id: $(".userId").val(),  //Id
             UserName : $(".userName").val(),  //登录名
             UserEmail : $(".userEmail").val(),  //邮箱
             UserSex : data.field.sex,  //性别
             UserGrade : data.field.userGrade,  //会员等级
             UserStatus : data.field.userStatus,    //用户状态
             //newsTime : submitTime,    //添加时间
             UserDesc : $(".userDesc").val()   //用户简介
         },function(res){

            setTimeout(function () {
                top.layer.close(index);
                top.layer.msg("用户添加成功！");
                layer.closeAll("iframe");
                //刷新父页面
                parent.location.reload();
            }, 100);

         })
       
        return false;
    })

    //格式化时间
    function filterTime(val){
        if(val < 10){
            return "0" + val;
        }else{
            return val;
        }
    }
    //定时发布
    var time = new Date();
    var submitTime = time.getFullYear()+'-'+filterTime(time.getMonth()+1)+'-'+filterTime(time.getDate())+' '+filterTime(time.getHours())+':'+filterTime(time.getMinutes())+':'+filterTime(time.getSeconds());

})