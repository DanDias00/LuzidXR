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
let one = {handposeValues: {one :{x:0,y:0,z:0}}};

function draw(){
  if (landmarks && landmarks.length) {
    for (let i = 0; i < landmarks.length; i++) {
      one.handposeValues["data"+i] = {x:10*landmarks[i].x, y:10*landmarks[i].y, z:1*landmarks[i].z}
      GlobalUnityInstance.SendMessage("DataReceiver","keypointData", JSON.stringify(one.handposeValues));
    }
  }
}


    // var lShoulx = 10*landmarks[11].x;
    // var lShouly = 10*landmarks[11].y;
    // var lShoul = {x:lShoulx, y:lShouly, z:1*landmarks[11].z};
    // GlobalUnityInstance.SendMessage("DataReciiver","keypointData11", JSON.stringify(lShoul));
    // var rShoulx = 10*landmarks[12].x;
    // var rShouly = 10*landmarks[12].y;
    // var rShoul = {x:rShoulx, y:rShouly, z:1*landmarks[12].z};
    // GlobalUnityInstance.SendMessage("DataReciiver","keypointData12", JSON.stringify(rShoul));
    
    // var x = 10*landmarks[15].x
    // var y = 10*landmarks[15].y
    // var pos0 = {x:x,y:y,z:1*landmarks[15].z};
    // GlobalUnityInstance.SendMessage("DataReciiver","keypointData9", JSON.stringify(pos0));

    // var x1 = 10*landmarks[16].x
    // var y1 = 10*landmarks[16].y
    // var pos01 = {x:x1,y:y1,z:1*landmarks[16].z};
    // GlobalUnityInstance.SendMessage("DataReciiver","keypointData10", JSON.stringify(pos01));