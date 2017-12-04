/**
* @source.cpp
* @Convert an image from rgb to graylevel image with OpenCV
* @author Bilal Mahmood Malik
*/
#include<opencv2\opencv.hpp>

using namespace cv;

Mat src, grayImg;

/**
* @function main
*/
int main()
{
	String imageName("Lenna.png"); // by default
	src = imread(imageName, IMREAD_COLOR); // Load an image	
	cv::cvtColor(src,grayImg,COLOR_BGR2GRAY);//converting image to gray
	cv::imshow("Source Image", src);
	cv::imshow("Resultant Gray Image", grayImg);
	cv::imwrite("result_GrayImage.jpg", grayImg);
	waitKey();

	return 0;
}