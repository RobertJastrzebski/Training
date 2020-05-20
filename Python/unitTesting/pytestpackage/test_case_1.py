import pytest

@pytest.fixture()
def setUp():
    print("\nRunning test_case_1")
    yield
    print(("\nend"))

def test_1(setUp):
    print("Running  test1")

def test_2(setUp):
    print("Running  test2")