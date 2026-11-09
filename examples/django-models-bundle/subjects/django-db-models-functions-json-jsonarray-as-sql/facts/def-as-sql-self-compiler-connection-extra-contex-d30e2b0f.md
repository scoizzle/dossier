# Fact d30e2b0f

Store id: 75c4fe08-a1ad-4d95-9ad4-69fc8b4c1310

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
- posted_at: `2026-11-09T22:39:46.3675430+00:00`

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
  "id": "75c4fe08-a1ad-4d95-9ad4-69fc8b4c1310",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.3675430+00:00"
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
  "subject_id": "8d06887a-5731-4663-98fb-defc79d3729a",
  "subject_name": "django/db/models/functions/json::JSONArray.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection, **extra_context)"
}
```
