
from tenacity import retry


def sun_items(arrayInput):
    le = len(arrayInput)
    resultSum = 0
    index = 0

    while index < len:
        resultSum += arrayInput[index]
        index += 1

    return resultSum
