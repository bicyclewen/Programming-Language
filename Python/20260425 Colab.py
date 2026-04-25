from google import genai

client = genai.Client(api_key="我的API_KEY")

response = client.models.generate_content(
    model="gemini-3-flash-preview", contents="告訴我中山醫在哪裡?"
)
print(response.text)
