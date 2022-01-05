// ml5.js: Pose Estimation with PoseNet
// The Coding Train / Daniel Shiffman
// https://thecodingtrain.com/learning/ml5/7.1-posenet.html
// https://youtu.be/OIo-DIOkNVg
// https://editor.p5js.org/codingtrain/sketches/ULA97pJXR

let video;
let poseNet;
let pose;
let skeleton;

function setup() {
  createCanvas(640, 480);
  video = createCapture(VIDEO);
  video.hide();

  const poseNetOptions = {
    architecture: 'MobileNetV1',
    imageScaleFactor: 0.3,
    outputStride: 16,
    flipHorizontal: false,
    minConfidence: 1,
    maxPoseDetections: 5,
    scoreThreshold: 0.5,
    nmsRadius: 20,
    detectionType: 'single',
    inputResolution: 513,
    multiplier: 0.75,
    quantBytes: 2,
  };

  poseNet = ml5.poseNet(video, poseNetOptions, modelLoaded);
  poseNet.on('pose', gotPoses);
}

function gotPoses(poses) {
  //console.log(poses);
  if (poses.length > 0) {
    pose = poses[0].pose;
    skeleton = poses[0].skeleton;
  }

}

function modelLoaded() {

  console.log('poseNet ready');
}

// let keypoint;
// var jsonString;
// let one = {handposeValues: { one :{ x:0, y:0,z:0}}};
// function mainFunc(poses) {
//   console.log('working');
//     poses = detector.estimatePoses(video);
//     predictions=poses;
//     console.log(predictions)
//     for (let i = 0; i < predictions.length; i += 1){
//       const prediction = predictions[i];
//       for (let j = 0; j < prediction.keypoints.length; j += 1)
//       {
//         keypoint= prediction.keypoints[j];
//         one.handposeValues[keypoint.name] = {x:keypoint.x, y:keypoint.y};
//       }
//     }
//     jsonString = JSON.stringify(one.handposeValues);
//     unityInstance.SendMessage('DataReciiver', 'TestJson', jsonString);
//     console.log("done");
// }

function draw() {
  image(video, 0, 0);

  if (pose) {
    
    let eyeR = pose.rightEye;
    let eyeL = pose.leftEye;
    let d = dist(eyeR.x, eyeR.y, eyeL.x, eyeL.y);
    fill(255, 0, 0);
    ellipse(pose.nose.x, pose.nose.y, d);
    fill(0, 0, 255);
    ellipse(pose.rightWrist.x, pose.rightWrist.y, 32);
    ellipse(pose.leftWrist.x, pose.leftWrist.y, 32);

    if(pose.keypoints[0].score > 0.7){
      var pos0 = {x:pose.nose.x,y:pose.nose.y,z:d};
      GlobalUnityInstance.SendMessage("DataReciiver","setNoseData", JSON.stringify(pos0));
    }
    // if(pose.keypoints[1].score > 0.3){
    //   var pos1 = {x:pose.leftEye.x,y:pose.leftEye.y,z:d};
    //   GlobalUnityInstance.SendMessage("DataReciiver","setNoseData1", JSON.stringify(pos1));
    // }
    // if(pose.keypoints[2].score > 0.3){
    //   var pos2 = {x:pose.rightEye.x,y:pose.rightEye.y,z:d};
    //   GlobalUnityInstance.SendMessage("DataReciiver","setNoseData2", JSON.stringify(pos2));
    // }
    // if(pose.keypoints[3].score > 0.3){
    //   var pos3 = {x:pose.leftEar.x,y:pose.leftEar.y,z:d};
    //   GlobalUnityInstance.SendMessage("DataReciiver","setNoseData3", JSON.stringify(pos3));
    // }
    // if(pose.keypoints[4].score > 0.3){
    //   var pos4 = {x:pose.rightEar.x,y:pose.rightEar.y,z:d};
    //   GlobalUnityInstance.SendMessage("DataReciiver","setNoseData4", JSON.stringify(pos4));
    // }
    // if(pose.keypoints[5].score > 0.3){
    //   var pos5 = {x:pose.leftShoulder.x,y:pose.leftShoulder.y,z:d};
    //   GlobalUnityInstance.SendMessage("DataReciiver","setNoseData5", JSON.stringify(pos5));
    // }
    // if(pose.keypoints[6].score > 0.3){
    //   var pos6 = {x:pose.rightShoulder.x,y:pose.rightShoulder.y,z:d};
    //   GlobalUnityInstance.SendMessage("DataReciiver","setNoseData6", JSON.stringify(pos6));
    // }
    // if(pose.keypoints[7].score > 0.3){
    //   var pos7 = {x:pose.leftElbow.x,y:pose.leftElbow.y,z:d};
    //   GlobalUnityInstance.SendMessage("DataReciiver","setNoseData7", JSON.stringify(pos7));
    // }
    // if(pose.keypoints[8].score > 0.3){
    //   var pos8 = {x:pose.rightElbow.x,y:pose.rightElbow.y,z:d};
    //   GlobalUnityInstance.SendMessage("DataReciiver","setNoseData8", JSON.stringify(pos8));
    // }
    // if(pose.keypoints[9].score > 0.3){
    //   var pos9 = {x:pose.leftWrist.x,y:pose.leftWrist.y,z:d};
    //   GlobalUnityInstance.SendMessage("DataReciiver","setNoseData9", JSON.stringify(pos9));
    // }
    // if(pose.keypoints[10].score > 0.3){
    //   var pos10 = {x:pose.rightWrist.x,y:pose.rightWrist.y,z:d};
    //   GlobalUnityInstance.SendMessage("DataReciiver","setNoseData10", JSON.stringify(pos10));
    // }
  
    for (let i = 0; i < pose.keypoints.length; i++) {
      let x = pose.keypoints[i].position.x;
      let y = pose.keypoints[i].position.y;
      fill(0, 255, 0);
      ellipse(x, y, 16, 16);
    }

    for (let i = 0; i < skeleton.length; i++) {
      let a = skeleton[i][0];
      let b = skeleton[i][1];
      strokeWeight(2);
      stroke(255);
      line(a.position.x, a.position.y, b.position.x, b.position.y);
    }
  }
}



