# Fact 0b5218d1

Store id: b54aff3a-5388-4892-9b53-1354c3076adb

## Text

```text
def as_postgresql(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:32:01.5091180+00:00`

## Data

```json
{
  "end_line": 121,
  "entity_kind": "method",
  "parent": "JSONObject",
  "start_line": 99,
  "symbol": "JSONObject.as_postgresql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":99,"selector":"L99-L121","symbol":"JSONObject.as_postgresql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/json::JSONObject.as_postgresql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 121,
    "entity_kind": "method",
    "parent": "JSONObject",
    "start_line": 99,
    "symbol": "JSONObject.as_postgresql"
  },
  "id": "b54aff3a-5388-4892-9b53-1354c3076adb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.5091180+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 99,
        "selector": "L99-L121",
        "symbol": "JSONObject.as_postgresql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/json.py"
    }
  ],
  "status": "live",
  "subject_id": "303e5ad9-ea90-47b8-b7ce-b67b9b1ece3d",
  "subject_name": "django/db/models/functions/json::JSONObject.as_postgresql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_postgresql(self, compiler, connection, **extra_context)"
}
```
