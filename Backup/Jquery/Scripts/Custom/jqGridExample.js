function actionFormatter(cellvalue, options, rowObject) {
        var url = options.colModel.index.replace('-1', rowObject.Id);
    return '<a class="setLiveLink" href="' + url + '">Set database as Live</a>';
}