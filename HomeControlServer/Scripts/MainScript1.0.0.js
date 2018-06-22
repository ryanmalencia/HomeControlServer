if (!String.prototype.supplant) {
    String.prototype.supplant = function (o) {
        return this.replace(/{([^{}]*)}/g,
            function (a, b) {
                var r = o[b];
                return typeof r === 'string' || typeof r === 'number' ? r : a;
            }
        );
    };
}

$(function () {

	var control = $.connection.ActivityHub, $infoTable = $('#infoTable'), rowTemplate = '<tr data-symbol="{Name}"><td width="10%">{ID}</td><td width="30%">{Account}</td><td width="30%">{Description}</td><td class="view" width="20%">{Date}</td></tr>';
	$infoTableBody = $infoTable.find('tbody');

	function init() {
		$.getJSON('http://10.0.0.136:4000/api/activity/get/', function (data) {
			var obj = JSON.parse(data);
			$infoTableBody.empty();
			$.each(obj.Agents, function () {
				var info = formatInfo(this);
				var row = rowTemplate.supplant(info);
				$infoTableBody.append(row);
			});
		});
	}

	$.connection.hub.start().done(init);
});