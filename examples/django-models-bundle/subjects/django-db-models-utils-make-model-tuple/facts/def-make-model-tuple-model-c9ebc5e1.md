# Fact c9ebc5e1

Store id: a44ea517-6b0b-4926-97f7-c7b735ed37b5

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
- posted_at: `2026-11-09T22:39:52.1113640+00:00`

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
  "id": "a44ea517-6b0b-4926-97f7-c7b735ed37b5",
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
    "posted_at": "2026-11-09T22:39:52.1113640+00:00"
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
  "subject_id": "eca21d29-683c-45aa-8316-6512f45c159f",
  "subject_name": "django/db/models/utils::make_model_tuple",
  "tags": [
    "entity:function"
  ],
  "text": "def make_model_tuple(model)"
}
```
