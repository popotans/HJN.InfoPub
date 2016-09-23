var njh = njh || {};
njh.ajaxget = function (url, datatype, param, callback) {
    $.ajax({
        type: "GET",
        url: url,
        data: param,
        dataType: datatype,
        success: function (d) { callback(d); },
        error: function (d) {
            alert(d);
        }
    });
}
njh.ajaxpost = function (url, datatype, param, callback) {
    $.ajax({
        type: "POST",
        url: url,
        data: param,
        dataType: datatype,
        success: function (d) { callback(d); },
        error: function (de) {
            var ss = de.responseText;
            ss = njh.clearhtml(ss);
            console.log(de);
            alert(ss);
        }
    });
}
njh.ajaxsubmit = function (formid, datatype, callback) {
    var $f = $("#" + formid);
    var formaction = $f.attr('action');
    var data = $f.serialize();
    njh.ajaxpost(formaction, datatype, data, callback);
}
njh.regsubmit = function (btnid, formid, datatype, callback) {
    $("#" + btnid).click(function () {
        njh.ajaxsubmit(formid, datatype, callback);
        return false;
    });
}

njh.trim = function (a) {
    return (a && a.replace ? a : "").replace(/(^\s*)|(\s*$)/g, "");
}
njh.isurl = function (a) {
    return (a || "").replace(/http?:\/\/[\w.]+[^ \f\n\r\t\v\"\\\<\>\[\]\u2100-\uFFFF]*/, "url") == "url";
}
njh.strlen = function (a) {
    return (a || "").replace(/[^\x00-\xFF]/g, "aa").length;
}
njh.clearhtml = function (a) {
    return a ? a.replace(/<[^>]*>/g, "") : a;
}
njh.getStyle = function getStyle(a, b) {
    var c = a && (a.currentStyle ? a.currentStyle : a.ownerDocument.defaultView.getComputedStyle(a, null));
    return c && c[b] || "";
}
njh.htmldecode = function htmlDecode(a) {
    return a && a.replace ? (a.replace(/&nbsp;/gi, " ").replace(/&lt;/gi, "<").replace(/&gt;/gi, ">").replace(/&amp;/gi, "&").replace(/&quot;/gi, "\"").replace(/&#39;/gi, "'")) : a;
}
njh.htmlencode = function (a) {
    return a && a.replace ? (a.replace(/&/g, "&amp;").replace(/\"/g, "&quot;").replace(/</g, "&lt;").replace(/>/g, "&gt;").replace(/\'/g, "&#39;")) : a;
}
njh.limitstring = function (b, a) {
    var f = b || "",
    d = a || 20,
    c = f.length;
    if (c > d) {
        var e = Math.floor((d - 3) / 2);
        f = f.substring(0, e) + "..." + f.slice(-e, c);
    }
    return f;
};




