# Fact 32f52269

Store id: dbfb162c-ac18-47ef-84a6-820bf2142264

## Text

```text
def create_many_to_many_intermediary_model(field, klass)
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
- posted_at: `2026-11-09T23:31:58.8201380+00:00`

## Data

```json
{
  "end_line": 1455,
  "entity_kind": "function",
  "parent": "related",
  "start_line": 1401,
  "symbol": "create_many_to_many_intermediary_model"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1401,"selector":"L1401-L1455","symbol":"create_many_to_many_intermediary_model"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::create_many_to_many_intermediary_model](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1455,
    "entity_kind": "function",
    "parent": "related",
    "start_line": 1401,
    "symbol": "create_many_to_many_intermediary_model"
  },
  "id": "dbfb162c-ac18-47ef-84a6-820bf2142264",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.8201380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1401,
        "selector": "L1401-L1455",
        "symbol": "create_many_to_many_intermediary_model"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "99da41e8-8f9c-48b3-ab7d-93c2f75a8149",
  "subject_name": "django/db/models/fields/related::create_many_to_many_intermediary_model",
  "tags": [
    "entity:function"
  ],
  "text": "def create_many_to_many_intermediary_model(field, klass)"
}
```
