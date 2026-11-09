# Fact 94b508f2

Store id: 5f9d5fb3-c082-442b-9c82-99219614ae09

## Text

```text
def __init__(self, **fields)
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
- posted_at: `2026-11-09T23:44:53.5501140+00:00`

## Data

```json
{
  "end_line": 76,
  "entity_kind": "method",
  "parent": "JSONObject",
  "start_line": 72,
  "symbol": "JSONObject.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":72,"selector":"L72-L76","symbol":"JSONObject.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/functions/json::JSONObject.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 76,
    "entity_kind": "method",
    "parent": "JSONObject",
    "start_line": 72,
    "symbol": "JSONObject.__init__"
  },
  "id": "5f9d5fb3-c082-442b-9c82-99219614ae09",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.5501140+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 72,
        "selector": "L72-L76",
        "symbol": "JSONObject.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/json.py"
    }
  ],
  "status": "live",
  "subject_id": "8404ac66-fe98-4427-b8ec-cd441d1d79d9",
  "subject_name": "django/db/models/functions/json::JSONObject.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, **fields)"
}
```
