﻿$(document).ready(function () {
    $("a[href$='" + window.location.pathname + "']").addClass('is-active');
});