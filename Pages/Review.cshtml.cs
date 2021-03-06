﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.ML;
using DataHappyML.Model;


namespace DataHappy.Pages
{
    public class ReviewModel : PageModel
    {
        private readonly PredictionEnginePool<ModelInput, ModelOutput> _predictionEnginePool;

        public ReviewModel(PredictionEnginePool<ModelInput, ModelOutput> predictionEnginePool)
        {
            _predictionEnginePool = predictionEnginePool;
        }

        public void OnGet()
        {

        }

        public IActionResult OnGetAnalyzeSentiment([FromQuery] string text)
        {
            if (String.IsNullOrEmpty(text)) return Content("Neutral");
            var input = new ModelInput { Comment = text };
            var prediction = _predictionEnginePool.Predict(input);
            var sentiment = Convert.ToBoolean(prediction.Prediction) ? "Toxic" : "Not Toxic";
            return Content(sentiment);
        }


    }
}