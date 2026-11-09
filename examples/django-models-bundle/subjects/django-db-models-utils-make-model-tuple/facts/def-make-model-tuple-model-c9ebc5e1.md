# Fact c9ebc5e1

Store id: 8fdfc09c-5f43-40bd-8e20-e9537554de06

## Text

```text
def make_model_tuple(model)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:45:00.0087030+00:00`

## Data

```json
{
  "end_line": 25,
  "entity_kind": "function",
  "parent": "utils",
  "start_line": 5,
  "symbol": "make_model_tuple"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":5,"selector":"L5-L25","symbol":"make_model_tuple"}`

## Items

```json
[
  {
    "text": "Take a model or a string of the form \"app_label.ModelName\" and return a corresponding (\"app_label\", \"modelname\") tuple. If a tuple is passed in, assume it's a valid model tuple already and return it unchanged.",
    "locator": {
      "line": 6
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/utils::make_model_tuple](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 25,
    "entity_kind": "function",
    "parent": "utils",
    "start_line": 5,
    "symbol": "make_model_tuple"
  },
  "id": "8fdfc09c-5f43-40bd-8e20-e9537554de06",
  "items": [
    {
      "locator": {
        "line": 6
      },
      "text": "Take a model or a string of the form \"app_label.ModelName\" and return a corresponding (\"app_label\", \"modelname\") tuple. If a tuple is passed in, assume it's a valid model tuple already and return it unchanged."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:45:00.0087030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 5,
        "selector": "L5-L25",
        "symbol": "make_model_tuple"
      },
      "rel": "derived_from",
      "target": "django/db/models/utils.py"
    }
  ],
  "status": "live",
  "subject_id": "59c9b525-a328-4815-aa3a-c28a74f89192",
  "subject_name": "django/db/models/utils::make_model_tuple",
  "tags": [
    "entity:function"
  ],
  "text": "def make_model_tuple(model)"
}
```
