from selenium import webdriver
from selenium.webdriver.common.by import By
import time
from Selenium.project_1.pages.home.login_page import LoginPage
import unittest

class LoginTests(unittest.TestCase):
    baseUrl = "https://learn.letskodeit.com/"
    driver = webdriver.Chrome(executable_path="C:\\Selenium\\chromedriver.exe")
    driver.maximize_window()
    driver.implicitly_wait(4)
    lp = LoginPage(driver)

    def test_valid_login(self):
        self.driver.get(self.baseUrl)
        self.lp.login("test@email.com",'abcabc')
        result= self.lp.verifyLoginSucc()
        assert result== True
        self.driver.quit()

    def test_invalid_login(self):
        self.driver.get(self.baseUrl)
        self.lp.login("tes2343234t@email.com", 'abcabc')
        self.lp.verifyLoginFail()


if __name__ == '__main__':
    unittest.main(verbosity=2)