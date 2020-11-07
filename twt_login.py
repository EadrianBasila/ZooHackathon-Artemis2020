from selenium.webdriver.common.keys import Keys
from msedge.selenium_tools import Edge, EdgeOptions

options = EdgeOptions()
options.use_chromium = True
driver = Edge(options=options)

# navigate to login screen
driver.get('https://www.twitter.com/login')
driver.maximize_window()

email = driver.find_element_by_xpath('//input[@name="session[username_or_email]"]')
email.send_keys('artemis11620@gmail.com')
password = driver.find_element_by_xpath('//input[@name="session[password]"]')
password.send_keys('@rtemiS1120', Keys.RETURN)
