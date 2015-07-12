Handlebars.registerHelper('foreach', function (context, options) {
    var fn = options.fn, inverse = options.inverse;
    var i = 0, ret = "", data;

    if (options.data) {
        data = Handlebars.createFrame(options.data);
    }

    if (context && typeof context === 'object') {
        if (context instanceof Array) {
            for (var j = context.length; i < j; i++) {
                if (data) {
                    data.index = i;
                    data.first = i === 0;
                    data.last = i === j - 1;
                    data.naturalndex = i + 1;
                }
                ret = ret + fn(context[i], { data: data });
            }
        } else {
            for (var key in context) {
                if (context.hasOwnProperty(key)) {
                    if (data) { data.key = key; }
                    ret = ret + fn(context[key], { data: data });
                    i++;
                }
            }
        }
    }

    if (i === 0) {
        ret = inverse(this);
    }

    return ret;
});

Handlebars.registerHelper('render', function (template, context) {
    var data = {};
    if (arguments !== null && typeof arguments !== "undefined") {
        if (arguments.length === 3) {
            if (arguments[2].data !== null || typeof arguments[2].data !== "undefined") {
                data = arguments[2].data;
            }
        }
    }
    var ret = template(context, { data: data });
    return new Handlebars.SafeString(ret);
});

Handlebars.registerHelper('for', function (len, context, options) {
    var ret = "", data = {};
    for (var cnt = 1; cnt <= len; cnt++) {
        data.index = cnt;
        data.zeroIndex = cnt - 1;
        data.first = cnt === 1;
        data.last = cnt === len;
        ret += options.fn(context, { data: data });
    }
    return ret;
});

Handlebars.registerHelper('last', function (array) {
    return array[array.length - 1];
});


Handlebars.registerHelper('sType', function (context) {
    if (context == "air")
        return "icon_cat_air";
    else if (context == "hotel" || context == "vacation")
        return "icon_cat_hotel";
    else if (context == "villas")
        return "icon_cat_hideaways";
    else if (context == "car")
        return "icon_cat_car";
    else if (context == "activity")
        return "icon_cat_activities";

});


Handlebars.registerHelper('equal', function (lvalue, rvalue, options) {
    if (arguments.length < 3)
        throw new Error("Handlebars Helper equal needs 2 parameters");
    if (lvalue != rvalue) {
        return options.inverse(this);
    } else {
        return options.fn(this);
    }
});

Handlebars.registerHelper('list', function (context, options) {
    var ret = "";
    var tem1 = "<li><label class='control-label'>";
    var tem2 = "</label></li>";
    for (var cnt = 1; cnt <= context.length; cnt++) {
        ret += tem1;
        ret += options.fn({ data: { error: context[cnt] } });
        ret += tem2;
    }
    return new Handlebars.SafeString(ret);
});

Handlebars.registerHelper('iterate', function (context, options) {
    var ret = "", data = {}, j = 0;

    if (context && typeof context === 'object') {
        if (context instanceof Array) {
            for (var i = 1; i <= context.length; i++) {
                if (data) {
                    data.index = i;
                }
                ret = ret + options.fn(context[j], { data: data });
                j++;
            }
        }
    }
    return ret;
});

Handlebars.registerHelper('compare', function (lvalue, rvalue, operator, options) {
    if (arguments.length < 4)
        throw new Error("Handlebars Helper compare needs 3 parameters");

    switch (operator) {
        case "==":
            if (lvalue == rvalue) {
                return options.fn(this);
            }
            else {
                return options.inverse(this);
            }
            break;

        case "<=":
            if (lvalue <= rvalue) {
                return options.fn(this);
            }
            else {
                return options.inverse(this);
            }
            break;

        case ">=":
            if (lvalue >= rvalue) {
                return options.fn(this);
            }
            else {
                return options.inverse(this);
            }
            break;

        case ">":
            if (lvalue > rvalue) {
                return options.fn(this);
            }
            else {
                return options.inverse(this);
            }
            break;

        case "<":
            if (lvalue < rvalue) {
                return options.fn(this);
            }
            else {
                return options.inverse(this);
            }
            break;

        case "!=":
            if (lvalue != rvalue) {
                return options.fn(this);
            }
            else {
                return options.inverse(this);
            }
            break;
        case "btw":
            if (lvalue <= options.data.index && rvalue > options.data.index) {
                return options.fn(this);
            }
            else {
                return options.inverse(this);
            }
            break;
        default: throw new Error("Handlebars Helper compare doesn't support given operator :" + operator);
    }
});