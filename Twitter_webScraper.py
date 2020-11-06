import re
import csv
from time import sleep
from selenium.webdriver.common.keys import Keys
from selenium.common.exceptions import NoSuchElementException
from msedge.selenium_tools import Edge, EdgeOptions

# data collection functions
def get_tweet_data(card):
    name = card.find_element_by_xpath('.//span').text
    try:
        username = card.find_element_by_xpath('.//span[contains(text(), "@")]').text
    except NoSuchElementException:
        return
    try:
        posteddate = card.find_element_by_xpath('.//time').get_attribute('datetime')
    except NoSuchElementException:
        return
    
    text = card.find_element_by_xpath('.//div[2]/div[2]/div[1]').text
    attachment = card.find_element_by_xpath('.//div[2]/div[2]/div[2]').text
    content = text + attachment
    
    # get a string of all emojis contained in the tweet
    """Emojis are stored as images"""
    emoji_tags = card.find_elements_by_xpath('.//img[contains(@src, "emoji")]')
    emoji_list = []
    for tag in emoji_tags:
        filename = tag.get_attribute('src')
        try:
            emoji = chr(int(re.search(r'svg\/([a-z0-9]+)\.svg', filename).group(1), base=16))
        except AttributeError:
            continue
        if emoji:
            emoji_list.append(emoji)
    emojis = ' '.join(emoji_list)
    
    tweet = (name, username, posteddate, content, emojis)
    return tweet

# create instance of web driver
options = EdgeOptions()
options.use_chromium = True
driver = Edge(options=options)

# navigate to login screen
driver.get('https://www.twitter.com/login')
driver.maximize_window()

# login account
email = driver.find_element_by_xpath('//input[@name="session[username_or_email]"]')
email.send_keys('artemis11620@gmail.com')
password = driver.find_element_by_xpath('//input[@name="session[password]"]')
password.send_keys('@rtemiS1120', Keys.RETURN)

# find search input and search for term (sample term only)
search_input = driver.find_element_by_xpath('//input[@aria-label="Search query"]')
search_input.send_keys('pangolin for sale', Keys.RETURN)

'''NOTE: KINDLY CHECK THIS PART IF IT WORKS TO YOU. gumana sakin nung una, 
may nagupdate ata sa system ko kaya ewan ko na assjksk'''
# navigate to 'latest' tab
driver.find_element_by_link_text('Latest').click()
'''-------------------------------------'''

# get all tweets on the page
data = []
tweet_ids = set()
last_position = driver.execute_script("return window.pageYOffset;")
scrolling = True

while scrolling:
    page_cards = driver.find_elements_by_xpath('//div[@data-testid="tweet"]')
    for card in page_cards[:5]:
        tweet = get_tweet_data(card)
        if tweet:
            tweet_id = ''.join(tweet)
            if tweet_id not in tweet_ids:
                tweet_ids.add(tweet_id)
                data.append(tweet)
            
    scroll_attempt = 0
    while True:
        # check scroll position
        driver.execute_script('window.scrollTo(0, document.body.scrollHeight);')
        sleep(2)
        curr_position = driver.execute_script("return window.pageYOffset;")
        if last_position == curr_position:
            scroll_attempt += 1
            
            # end of scroll region
            if scroll_attempt >= 3:
                scrolling = False
                break
            else:
                sleep(2) # attempt another scroll
        else:
            last_position = curr_position
            break

# close the web driver
driver.close()

# install csv extension and data preview for tabulated data
with open('turkcell_tweets.csv', 'w', newline='', encoding='utf-8') as f:
    header = ['Name', 'Username', 'Timestamp', 'Content', 'Emojis']
    writer = csv.writer(f)
    writer.writerow(header)
    writer.writerows(data)