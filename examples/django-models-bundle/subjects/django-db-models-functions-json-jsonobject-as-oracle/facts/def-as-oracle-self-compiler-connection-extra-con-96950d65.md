# Fact 96950d65

Store id: d9a5d59d-6865-4d4b-8a76-fed6e31b7439

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
- posted_at: `2026-11-09T23:32:01.5119240+00:00`

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
  "id": "d9a5d59d-6865-4d4b-8a76-fed6e31b7439",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.5119240+00:00"
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
  "subject_id": "a5e8d45b-ca9e-4e29-b5ef-e80f1742c19f",
  "subject_name": "django/db/models/functions/json::JSONObject.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
