$(function () {
    $(".button-collapse").sideNav();
    $(".dropdown-button").dropdown();
});

$('.chips').material_chip();

$('.chips-placeholder-cat').material_chip({
    placeholder: 'Введите категории для задач',
    secondaryPlaceholder: '+Категории проекта',
});

$('.chips-placeholder-pri').material_chip({
    placeholder: 'Введите приоритеты задач',
    secondaryPlaceholder: '+Категории проекта',
});

$('.chips-placeholder-sta').material_chip({
    placeholder: 'Введите состояния задач',
    secondaryPlaceholder: '+Категории проекта',
});

$('.chips-placeholder-ttt').material_chip({
    placeholder: 'Введите причины завершения задач',
    secondaryPlaceholder: '+Категории проекта',
});
