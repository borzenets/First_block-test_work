array = ['hello', '2', 'world', ':-)']
max_item_length = 3


def check_user_input(message):
    user_input = input(message)
    if user_input == '1' or user_input == '2' or user_input == '':
        return user_input
    else:
        return check_user_input(message)


def input_array_from_keyboard(size_array):
    user_array = []
    for i in range(size_array):
        user_array[i] = input('Введите элемент массива: ')
    return user_array


user_select = check_user_input('Введите: 1 - для использования массива по умолчанию. '
                                + '2 - для ввода массива с клавиатуры. (1): ')

print(user_select)
