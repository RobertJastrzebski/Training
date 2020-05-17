import unittest

class TestCase1(unittest.TestCase):

    @classmethod
    def setUpClass(cls):
        print("*****this will run only once before all test****")


    def setUp(self) :
        print("I will run one before every test")

    def test_methodA(self):
        print("Running method A")

    def test_methodB(self):
        print("Running method B")

    def tearDown(self):
        print("I will run after every test")

    @classmethod
    def tearDownClass(cls):
        print("****this will run only once after all test****")

if __name__ == '__main__':
    if __name__ == '__main__':
        unittest.main(verbosity=2)
