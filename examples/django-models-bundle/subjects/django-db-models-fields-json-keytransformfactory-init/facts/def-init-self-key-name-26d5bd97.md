# Fact 26d5bd97

Store id: 1b7d4188-2c59-439b-8554-6a18d8dd1422

## Text

```text
def __init__(self, key_name)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:58.0434350+00:00`

## Data

```json
{
  "end_line": 764,
  "entity_kind": "method",
  "parent": "KeyTransformFactory",
  "start_line": 763,
  "symbol": "KeyTransformFactory.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":763,"selector":"L763-L764","symbol":"KeyTransformFactory.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::KeyTransformFactory.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 764,
    "entity_kind": "method",
    "parent": "KeyTransformFactory",
    "start_line": 763,
    "symbol": "KeyTransformFactory.__init__"
  },
  "id": "1b7d4188-2c59-439b-8554-6a18d8dd1422",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.0434350+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 763,
        "selector": "L763-L764",
        "symbol": "KeyTransformFactory.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "ad977a5e-5a4f-4370-8246-66ca2a9fdf7c",
  "subject_name": "django/db/models/fields/json::KeyTransformFactory.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, key_name)"
}
```
