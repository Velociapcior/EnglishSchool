var $grid = $('.grid').masonry({
    columnWidth: 10,
    itemSelector: '.grid-item',
    gutter: 10,
    resize: true,
});

$grid.on('click', '.grid-item-content', function (event) {
    $(event.currentTarget).parent('.grid-item').toggleClass('is-expanded');
    $grid.masonry();
});
