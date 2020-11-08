import re
import csv
from getpass import getpass
from time import sleep
from selenium.webdriver.common.keys import Keys
from selenium.common.exceptions import NoSuchElementException
from msedge.selenium_tools import Edge, EdgeOptions

def get_tweet_data(card):
    """Extract data from tweet card"""
    name = card.find_element_by_xpath('.//span').text
    try:
        username = card.find_element_by_xpath('.//span[contains(text(), "@")]').text
    except NoSuchElementException:
        return
    try:
        postdate = card.find_element_by_xpath('.//time').get_attribute('datetime')
    except NoSuchElementException:
        return
    
    comment = card.find_element_by_xpath('.//div[2]/div[2]/div[1]').text
    responding = card.find_element_by_xpath('.//div[2]/div[2]/div[2]').text
    text = comment + responding
    reply_cnt = card.find_element_by_xpath('.//div[@data-testid="reply"]').text
    retweet_cnt = card.find_element_by_xpath('.//div[@data-testid="retweet"]').text
    like_cnt = card.find_element_by_xpath('.//div[@data-testid="like"]').text

    # get a string of all emojis contained in the tweet
    """Emojis are stored as images... so I convert the filename, which is stored as unicode, into 
    the emoji character."""
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
    
    tweet = (name, username, postdate, text, emojis, reply_cnt, retweet_cnt, like_cnt)
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

# find search input and search for term
search_input = driver.find_element_by_xpath('//input[@aria-label="Search query"]')
search_input.send_keys('Pangolin for sale', Keys.RETURN)

# navigate to historical 'latest' tab
driver.find_element_by_link_text('Latest').click()

# get all tweets on the page
data = []
tweet_ids = set()
last_position = driver.execute_script("return window.pageYOffset;")
scrolling = True

while scrolling:
    page_cards = driver.find_elements_by_xpath('//div[@data-testid="tweet"]')
    for card in page_cards[-15:]:
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
        sleep(1)
        curr_position = driver.execute_script("return window.pageYOffset;")
        if last_position == curr_position:
            scroll_attempt += 1
            
            # end of scroll region
            if scroll_attempt >= 3:
                scrolling = False
                break
            else:
                sleep(1) # attempt another scroll
        else:
            last_position = curr_position
            break

# close the web driver
driver.close()

with open('turkcell_tweets.csv', 'w', newline='', encoding='utf-8') as f:
    header = ['Name', 'Username', 'Timestamp', 'Content', 'Emojis', 'Comments', 'Likes', 'Retweets']
    writer = csv.writer(f)
    writer.writerow(header)
    writer.writerows(data)