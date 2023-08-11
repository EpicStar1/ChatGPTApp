*This project is developed in Asp.net core 6.0. You must have .Net core 6.0 SDK installed on your system.* 
To install .net core 6 execute below command in powershell

choco install dotnet-6.0-sdk --version=6.0.408


*Some useful links*

https://writesonic.com/blog/how-to-train-chatgpt-own-data/#building-a-custom-chatgpt-trained-chatbot-using-chatgpt-api
https://www.dotnet4techies.com/2023/04/how-to-build-ai-chatbot-in-aspnet-core.html

*chatGPT links*

ChatGPT: https://platform.openai.com/docs/guides/gpt

API Documentation: https://platform.openai.com/docs/api-reference/introduction

Community: https://community.openai.com/

To check chatGPT server status: https://status.openai.com/

To generate API keys: https://platform.openai.com/account/api-keys

For chatGPT pricing visit: https://openai.com/pricing

=============================================================================== R & D =================================================================

1. python app

take reference of below site
https://beebom.com/how-train-ai-chatbot-custom-knowledge-base-chatgpt-api/

Run below commands in powershell

1. choco install python

2. python -m pip install -U pip

3. pip install --upgrade openai

4. pip install gpt_index==0.4.24

5. pip install langchain==0.0.148

6. pip install PyPDF2

7. pip install PyCryptodome

8. pip install gradio

To set API key environment variable execute - setx OPENAI_API_KEY “<yourkey>”

Set the environment variable for pip. edit system path variable and paste C:\Python312\Scripts\pip

===================================================================== OpenAI Cli ================================================================

https://platform.openai.com/docs/guides/fine-tuning

1. openai tools fine_tunes.prepare_data -f C:\Users\apandey\Desktop\docs\train-demo.json
2. openai api fine_tunes.create -t C:\Users\apandey\Desktop\document\train-demo_prepared.jsonl -m davinci --suffix "epicstar-model"
	
    2a. openai api fine_tunes.create -t C:\Users\apandey\Desktop\document\train-demo_prepared.jsonl -m ada --suffix "epicstar-model"
3. openai api fine_tunes.results -i ft-eGO9U2WIjZzzGkuv8ADLBYHE
4. openai api fine_tunes.follow -i ft-eGO9U2WIjZzzGkuv8ADLBYHE
5. openai api fine_tunes.list

{
  "object": "list",
  "data": [    
    {
      "object": "fine-tune",
      "id": "ft-eGO9U2WIjZzzGkuv8ADLBYHE",
      "hyperparams": {
        "n_epochs": 4,
        "batch_size": 1,
        "prompt_loss_weight": 0.01,
        "learning_rate_multiplier": 0.1
      },
      "organization_id": "org-NBfeAUiFgatBn23rWtpJBfGo",
      "model": "ada",
      "training_files": [
        {
          "object": "file",
          "id": "file-VqHQ31EK11sHv5Z18iQipsXz",
          "purpose": "fine-tune",
          "filename": "train-demo_prepared.jsonl",
          "bytes": 264,
          "created_at": 1691665912,
          "status": "processed",
          "status_details": null
        }
      ],
      "validation_files": [],
      "result_files": [
        {
          "object": "file",
          "id": "file-tHCmzEG4g4uipbrTD25TQ6qz",
          "purpose": "fine-tune-results",
          "filename": "compiled_results.csv",
          "bytes": 662,
          "created_at": 1691713838,
          "status": "processed",
          "status_details": null
        }
      ],
      "created_at": 1691665913,
      "updated_at": 1691713839,
      "status": "succeeded",
      "fine_tuned_model": "ada:ft-personal:epicstar-model-2023-08-11-00-30-38"
    },
    {
      "object": "fine-tune",
      "id": "ft-OqxGI9fARS8WwkVIFpyI7ZJE",
      "hyperparams": {
        "n_epochs": 4,
        "batch_size": 1,
        "prompt_loss_weight": 0.01,
        "learning_rate_multiplier": 0.1
      },
      "organization_id": "org-NBfeAUiFgatBn23rWtpJBfGo",
      "model": "ada",
      "training_files": [
        {
          "object": "file",
          "id": "file-VqHQ31EK11sHv5Z18iQipsXz",
          "purpose": "fine-tune",
          "filename": "train-demo_prepared.jsonl",
          "bytes": 264,
          "created_at": 1691665912,
          "status": "processed",
          "status_details": null
        }
      ],
      "validation_files": [],
      "result_files": [
        {
          "object": "file",
          "id": "file-lT3NXg1qF8c87lU05B1hMGT5",
          "purpose": "fine-tune-results",
          "filename": "compiled_results.csv",
          "bytes": 677,
          "created_at": 1691725775,
          "status": "processed",
          "status_details": null
        }
      ],
      "created_at": 1691666775,
      "updated_at": 1691725775,
      "status": "succeeded",
      "fine_tuned_model": "ada:ft-personal:epicstar-model-2023-08-11-03-49-34"
    },
    {
      "object": "fine-tune",
      "id": "ft-JKzMYx0AuiJJl05EAxeLtjb9",
      "hyperparams": {
        "n_epochs": 4,
        "batch_size": 1,
        "prompt_loss_weight": 0.01,
        "learning_rate_multiplier": 0.1
      },
      "organization_id": "org-NBfeAUiFgatBn23rWtpJBfGo",
      "model": "davinci",
      "training_files": [
        {
          "object": "file",
          "id": "file-VqHQ31EK11sHv5Z18iQipsXz",
          "purpose": "fine-tune",
          "filename": "train-demo_prepared.jsonl",
          "bytes": 264,
          "created_at": 1691665912,
          "status": "processed",
          "status_details": null
        }
      ],
      "validation_files": [],
      "result_files": [
        {
          "object": "file",
          "id": "file-WlWnnYs2NWB27py5N2JYWJC0",
          "purpose": "fine-tune-results",
          "filename": "compiled_results.csv",
          "bytes": 786,
          "created_at": 1691727097,
          "status": "processed",
          "status_details": null
        }
      ],
      "created_at": 1691670940,
      "updated_at": 1691727098,
      "status": "succeeded",
      "fine_tuned_model": "davinci:ft-personal:epicstar-model-2023-08-11-04-11-36"
    }
  ]
}

6. openai api fine_tunes.get -i ft-eGO9U2WIjZzzGkuv8ADLBYHE
{
  "object": "fine-tune",
  "id": "ft-eGO9U2WIjZzzGkuv8ADLBYHE",
  "hyperparams": {
    "n_epochs": 4,
    "batch_size": 1,
    "prompt_loss_weight": 0.01,
    "learning_rate_multiplier": 0.1
  },
  "organization_id": "org-NBfeAUiFgatBn23rWtpJBfGo",
  "model": "ada",
  "training_files": [
    {
      "object": "file",
      "id": "file-VqHQ31EK11sHv5Z18iQipsXz",
      "purpose": "fine-tune",
      "filename": "train-demo_prepared.jsonl",
      "bytes": 264,
      "created_at": 1691665912,
      "status": "processed",
      "status_details": null
    }
  ],
  "validation_files": [],
  "result_files": [
    {
      "object": "file",
      "id": "file-tHCmzEG4g4uipbrTD25TQ6qz",
      "purpose": "fine-tune-results",
      "filename": "compiled_results.csv",
      "bytes": 662,
      "created_at": 1691713838,
      "status": "processed",
      "status_details": null
    }
  ],
  "created_at": 1691665913,
  "updated_at": 1691713839,
  "status": "succeeded",
  "fine_tuned_model": "ada:ft-personal:epicstar-model-2023-08-11-00-30-38",
  "events": [
    {
      "object": "fine-tune-event",
      "level": "info",
      "message": "Created fine-tune: ft-eGO9U2WIjZzzGkuv8ADLBYHE",
      "created_at": 1691665913
    },
    {
      "object": "fine-tune-event",
      "level": "info",
      "message": "Fine-tune costs $0.00",
      "created_at": 1691713498
    },
    {
      "object": "fine-tune-event",
      "level": "info",
      "message": "Fine-tune enqueued. Queue number: 9",
      "created_at": 1691713498
    },
    {
      "object": "fine-tune-event",
      "level": "info",
      "message": "Fine-tune is in the queue. Queue number: 8",
      "created_at": 1691713504
    },
    {
      "object": "fine-tune-event",
      "level": "info",
      "message": "Fine-tune is in the queue. Queue number: 7",
      "created_at": 1691713505
    },
    {
      "object": "fine-tune-event",
      "level": "info",
      "message": "Fine-tune is in the queue. Queue number: 6",
      "created_at": 1691713516
    },
    {
      "object": "fine-tune-event",
      "level": "info",
      "message": "Fine-tune is in the queue. Queue number: 5",
      "created_at": 1691713560
    },
    {
      "object": "fine-tune-event",
      "level": "info",
      "message": "Fine-tune is in the queue. Queue number: 4",
      "created_at": 1691713579
    },
    {
      "object": "fine-tune-event",
      "level": "info",
      "message": "Fine-tune is in the queue. Queue number: 3",
      "created_at": 1691713589
    },
    {
      "object": "fine-tune-event",
      "level": "info",
      "message": "Fine-tune is in the queue. Queue number: 2",
      "created_at": 1691713613
    },
    {
      "object": "fine-tune-event",
      "level": "info",
      "message": "Fine-tune is in the queue. Queue number: 1",
      "created_at": 1691713758
    },
    {
      "object": "fine-tune-event",
      "level": "info",
      "message": "Fine-tune is in the queue. Queue number: 0",
      "created_at": 1691713803
    },
    {
      "object": "fine-tune-event",
      "level": "info",
      "message": "Fine-tune started",
      "created_at": 1691713807
    },
    {
      "object": "fine-tune-event",
      "level": "info",
      "message": "Completed epoch 1/4",
      "created_at": 1691713821
    },
    {
      "object": "fine-tune-event",
      "level": "info",
      "message": "Completed epoch 2/4",
      "created_at": 1691713821
    },
    {
      "object": "fine-tune-event",
      "level": "info",
      "message": "Completed epoch 3/4",
      "created_at": 1691713822
    },
    {
      "object": "fine-tune-event",
      "level": "info",
      "message": "Completed epoch 4/4",
      "created_at": 1691713822
    },
    {
      "object": "fine-tune-event",
      "level": "info",
      "message": "Uploaded model: ada:ft-personal:epicstar-model-2023-08-11-00-30-38",
      "created_at": 1691713838
    },
    {
      "object": "fine-tune-event",
      "level": "info",
      "message": "Uploaded result file: file-tHCmzEG4g4uipbrTD25TQ6qz",
      "created_at": 1691713839
    },
    {
      "object": "fine-tune-event",
      "level": "info",
      "message": "Fine-tune succeeded",
      "created_at": 1691713839
    }
  ]
}

7. Delete fine-tune
 
	openai api models.delete -i ft-5hcgzg136LcKZbwRXWcflHKF
  
	openai api models.delete -i ft-JKzMYx0AuiJJl05EAxeLtjb9
 
	openai api models.delete -i ft-sfWTYjWA0LrNq6ASTPFZf1xV
  
	openai api models.delete -i ft-S6FrF8TZYaQo4yyUuO4FFDVq
 
	openai api models.delete -i ft-OqxGI9fARS8WwkVIFpyI7ZJE
 
	openai api models.delete -i ft-eGO9U2WIjZzzGkuv8ADLBYHE
 
	openai api models.delete -i ft-0VLjEsUk3IeZilauIC7KTQlO
	
	
=================================================================== OpenAI API List ==================================================================


1. List of files

	curl https://api.openai.com/v1/files -H "Authorization: Bearer $env:OPENAI_API_KEY"	
	{
	  "object": "list",
	  "data": [
		{
		  "object": "file",
		  "id": "file-tHCmzEG4g4uipbrTD25TQ6qz",
		  "purpose": "fine-tune-results",
		  "filename": "compiled_results.csv",
		  "bytes": 662,
		  "created_at": 1691713838,
		  "status": "processed",
		  "status_details": null
		},
		{
		  "object": "file",
		  "id": "file-lT3NXg1qF8c87lU05B1hMGT5",
		  "purpose": "fine-tune-results",
		  "filename": "compiled_results.csv",
		  "bytes": 677,
		  "created_at": 1691725775,
		  "status": "processed",
		  "status_details": null
		},
		{
		  "object": "file",
		  "id": "file-WlWnnYs2NWB27py5N2JYWJC0",
		  "purpose": "fine-tune-results",
		  "filename": "compiled_results.csv",
		  "bytes": 786,
		  "created_at": 1691727097,
		  "status": "processed",
		  "status_details": null
		},
		{
		  "object": "file",
		  "id": "file-VqHQ31EK11sHv5Z18iQipsXz",
		  "purpose": "fine-tune",
		  "filename": "train-demo_prepared.jsonl",
		  "bytes": 264,
		  "created_at": 1691665912,
		  "status": "processed",
		  "status_details": null
		}
	  ]
	}
2. Upload file 

	curl https://api.openai.com/v1/files -H "Authorization: Bearer $env:OPENAI_API_KEY" -F purpose="fine-tune" -F file="@mydata.jsonl"
3. Delete file
 
	curl https://api.openai.com/v1/files/file-8vHPZ3YpqPqkgTyGXpHjjB2m -X DELETE -H "Authorization: Bearer $env:OPENAI_API_KEY"
4. Retrieve file
 
	curl https://api.openai.com/v1/files/file-VqHQ31EK11sHv5Z18iQipsXz -H "Authorization: Bearer $env:OPENAI_API_KEY"
5. Retrieve file content (It is only for paid accounts)

	curl https://api.openai.com/v1/files/file-VqHQ31EK11sHv5Z18iQipsXz/content -H "Authorization: Bearer $env:OPENAI_API_KEY" > file.jsonl


1.Create fine-tune
	curl https://api.openai.com/v1/fine-tunes -H "Content-Type: application/json" -H "Authorization: Bearer $env:OPENAI_API_KEY" -d '{  "training_file": "file-VqHQ31EK11sHv5Z18iQipsXz"}'

2. List fine-tunes
	curl https://api.openai.com/v1/fine-tunes -H "Authorization: Bearer $env:OPENAI_API_KEY"

3. Retrieve fine-tune
	curl https://api.openai.com/v1/fine-tunes/ft-OqxGI9fARS8WwkVIFpyI7ZJE -H "Authorization: Bearer $env:OPENAI_API_KEY"

4. List fine-tune events
	curl https://api.openai.com/v1/fine-tunes/ft-OqxGI9fARS8WwkVIFpyI7ZJE/events -H "Authorization: Bearer $env:OPENAI_API_KEY"

5. Cancel fine-tune
	curl https://api.openai.com/v1/fine-tunes/ft-OqxGI9fARS8WwkVIFpyI7ZJE/cancel -H "Authorization: Bearer $env:OPENAI_API_KEY"


1. call chatGpt 

  1a. Using chat/completions
    curl https://api.openai.com/v1/chat/completions -H "Content-Type: application/json" -H "Authorization: Bearer $env:OPENAI_API_KEY" -d '{  "model": "gpt-3.5-turbo", "messages": [{"role": "user", "content": "Write program in c# to find prime number"}], "temperature": 0.7}'	
	
    curl https://api.openai.com/v1/chat/completions -H "Content-Type: application/json" -H "Authorization: Bearer $env:OPENAI_API_KEY" -d '{  "model": "davinci:ft-personal:epicstar-model-2023-08-11-04-11-36", "messages": [{"role": "user", "content": "Who is founder of microsoft"}], "temperature": 0.7}'
 
  1b. Using completions		
	curl https://api.openai.com/v1/completions -H "Authorization: Bearer $env:OPENAI_API_KEY" -H "Content-Type: application/json" -d '{"prompt": "Rockwell MO pillar", "model": "ada:ft-personal:epicstar-model-2023-08-11-00-30-38","max_tokens": 100,"temperature": 0.7}'


=================================================================== FAQ ================================================================

If your custom trained DaVinci model is not responding with the expected results, there could be several factors contributing to this issue. Here are some steps you can take to diagnose and address the problem:

1. Review Training Data: Check the quality and relevance of the training data you used to fine-tune the DaVinci model. Ensure that the training data is diverse, representative of the task you want the model to perform, and properly labeled.

2. Hyperparameters and Training: Verify the hyperparameters you used during the fine-tuning process. Experiment with different settings for learning rate, batch size, and regularization to find the best configuration for your specific task.

3. Model Architecture: Consider whether the base model architecture is suitable for the task you are fine-tuning. If necessary, explore different architectures or adjust the layers to better match your requirements.

4. Overfitting: Overfitting occurs when a model performs well on the training data but poorly on new, unseen data. Make sure you are not overfitting your custom model by using techniques like dropout, regularization, and early stopping.

5. Evaluation and Validation: Use appropriate evaluation metrics and validation techniques to assess the model's performance during fine-tuning. This helps you catch any issues early and ensure the model is learning the desired behavior.

6. Data Preprocessing: Verify that your input data is properly preprocessed before feeding it to the model. Incorrect tokenization or formatting can lead to unexpected responses.

7. Checkpoint Selection: If you are using checkpoints from different stages of training, select the checkpoint that performs best on your validation data.

8. Fine-Tuning Objective: Ensure that the fine-tuning objective is well-defined and aligns with the task you want the model to perform. Clear instructions and objectives are crucial for guiding the fine-tuning process.

9. Domain Adaptation: If the model is not responding well to real-world user inputs, it might need additional fine-tuning or adaptation to the specific domain or context of your application.

10. Safety and Guidelines: Make sure that the model's responses adhere to safety guidelines and desired ethical standards. Consider implementing content filtering or moderation to ensure appropriate outputs.

11. Iterate and Experiment: Fine-tuning is an iterative process. Experiment with different approaches, data subsets, and training strategies to improve the model's performance.

12. Consult Documentation and Support: Check the official documentation for the specific model and fine-tuning process you are using. If you're still encountering issues, consider reaching out to OpenAI's support for guidance.

13. Remember that creating and fine-tuning models can involve trial and error. It's important to be patient, persistent, and willing to experiment to achieve the desired results.


Q2. GPT-3 models training data format example

Ans. GPT-3 models, including the DaVinci model, are typically not fine-tuned by individual users, and OpenAI primarily focuses on training and fine-tuning these models on a large scale.
However, I can provide you with a generic example of how training data might be structured for a text generation task that you could potentially use with GPT-3 models:

Some EXamples are: 

{"prompt": "Write a short story about a mysterious island.", "completion": "On a remote island shrouded in mist, whispers of ancient secrets echo through the dense foliage. As explorers ventured into its heart, they discovered ruins of an ancient civilization, untouched by time..."}
{"prompt": "Describe the process of photosynthesis.", "completion": "Photosynthesis is a complex biochemical process that occurs in plants, allowing them to convert sunlight, carbon dioxide, and water into glucose and oxygen. This energy-conversion process is crucial for the sustenance of plant life and the production of oxygen in our atmosphere..."}
{"prompt": "Explain the theory of relativity.", "completion": "The theory of relativity, developed by Albert Einstein, revolutionized our understanding of the fundamental nature of space, time, and gravity. It consists of two main components: the special theory of relativity, which deals with objects moving at constant velocity, and the general theory of relativity, which encompasses the effects of gravity..."}

{"prompt": "Translate the following English text to French: 'Hello, how are you?'", "completion": "Bonjour, comment ça va ?"}
{"prompt": "Translate 'apple' to Spanish.", "completion": "manzana"}
{"prompt": "Translate 'cat' to German.", "completion": "Katze"}
{"prompt": "Translate 'book' to Italian.", "completion": "libro"}

{"messages": [{"role": "system", "content": "You are a technical support assistant for a software company."}]}
{"messages": [{"role": "user", "content": "I'm having trouble connecting to the internet."}]}
{"messages": [{"role": "assistant", "content": "I'm sorry to hear that. Let's troubleshoot the issue. Have you tried restarting your router?"}]}
{"messages": [{"role": "user", "content": "Yes, I've restarted the router, but the problem persists."}]}
{"messages": [{"role": "assistant", "content": "Thank you for trying that. Could you please check if all the cables are properly connected and there are no physical issues with the router?"}]}
{"messages": [{"role": "user", "content": "I've checked the cables, and everything seems fine."}]}
{"messages": [{"role": "assistant", "content": "Okay. Let's try resetting the network settings on your device. Go to Settings > Network > Reset Network Settings."}]}
{"messages": [{"role": "user", "content": "I've reset the network settings, but I still can't connect."}]}
{"messages": [{"role": "assistant", "content": "I see. It might be a broader connectivity issue. Is your internet service provider experiencing any outages in your area?"}]}

{"messages": [{"role": "system", "content": "You are a helpful assistant that provides information about animals."}]}
{"messages": [{"role": "user", "content": "Tell me about lions."}]}
{"messages": [{"role": "assistant", "content": "Lions are large carnivorous mammals belonging to the Felidae family."}]}
{"messages": [{"role": "user", "content": "What do lions eat?"}]}
{"messages": [{"role": "assistant", "content": "Lions primarily eat large ungulates like zebras, wildebeests, and buffalo."}]}
{"messages": [{"role": "user", "content": "Where do lions live?"}]}
{"messages": [{"role": "assistant", "content": "Lions are found in grasslands and savannas across Africa and a small population exists in the Gir Forest National Park in India."}]}

{"context": "Romeo and Juliet is a tragedy written by William Shakespeare.", "question": "Who is the author of Romeo and Juliet?", "answer": "William Shakespeare"}
{"context": "The Earth orbits the Sun and takes about 365.25 days to complete one orbit.", "question": "How long does it take for the Earth to orbit the Sun?", "answer": "365.25 days"}
{"context": "Photosynthesis is the process by which green plants use sunlight to synthesize foods with the help of chlorophyll.", "question": "What is photosynthesis?", "answer": "The process by which green plants use sunlight to synthesize foods with the help of chlorophyll."}


Q3. what is steps to train own custom model using this data

Ans. As of my last knowledge update in September 2021, OpenAI primarily offers access to pre-trained models and fine-tuning is generally not available for individual users. 
If you are interested in training your own custom model using your own data, you would need to follow a general process similar to traditional machine learning model development. 
However, this process may not be directly applicable to OpenAI's models like GPT-3 or DaVinci.

Here's a high-level overview of the steps involved in training a custom model using your own data:

1. Data Collection: Gather a high-quality and diverse dataset that is relevant to the task you want the model to perform. This dataset could be in the form of text, images, or other data types depending on your use case.

2. Data Preprocessing: Clean and preprocess the data to remove noise, handle missing values, and convert it into a suitable format for training. This could involve tasks such as tokenization, normalization, and data augmentation.

3. Model Selection: Choose a machine learning model architecture that is appropriate for your task and data. This could be a neural network architecture, decision tree, support vector machine, etc., depending on your problem.

4. Model Design: Design the architecture of your model, including the number of layers, activation functions, and any other relevant components. For deep learning models, you may need to define the structure of neural layers.

5. Training: Split your dataset into training, validation, and possibly test sets. Train your model on the training data using appropriate optimization algorithms and loss functions. Monitor the model's performance on the validation set to prevent overfitting.

6. Hyperparameter Tuning: Experiment with different hyperparameters (learning rate, batch size, regularization strength, etc.) to find the best configuration that optimizes your model's performance.

7. Evaluation: Evaluate your model's performance on the test set or other appropriate evaluation metrics. Make sure it's achieving the desired level of accuracy or effectiveness for your task.

8. Fine-Tuning: Based on the evaluation results, you might need to iterate on the model design, data preprocessing, and hyperparameters to improve performance.

9. Deployment: Once you're satisfied with your model's performance, deploy it for real-world use. This could involve integrating it into a web application, mobile app, or other systems.

Please note that while the above steps outline a general approach to training custom machine learning models, it may not be applicable to fine-tuning OpenAI's models like GPT-3 or DaVinci. These models are typically pre-trained on massive datasets and fine-tuned by OpenAI using their resources.

For information on using OpenAI's models, I recommend referring to the official OpenAI documentation and resources. If there have been any updates or changes since my last update, please consult OpenAI directly or refer to their official communication for the latest information.
