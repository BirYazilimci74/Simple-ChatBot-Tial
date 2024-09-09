from transformers import pipeline
from flask import Flask, jsonify

generator = pipeline("text-generation")

app = Flask(__name__)

@app.route('/get_response/<string:query>', methods=['GET'])
def get_chatbot_response(query):
    response = generator(query)
    response = response[0]["generated_text"]
    return jsonify({"response": response})

if __name__ == '__main__':
    app.run(debug=True)


