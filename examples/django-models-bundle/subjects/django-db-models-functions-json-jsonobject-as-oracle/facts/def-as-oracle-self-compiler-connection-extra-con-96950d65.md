# Fact 96950d65

Store id: f5f1a3c3-4f55-471e-b32e-b72e1a9e20e1

## Text

```text
def as_oracle(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T22:39:46.4056560+00:00`

## Data

```json
{
  "end_line": 124,
  "entity_kind": "method",
  "parent": "JSONObject",
  "start_line": 123,
  "symbol": "JSONObject.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":123,"selector":"L123-L124","symbol":"JSONObject.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/json::JSONObject.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 124,
    "entity_kind": "method",
    "parent": "JSONObject",
    "start_line": 123,
    "symbol": "JSONObject.as_oracle"
  },
  "id": "f5f1a3c3-4f55-471e-b32e-b72e1a9e20e1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.4056560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 123,
        "selector": "L123-L124",
        "symbol": "JSONObject.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/json.py"
    }
  ],
  "status": "live",
  "subject_id": "5369e87f-a08a-4b72-8f76-7434b1c9088e",
  "subject_name": "django/db/models/functions/json::JSONObject.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
