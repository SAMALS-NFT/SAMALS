import * as React from "react";
import Skeleton from "@mui/material/Skeleton";
import Stack from "@mui/material/Stack";

const AnimalDetail = ({ animalDetail }) => {
  //prop을 정상적으로 받았는지 확인
  //prop을 부모 컴포넌트로부터 받음
  //console.log(animalDetail);
  return (
    <div className="AnimalDetail">
      <h2>멸종위기동물 세부정보</h2>
      <h4>{animalDetail.length} 개수 필요 없지 않나</h4>
      <div>
        {animalDetail.map((it) => (
          <div key={it.id}>
            <div> animal_name : {it.name} </div>
            <div> animal_grade : {it.name} </div>
            <div> animal_count : {it.name} </div>
            <div> animal_detail : {it.name} </div>
          </div>
        ))}
      </div>

      <Stack spacing={1}>
        {/* For variant="text", adjust the height via font-size */}
        <Skeleton variant="text" sx={{ fontSize: "1rem" }} />

        {/* For other variants, adjust the size with `width` and `height` */}
        <Skeleton variant="circular" width={40} height={40} />
        <Skeleton variant="rectangular" width={210} height={60} />
        <Skeleton variant="rounded" width={210} height={60} />
      </Stack>
    </div>
  );
};

// prop가 undefined로 내려왔을 때(전달 받았을 때) props의 기본 값을 설정 가능
AnimalDetail.defaultProps = {
  animalDetail: [],
};

export default AnimalDetail;
