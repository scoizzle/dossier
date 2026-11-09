# Fact 94b508f2

Store id: 8043e483-6930-4bab-ade8-7836665a5d94

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
- posted_at: `2026-11-09T23:32:01.4785200+00:00`

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
  "id": "8043e483-6930-4bab-ade8-7836665a5d94",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.4785200+00:00"
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
  "subject_id": "ccb3813c-5952-4078-a998-ca5ffbb1174d",
  "subject_name": "django/db/models/functions/json::JSONObject.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, **fields)"
}
```
