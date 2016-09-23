function zSelect(zNodes,selectid) {
    var gat = this;
    this.zNodes = zNodes;
    this.selectid = selectid;
    this.zTreeid = selectid+"_ztree";
    this.menuContentId = this.zTreeid + "_container";
    this.onClick = function (e, treeId, treeNode) {
        //alert(123);
    };
    this.onDblClick = function (e, treeId, treeNode) {
        var zTree = $.fn.zTree.getZTreeObj(treeId);
        var nodes = zTree.getSelectedNodes();
        var namev = "";

        nodes.sort(function compare(a, b) { return a.id - b.id; });
        for (var i = 0, l = nodes.length; i < l; i++) {
            namev += nodes[i].name + ",";
        }
        if (namev.length > 0) namev = namev.substring(0, namev.length - 1);
        valv = "";
        for (var i = 0, l = nodes.length; i < l; i++) {
            valv += nodes[i].val + ",";
        }
        if (valv.length > 0) valv = valv.substring(0, valv.length - 1);

        gat.hideMenu();
        //$("#" + gat.selectid).html("<option value='" + valv + "'>" + namev + "</option>");
        $("#" + gat.selectid).val(valv);
        var spanid = gat.selectid + "_name_span";
        $("#" + spanid).remove();
        $("#" + gat.selectid).after("<span id='" + spanid + "'>" + namev + "</span>");
    };
    this.hideMenu = function () {
        $("#" + gat.menuContentId).fadeOut("fast");
        $("body").unbind("mousedown", this.onBodyDown);
    };
    this.onBodyDown = function () {
        /*alert(event.target.id);*/
        if (!(event.target.id == gat.zTreeid || event.target.id == gat.menuContentId || $(event.target).parents("#" + gat.menuContentId).length > 0)) {
            gat.hideMenu();
        }
    };
    this.showMenu = function () {
        var cityObj = $("#" + gat.selectid);
        var cityOffset = cityObj.offset();
        $("#" + gat.menuContentId).css({ left: cityOffset.left + "px", top: cityOffset.top + cityObj.outerHeight() + 10 + "px" }).slideDown("fast");

        $("body").bind("mousedown", gat.onBodyDown);
        $("#" + gat.selectid).attr('readonly', 'true');
        //var treeObj = $.fn.zTree.getZTreeObj(gat.zTreeid);
        //var node=  treeObj.getNodeByParam('val', $("#" + gat.selectid).val());
        //treeObj.selectNode(node, false);
    };
    this.beforeClick = function (treeId, treeNode) {
        //var check = (treeNode && !treeNode.isParent);
        //if (!check) alert("只能选择城市...");
        //return check;
    }
    this.init = function () {
        var setting = {
            view: {
                dblClickExpand: false
            },
            data: {
                simpleData: {
                    enable: true
                }
            },
            callback: {
                beforeClick: gat.beforeClick,
                onClick: gat.onClick,
                onDblClick:gat.onDblClick,

            }
        };/*
        <div id="parentidx_ztree_container" style="position:absolute; display:none;">
                   <ul id="parentidx_ztree" class="ztree" style="margin-top:0; width:160px;"></ul>
               </div> */
        var sss = '<div id="' + gat.menuContentId + '" style="position:absolute; display:none;">';
        sss += '<ul id="' + gat.zTreeid + '" class="ztree" style="margin-top:0; width:160px;"></ul>';
        sss += '</div>';
        var $select = $("#" + gat.selectid);
        $select.click(function () { gat.showMenu(); }).after(sss);
        $.fn.zTree.init($("#" + this.zTreeid), setting, gat.zNodes);
        
    }
}