default_array = ['hello', '2', 'world', ':-)']
max_item_length = 3


def check_user_input(message):
    user_input = input(message)
    if user_input == '1' or user_input == '2' or user_input == '':
        return user_input
    else:
        return check_user_input(message)


def input_array_from_keyboard(size_array):
    input_array = []
    for i in range(size_array):
        input_array.append(input('Введите элемент массива: '))
    return input_array


def select_str_by_len_to_array(array, max_item_length):
    select_array = []
    for i in array:
        if len(i) <= max_item_length:
            select_array.append(i)
    return select_array


user_select = check_user_input('Введите: 1 - для использования массива по умолчанию. '
                                + '2 - для ввода массива с клавиатуры. (1): ')

if user_select == '2':
    size_array = int(input("Введите размер массива: "))
    array = input_array_from_keyboard(size_array)
else:
    array = default_array

new_array = select_str_by_len_to_array(array, max_item_length)

print(array)
print(new_array)