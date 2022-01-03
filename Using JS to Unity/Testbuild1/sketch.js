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
  poseNet = ml5.poseNet(video, modelLoaded);
  poseNet.on('pose', gotPoses);
  // var pos = {x:1,y:2,z:3};
  // gameInstance.SendMessage("DataReciiver","TestJson", JSON.stringify(pos));
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

    // var posN = {x:pose.nose.x,y:pose.nose.y,z:d};
    // var jsonString = JSON.stringify(posN);
    // GlobalUnityInstance.SendMessage("DataReciiver","setNoseData", jsonString);

    for (let i = 0; i < pose.keypoints.length; i++) {
      var pos = {length:pose.keypoints.length, i:pose.keypoints[i], x:pose.keypoints[i].position.x, y:pose.keypoints[i].position.y, z:d};
      var posJsonString = JSON.stringify(pos);
      GlobalUnityInstance.SendMessage("DataReciiver","setNoseData", posJsonString);
    }


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



