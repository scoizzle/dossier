# Fact d30e2b0f

Store id: d4a67159-85d0-4388-872c-cc8ac8b24850

## Text

```text
def as_sql(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:32:01.4601260+00:00`

## Data

```json
{
  "end_line": 17,
  "entity_kind": "method",
  "parent": "JSONArray",
  "start_line": 12,
  "symbol": "JSONArray.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":12,"selector":"L12-L17","symbol":"JSONArray.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/functions/json::JSONArray.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 17,
    "entity_kind": "method",
    "parent": "JSONArray",
    "start_line": 12,
    "symbol": "JSONArray.as_sql"
  },
  "id": "d4a67159-85d0-4388-872c-cc8ac8b24850",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.4601260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 12,
        "selector": "L12-L17",
        "symbol": "JSONArray.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/json.py"
    }
  ],
  "status": "live",
  "subject_id": "a6ced4ea-e89d-4caa-8b40-f79dfcec6753",
  "subject_name": "django/db/models/functions/json::JSONArray.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection, **extra_context)"
}
```
