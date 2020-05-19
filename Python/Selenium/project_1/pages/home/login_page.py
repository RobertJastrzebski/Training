from selenium.webdriver.common.by import By

class LoginPage():

    def __init__(self,driver):
        self.driver = driver
    #Locators
    _login_link= "Login"
    _email_field= "user_email"
    _password_field="user_password"
    _login_button= "commit"
    _logOut_text="//div[@id='navbar']//a[contains(text(),'Log Out')]"
    _invalid_text="//div[contains(text(),'Invalid email or password')]"

    def getLoginLink(self):
        return self.driver.find_element(By.LINK_TEXT,self._login_link )

    def getEmailField(self):
        return self.driver.find_element(By.ID, self._email_field)

    def getPasswordField(self):
        return self.driver.find_element(By.ID, self._password_field)

    def getLoginButton(self):
        return self.driver.find_element(By.NAME, self._login_button)

    def clickLoginLink(self):
        return self.getLoginLink().click()

    def enterEmail(self,email):
        return self.getEmailField().send_keys(email)

    def enterPassword(self,password):
        return self.getPasswordField().send_keys(password)

    def clickLoginButton(self):
        return self.getLoginButton().click()


    def login(self,email, password):
        self.clickLoginLink()
        self.enterEmail(email)
        self.enterPassword(password)
        self.clickLoginButton()

    def verifyLoginSucc(self):
        self.driver.find_element(By.CSS_SELECTOR, ".gravatar").click()
        logOut = self.driver.find_element(By.XPATH, self._logOut_text)
        if logOut is not None:
            return True
        False

    #### wersja 2.
    # def verifyLoginFail(self):
    #     result = self.driver.find_element(By.XPATH,self._invalid_text)
    #     if result is not None:
    #         print("Logowanie nie powiodło sie Test Pass")
    #     else:
    #         print("nie znaleziono widomosci o nieprawidłowych danych logowania ")

    def verifyLoginFail(self):
        result = self.driver.find_element(By.XPATH,self._invalid_text)
        if result is not None:
            return True
        False








