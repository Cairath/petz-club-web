const isoDateFormat =
  /^\d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2}(?:\.\d{1,7})?(?:Z|[+-]\d{2}:?\d{2})$/;

// eslint-disable-next-line @typescript-eslint/no-explicit-any
const isIsoDateString = (value: any): boolean => {
  return value && typeof value === "string" && isoDateFormat.test(value);
};

// eslint-disable-next-line @typescript-eslint/no-explicit-any
export function handleDates(body: any) {
  if (body === null || body === undefined || typeof body !== "object")
    return body;

  for (const key of Object.keys(body)) {
    const value = body[key];
    if (isIsoDateString(value)) {
      body[key] = new Date(value);
    } else if (typeof value === "object") {
      handleDates(value);
    }
  }
}
