from selenium import webdriver
import os
from selenium.webdriver.common.by import By
from selenium.webdriver.support.select import Select
import time


class Chrome():

    def test(self):

        url = "https://letskodeit.teachable.com/pages/practice"
        # driverlocation = "E:\\2. Tester manualny\\Gitgub Repository\\Python\\Selenium\\Chromedriver.exe"

        os.environ["webdriver.chrome.driver"] = executable_path="C:\\Selenium\\chromedriver.exe"
        driver = webdriver.Chrome(executable_path="C:\\Selenium\\chromedriver.exe")
        driver.maximize_window()
        driver.get(url)
        driver.implicitly_wait(5)

        title= driver.title
        url=driver.current_url
        print(title)
        print('currentęą URL :' + url)

        element_byId= driver.find_element_by_id("name")
        if element_byId is not None:
            print("znalazl po id ")

        elementByName= driver.find_element_by_name("show-hide")
        if elementByName is not None:
            print("znalazl po name")

        elementByXpatch= driver.find_element_by_xpath("//input[@id='name']")
        if elementByXpatch is not None:
            print("znalazlem po xpath")


        elementByCss= driver.find_element_by_css_selector("#displayed-text")
        if elementByCss is not None:
            print("znalazlem po css")

        #
        # elementByLinkText = driver.find_element_by_link_text("Sign Up")
        # if elementByLinkText is not None:
        #     print("znalazlem po link text")
        #
        # elementByPartialLinkText = driver.find_element_by_partial_link_text("     ")
        # if elementByPartialLinkText is not None:
        #     print("znalazlem po partial link text")

        elementByClass= driver.find_element_by_class_name("displayed-class")
        elementByClass.send_keys("TestTestTestTestTestTestTestTestTest")
        if elementByClass is not None:
            print("znalazlem po class name")

        elementByTagName= driver.find_element_by_tag_name('h1')
        text= elementByTagName.text
        if elementByTagName is not None:
            print(f"znalazlem po tag {text}")

        elementByClassBy= driver.find_element(By.ID,"name")
        if elementByClass is not None:
            print("znalazlem po class name")

        elementsByClass= driver.find_elements_by_class_name("inputs")
        if elementsByClass is not None:
            length=len(elementsByClass)
            print(f"elements by class is  {length}")
        driver.quit()

chrome = Chrome()



chrome.test()
