const videoElement = document.getElementsByClassName('input_video')[0];
let landmarks

const pose = new Pose({locateFile: (file) => {
  return `https://cdn.jsdelivr.net/npm/@mediapipe/pose/${file}`;
}});

pose.setOptions({
  modelComplexity: 1,
  smoothLandmarks: true,
  enableSegmentation: true,
  smoothSegmentation: true,
  minDetectionConfidence: 0.5,
  minTrackingConfidence: 0.5
});

pose.onResults(results => {
  landmarks = results.poseLandmarks
});

const camera = new Camera(videoElement, {
  onFrame: async () => {
    await pose.send({image: videoElement});
  },
  width: 1920,
  height: 1080
});

camera.start();

// setInterval(function(){ 
// }, 100);


function draw(){
  if (landmarks && landmarks.length) {
    for (let i = 0; i < landmarks.length; i++) {
      console.log(landmarks[i])
    }

    
    var x = 10*landmarks[15].x
    var y = 10*landmarks[15].y

    var pos0 = {x:x,y:y,z:landmarks[15].z};
    GlobalUnityInstance.SendMessage("DataReciiver","setNoseData9", JSON.stringify(pos0));

    // const x1 = canvasWidth * landmarks[16].x
    // const y1 = canvasHeight * landmarks[16].y
    var x1 = 10*landmarks[16].x
    var y1 = 10*landmarks[16].y

    var pos01 = {x:x1,y:y1,z:landmarks[16].z};
    GlobalUnityInstance.SendMessage("DataReciiver","setNoseData10", JSON.stringify(pos01));

    var x2 = landmarks[0].x
    var y2 = landmarks[0].y

    var pos02 = {x:x2,y:y2,z:landmarks[0].z};
    GlobalUnityInstance.SendMessage("DataReciiver","setNoseData", JSON.stringify(pos02));
  }
}