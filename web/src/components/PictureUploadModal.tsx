import { Portal } from "@chakra-ui/react";
import { useEffect } from "react";

import Uppy from "@uppy/core";
import "@uppy/core/dist/style.min.css";
import "@uppy/dashboard/dist/style.min.css";
import { DashboardModal } from "@uppy/react";
import XHRUpload from "@uppy/xhr-upload";
import { toast } from "react-toastify";
import "./uppy.css";

//todo env var
const endpoint = "https://localhost:7017/api/pets/upload-profile-pic";

const uppy = new Uppy({
  restrictions: {
    maxFileSize: 1024 * 1024,
    maxNumberOfFiles: 1,
    minNumberOfFiles: 1,
    allowedFileTypes: ["image/bmp", "image/png"]
  }
}).use(XHRUpload, {
  endpoint: endpoint,
  withCredentials: true
});

export type Props = {
  petId: number;
  isOpen: boolean;
  onClose: () => void;
  onUploadSuccess: () => void;
};

export const PictureUploadModal = ({
  petId,
  isOpen,
  onClose,
  onUploadSuccess
}: Props) => {
  const closeModal = () => {
    uppy.cancelAll();
    onClose();
  };

  useEffect(
    () =>
      uppy.getPlugin("XHRUpload")?.setOptions({
        endpoint: `${endpoint}/${petId}`,
        validateStatus: (statusCode: number) => {
          if (statusCode === 200) {
            onUploadSuccess();
            toast.success("Picture uploaded successfully");
            return true;
          }
          return false;
        }
      }),
    [petId, onUploadSuccess]
  );

  return (
    <Portal>
      <DashboardModal
        open={isOpen}
        onRequestClose={closeModal}
        uppy={uppy}
        note=".bmp and .png files, maximum 1 MB"
        proudlyDisplayPoweredByUppy={false}
        thumbnailType="image/png"
        closeAfterFinish={true}
      />
    </Portal>
  );
};
